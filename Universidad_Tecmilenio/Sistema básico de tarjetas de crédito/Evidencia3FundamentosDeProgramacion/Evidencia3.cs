namespace Evidencia3FundamentosDeProgramacion
{
    internal class Evidencia3
    {
        //Reynaldo Tamez Vicencio         AL03035762
        //Luis Fernando Alcolea Tamez     AL03054504
        //Roberto Moreno Almaguer         AL03047031

        //Función para llenar arreglo bidimensional de datos de txt
        static void LlenarArray(StreamReader sr, int fila, string Linea, string[] datos, string[,] BDBanco)
        {
            //Rellenar filas de la matriz con los datos del archivo, tomando en cuenta las comas
            while (Linea != null)
            {

                datos = Linea.Split(", ");

                for (int i = 0; i < 5; i++)
                {
                    BDBanco[fila, i] = datos[i];
                }
                fila++;
                Linea = sr.ReadLine();
            }
            //Cierre de archivo
            sr.Close();
        }

        //Función para validar la existencia de alguna cuenta
        static bool ExisteCuenta(string[,] BDBanco,int numeroFila, int existeTarjeta, int existePIN)
        {
           bool existeCuenta = false;
            if(existeTarjeta != 0  && existePIN != 0 && Convert.ToInt64(BDBanco[numeroFila, 3]) > 2022)
            {
                existeCuenta = true;
            }
            return existeCuenta;
        }
        
        static void Main(string[] args)
        {
            //Creación del arreglo y línea que leerá las líneas del archivo
            string Linea;
            string[,] BDBanco = new string[4, 5];
            
            //Validar si existe el archivo
            try 
            {
                //Objetos para leer y escribir archivos
                StreamReader sr = new StreamReader("BDBanco.txt");
                StreamWriter sw = new StreamWriter("Ticket.txt");

                //arreglo para guardar datos separados por comas en campos, y variable para asignar valores a las filas del arreglo bidimensional
                int fila = 0;
                string[] datos = new string[5];

                //Leer línea
                Linea = sr.ReadLine();

                //Llamar a la función para llenar datos
                LlenarArray(sr, fila, Linea, datos, BDBanco);

                //Validar que la cuenta existe
                //Pedir al usuario número de tarjeta y PIN, y ver si está vencida la tarjeta o no
                Console.WriteLine("Bancos Ferrocencio");
                Console.WriteLine("Introduce tu tarjeta de crédito");
                string numeroTarjetaEntrada = Console.ReadLine();

                Console.WriteLine("Introduce tu PIN");
                string numeroPINEntrada = Console.ReadLine();

                //Variables para detectar si existe la cuenta y saber dónde está localizada
                int numeroFila = 0;
                int existeTarjeta = 0;
                int existePIN = 0;
                bool existeCuenta;

                //Recorridos por el arreglo para buscar el número de tarjeta y de PIN y saber su ubicación
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (numeroTarjetaEntrada == BDBanco[i, j])
                        {
                            numeroFila = i;
                            existeTarjeta++;
                        }
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (numeroPINEntrada == BDBanco[i, j])
                        {
                            numeroFila = i;
                            existePIN++;
                        }
                    }
                }

                //Llamar a la función para validar si existe la cuenta
                existeCuenta = ExisteCuenta(BDBanco, numeroFila, existeTarjeta, existePIN);
                
                //Si la cuenta existe, mostrar las opciones al usuario
                if(existeCuenta == true)
                {
                    //Pedir al usuario la opción que desea realizar
                    Console.WriteLine("Bienvenido: " + BDBanco[numeroFila, 0]);
                    Console.WriteLine("Qué opción quieres realizar\n1. Consulta de saldo\t2. Retiro de dinero\t3. Transferencia\t4. Depósito de dinero");
                    string opcion = Console.ReadLine();

                    //Validar qué opción escogió
                    switch(opcion)
                    {
                        //Consulta de saldo e impresión de ticket
                        case "1":
                            Console.WriteLine("Hola: " + BDBanco[numeroFila, 0]);
                            Console.WriteLine("Tu saldo actual es de: " + BDBanco[numeroFila, 4]);
                            Console.WriteLine("\nEnter para imprimir ticket");
                            Console.ReadLine();
                            sw.WriteLine("Bancos Ferrocencio");
                            sw.WriteLine("Cuenta: " + BDBanco[numeroFila, 0]);
                            sw.WriteLine("Su saldo: " + BDBanco[numeroFila, 4]);
                            sw.WriteLine("\n¡Gracias por su visita!");
                        break;

                        //Retirar dinero
                        case "2":
                            //Pedir al usuario cantidad a retirar y validar si se cuenta con saldo suficiente
                            //Se muestra en consola y se imprime el ticket con la información
                            Console.WriteLine("¿Cuánto desea retirar?");
                            double cantidadRetirar = Convert.ToDouble(Console.ReadLine());
                            if(cantidadRetirar <= Convert.ToDouble(BDBanco[numeroFila, 4]))
                            {
                                double totalSaldo = 0;
                                double saldo = Convert.ToDouble(BDBanco[numeroFila, 4]);
                                Console.WriteLine("\nHola: " + BDBanco[numeroFila, 0]);
                                sw.WriteLine("Bancos Ferrocencio");
                                sw.WriteLine("Cuenta: " + BDBanco[numeroFila, 0]);
                                Console.WriteLine("Saldo anterior: " + saldo);
                                sw.WriteLine("Saldo anterior: " + saldo);

                                //Operación
                                totalSaldo = saldo - cantidadRetirar;
                                BDBanco[numeroFila, 4] = Convert.ToString(totalSaldo);
                                Console.WriteLine("Cantidad retirada: " + cantidadRetirar);
                                Console.WriteLine("Saldo actual: " + BDBanco[numeroFila, 4]);
                                
                                Console.WriteLine("\nEnter para imprimir ticket");
                                Console.ReadLine();
                                sw.WriteLine("Cantidad retirada: " + cantidadRetirar);
                                sw.WriteLine("Saldo actual: " + BDBanco[numeroFila, 4]);
                                sw.WriteLine("\n¡Gracias por su visita!");
                            }
                            else
                            {
                                Console.WriteLine("No posee el saldo suficiente para retirar esa cantidad");
                            }
                        break;
                        
                        //Transferir dinero
                        case "3":
                            //Pedir al usuario la cuenta a la que le transferirá dinero, que no sea su propia cuenta
                            Console.WriteLine("Introduzca los datos de la cuenta a transferir");
                            Console.WriteLine("Número de tarjeta");
                            string numeroTarjetaTransferir = Console.ReadLine();
                            Console.WriteLine("Número de PIN");
                            string numeroPINTransferir = Console.ReadLine();

                            //Se realiza el mismo proceso anterior para determinar si la cuenta existe, y saber en dónde está ubicada
                            int numeroFilaTransferir = 0;
                            int existeTarjetaTransferir = 0;
                            int existePINTransferir = 0;
                            bool existeCuentaTransferir;

                            for (int i = 0; i < 4; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    if (numeroTarjetaTransferir == BDBanco[i, j])
                                    {
                                        numeroFilaTransferir = i;
                                        existeTarjetaTransferir++;
                                    }
                                }
                            }

                            for (int i = 0; i < 4; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    if (numeroPINTransferir == BDBanco[i, j])
                                    {
                                        numeroFilaTransferir = i;
                                        existePINTransferir++;
                                    }
                                }
                            }

                            existeCuentaTransferir = ExisteCuenta(BDBanco, numeroFilaTransferir, existeTarjetaTransferir, existePINTransferir);

                            //Validar si la cuenta existe
                            if(existeCuentaTransferir = true && numeroTarjetaTransferir != numeroTarjetaEntrada && numeroPINTransferir != numeroPINEntrada)
                            {
                                //Pedir al usuario cantidad a transferir
                                Console.WriteLine("Introduzca la cantidad de dinero a transferir");
                                double cantidadTransferir = Convert.ToDouble(Console.ReadLine());

                                //Validar que se posee el saldo suficiente para poder realizar dicha acción
                                if(cantidadTransferir <= Convert.ToDouble(BDBanco[numeroFila, 4]))
                                {
                                    double totalSaldoRestante = 0;
                                    double totalSaldoActualUsuario = 0;
                                    double saldoActual = Convert.ToDouble(BDBanco[numeroFila, 4]);
                                    double saldoDeUsuario = Convert.ToDouble(BDBanco[numeroFilaTransferir, 4]);
                                    Console.WriteLine("\nHola: " + BDBanco[numeroFila, 0]);

                                    Console.WriteLine("\nTransfirió dinero a: " + BDBanco[numeroFilaTransferir, 0]);
                                    Console.WriteLine("Saldo anterior: " + saldoActual);
                                    
                                    //Operaciones
                                    totalSaldoRestante = saldoActual - cantidadTransferir;
                                    totalSaldoActualUsuario = saldoDeUsuario + cantidadTransferir;
                                    BDBanco[numeroFila, 4] = Convert.ToString(totalSaldoRestante);
                                    BDBanco[numeroFilaTransferir, 4] = Convert.ToString(totalSaldoActualUsuario);
                                    Console.WriteLine("Cantidad transferida: " + cantidadTransferir);
                                    Console.WriteLine("Saldo actual: " + totalSaldoRestante);
                                    Console.WriteLine("Presione enter para imprimir el ticket");
                                    Console.ReadLine();
                                    //Imprimir ticket
                                    sw.WriteLine("Bancos Ferroncencio");
                                    sw.WriteLine("Cuenta: " + BDBanco[numeroFila, 0]);
                                    sw.WriteLine("Transfirió dinero a: " + BDBanco[numeroFilaTransferir, 0]);
                                    sw.WriteLine("Saldo anterior: " + saldoActual);
                                    sw.WriteLine("Cantidad transferida: " + cantidadTransferir);
                                    sw.WriteLine("Saldo actual: " + BDBanco[numeroFila, 4]);
                                    sw.WriteLine("\n¡Gracias por visitarnos!");
                                }
                                else
                                {
                                    Console.WriteLine("No posee saldo suficiente para transferir dinero");
                                }
                            }
                            else
                            {
                                Console.WriteLine("La cuenta a la que deseas transferir no existe,  o pusiste datos de tu propia cuenta. \n Revisa que los datos estén correctos");
                            }

                            break;

                        //Depositar dinero
                        case "4":
                            //Pedir al usuario a dónde depositará, si a su cuenta o a una ajena
                            Console.WriteLine("Seleccione a dónde va a depositar: \n 1. Su propia cuenta\t 2. Otra cuenta");
                            string opcionDeposito = Console.ReadLine();

                            //Validar opciones
                            if(opcionDeposito == "1")
                            {
                                //Variables para operaciones
                                double cantidadDepositar;
                                double cantidadBilletes;

                                //Si la cantidad a depositar no es igual a la cantidad en billetes y/o monedas introducidas, se le seguirá pidiendo al usuario
                                do
                                {
                                    Console.WriteLine("¿Cuánto desea depositar?");
                                    cantidadDepositar = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Introduzca los billetes y/o monedas");
                                    cantidadBilletes = Convert.ToDouble(Console.ReadLine());
                                }
                                while (cantidadDepositar != cantidadBilletes);
                                
                                    //Depositar a cuenta propia
                                    //Impresión en consola y de ticket
                                    double totalSaldo = 0;
                                    double saldo = Convert.ToDouble(BDBanco[numeroFila, 4]);
                                    Console.WriteLine("\nHola: " + BDBanco[numeroFila, 0]);
                                    sw.WriteLine("Bancos Ferrocencio");
                                    sw.WriteLine("Cuenta: " + BDBanco[numeroFila, 0]);
                                    Console.WriteLine("Saldo anterior: " + saldo);
                                    sw.WriteLine("Saldo anterior: " + saldo);

                                    //Operación
                                    totalSaldo = saldo + cantidadDepositar;
                                    BDBanco[numeroFila, 4] = Convert.ToString(totalSaldo);
                                    Console.WriteLine("Cantidad depositar: " + cantidadDepositar);
                                    Console.WriteLine("Saldo actual: " + BDBanco[numeroFila, 4]);

                                    Console.WriteLine("\nEnter para imprimir ticket");
                                    Console.ReadLine();
                                    sw.WriteLine("Cantidad depositada: " + cantidadDepositar);
                                    sw.WriteLine("Saldo actual: " + BDBanco[numeroFila, 4]);
                                    sw.WriteLine("\n¡Gracias por su visita!");
                                
                            }
                            else
                            {
                                if(opcionDeposito == "2")
                                {
                                    //Se realiza la misma acción nuevamente para determinar si la cuenta existe y su ubicación
                                    Console.WriteLine("Introduzca los datos de la cuenta a depositar");
                                    Console.WriteLine("Número de tarjeta");
                                    string numeroTarjetaDepositar = Console.ReadLine();
                                    Console.WriteLine("Número de PIN");
                                    string numeroPINDepositar = Console.ReadLine();

                                    int numeroFilaDepositar = 0;
                                    int existeTarjetaDepositar = 0;
                                    int existePINDepositar = 0;
                                    bool existeCuentaDepositar;

                                    for (int i = 0; i < 4; i++)
                                    {
                                        for (int j = 0; j < 5; j++)
                                        {
                                            if (numeroTarjetaDepositar == BDBanco[i, j])
                                            {
                                                numeroFilaDepositar = i;
                                                existeTarjetaDepositar++;
                                            }
                                        }
                                    }

                                    for (int i = 0; i < 4; i++)
                                    {
                                        for (int j = 0; j < 5; j++)
                                        {
                                            if (numeroPINDepositar == BDBanco[i, j])
                                            {
                                                numeroFilaDepositar = i;
                                                existePINDepositar++;
                                            }
                                        }
                                    }

                                    existeCuentaDepositar = ExisteCuenta(BDBanco, numeroFilaDepositar, existeTarjetaDepositar, existePINDepositar);

                                    //Validar si existe cuenta y que no se deposita a si mismo
                                    if (existeCuentaDepositar = true && numeroTarjetaDepositar != numeroTarjetaEntrada && numeroPINDepositar != numeroPINEntrada)
                                    {
                                        double cantidadDepositar;
                                        double cantidadDepositarBilletes;

                                        //Pedir al usuario cantidad a depositar y la cantidad en billetes y/o monedas, hacerlo si ambas cantidades son diferentes
                                        do
                                        {
                                            Console.WriteLine("Introduzca la cantidad de dinero a depositar");
                                            cantidadDepositar = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Introduzca los billetes y/o monedas");
                                            cantidadDepositarBilletes = Convert.ToDouble(Console.ReadLine());
                                        }
                                        while (cantidadDepositar != cantidadDepositarBilletes);

                                            
                                            double totalSaldoActualUsuario = 0;
                                            double saldoDeUsuario = Convert.ToDouble(BDBanco[numeroFilaDepositar, 4]);

                                            Console.WriteLine("\nHola: " + BDBanco[numeroFila, 0]);
                                            Console.WriteLine("\nDepositó dinero a: " + BDBanco[numeroFilaDepositar, 0]);
                                            
                                            //Operación
                                            totalSaldoActualUsuario = saldoDeUsuario + cantidadDepositar;
                                            BDBanco[numeroFilaDepositar, 4] = Convert.ToString(totalSaldoActualUsuario);
                                            Console.WriteLine("Cantidad Depositada: " + cantidadDepositar);
                                            Console.WriteLine("Presione enter para imprimir el ticket");
                                            Console.WriteLine("Saldo de otra cuenta: " + BDBanco[numeroFilaDepositar, 4]);
                                            Console.ReadLine();

                                            //Impresión de ticket
                                            sw.WriteLine("Bancos Ferrocencio");
                                            sw.WriteLine("Cuenta: " + BDBanco[numeroFila, 0]);
                                            sw.WriteLine("Depositó dinero a: " + BDBanco[numeroFilaDepositar, 0]);
                                            sw.WriteLine("Cantidad Depositada: " + cantidadDepositar);
                                            sw.WriteLine("\n¡Gracias por visitarnos!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("La cuenta a la que deseas depositar no existe, o pusiste datos de tu cuenta. \n Revisa que los datos estén correctos");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("La opción es incorrecta");
                                }
                            }

                        break;

                        default:
                            Console.WriteLine("Opción no correcta");
                        break;
                    }
                    //Limpiar consola al finalizar la operación y cerrar el archivo al que se le escribió
                    Console.Clear();
                    sw.Close();
                }
                else
                {
                    Console.WriteLine("La cuenta no existe o probablemente su plástico venció y tenga que renovarlo "); 
                }
                    

            }
            catch(Exception e)
            {
                Console.WriteLine("El archivo no existe");    
            }
            finally
            {
                Console.WriteLine("Proceso terminado");
            }
        }
    }
}