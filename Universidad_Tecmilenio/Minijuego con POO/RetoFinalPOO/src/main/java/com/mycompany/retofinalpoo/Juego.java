/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.retofinalpoo;
import java.io.*;
import java.util.ArrayList;
import java.lang.Math;

/**
 *
 * @author reyna
 */
public class Juego {
    public static BufferedReader entrada = new BufferedReader(new InputStreamReader(System.in));
    //Atributos
    private int dificultad;
    private ArrayList<String> ListaNombresJugadores;
    private boolean TesoroEncontrado;
    
    //Constructor
    public Juego(int valorDificultad, ArrayList<String> ListaNombresDeJugadores)
    {
        this.dificultad = valorDificultad;
        this.ListaNombresJugadores = ListaNombresDeJugadores;
        this.TesoroEncontrado = false;
    }
    
    //Crear listas de objetos para jugadores y mundos
    ArrayList<Jugador> ListaJugadores = new ArrayList<Jugador>();
    ArrayList<Mundo> ListaMundos = new ArrayList<Mundo>();
    
    //Crear mundo inicial
    Mundo mundoInicial = new Mundo(0,0);
        
    //Crear objetos de jugadores y mundos por default
    Jugador jugadorJugando = new Jugador();
    Mundo mundoActual = new Mundo();
    
    //Mundo destino que escogerá el jugador al jugar
    Mundo mundoDestino = new Mundo();
    
    //Método para generar mundos y regresar una lista de mundos
    private void GenerarMundos()
    {
        //Cantidad de mundos a generar
        int cantMundos = 0;
        
        //Contenido del mundo, dependiendo de la dificultad
        int ContenidoMundos1[] = {0,0,0,0,0,0,0,0,0,0,0,1,2,3,4};
        int ContenidoMundos2[] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,2,2,2,3,3,3,3,4,4,4};
        int ContenidoMundos3[] = {0,0,0,0,0,0,0,0,0,0,0,1,2,2,2,2,2,2,2,3,3,3,3,3,3,4,4,4,4,4};
        
        //Lista para guardar el contenido de los mundos despues de seleccionar la dificultad
        ArrayList<Integer> ContenidoMundosSeleccionados = new ArrayList<Integer>();
        
        //En todos los casos se guardan los elementos del arreglo a la lista, con base a la dificultad
        //Fácil
        if(this.dificultad == 1)
        {
            cantMundos = 15;
            
            for(int i = 0; i < ContenidoMundos1.length; i++)
            {
                ContenidoMundosSeleccionados.add(i, ContenidoMundos1[i]);
            }
            
        }
        
        //Intermedio
        else if(this.dificultad == 2)
        {
            cantMundos = 25;
            for(int i = 0; i < ContenidoMundos2.length; i++)
            {
                ContenidoMundosSeleccionados.add(i, ContenidoMundos2[i]);
            }
        }
        
        //Dificil
        else if(this.dificultad == 3)
        {
            cantMundos = 30;
            for(int i = 0; i < ContenidoMundos3.length; i++)
            {
                ContenidoMundosSeleccionados.add(i, ContenidoMundos3[i]);
            }
        }
        
        //Arreglo para los números de los mundos
       int NumerosMundo[] = new int[cantMundos];
            
            //Agregar números para los mundos en un arreglo, sin que se repitan
            for(int i = 0; i < cantMundos; i++)
            {
                NumerosMundo[i] = (int)(Math.random() * 100) + 1;
                
                for(int j = 0; j < i; j++)
                {
                    if(NumerosMundo[i] == NumerosMundo[j])
                    {
                        i--;
                    }
                }
            }
            
            //Arreglos para crear los grupos de caminos de los mundos
            int grupoCaminos1[] = new int[cantMundos];
            int grupoCaminos2[] = new int[cantMundos];
            
            
            //Asignar los números de los mundos a los arreglos
            for(int i = 0; i < cantMundos; i++)
            {
                grupoCaminos1[i] = NumerosMundo[i];
                grupoCaminos2[i] = NumerosMundo[i];
            }
            
            //Agregar mundos a la lista con sus parámetros            
            for(int i = 0; i < cantMundos; i++)
            {
                //Instancia de mundo con parámetros
                Mundo miMundo = new Mundo(NumerosMundo[i], ContenidoMundosSeleccionados.get(i));
                
                //Agregar caminos a los mundos, sin dejar ningun mundo solo, y sin repeticiones
                //Grupo 1
                boolean continuar = true;
                
                //Escoger aleatoriamente un indice con el número de mundo como camino, y reemplazar por -1 para evitar que los mundos se autodirigan o tengan caminos
                //conectados a un mundo, esto para el grupo1
                while(continuar)
                {
                    int CaminoGenerar1 = (int)(Math.random()*cantMundos);
                                      
                    if(grupoCaminos1[CaminoGenerar1] != -1 && miMundo.getNumeroDeMundo() != grupoCaminos1[CaminoGenerar1])
                    {
                        miMundo.agregarCaminos(0, grupoCaminos1[CaminoGenerar1]);
                        grupoCaminos1[CaminoGenerar1] = -1;
                        continuar = false;
                    }
                    else
                    {
                        continuar = true;
                    }
                }
                
                //Grupo2
                
                //Escoger aleatoriamente un número de mundo como camino, y reemplazar por -1 para evitar que los mundos se autodirigan o tengan caminos
                //conectados a un mundo, esto para el grupo 2
                boolean continuar2 = true;
                
                while(continuar2)
                {
                    int CaminoGenerar2 = (int)(Math.random()*cantMundos);
                                      
                    if(grupoCaminos2[CaminoGenerar2] != -1 && miMundo.getNumeroDeMundo() != grupoCaminos2[CaminoGenerar2] && miMundo.getCaminos().get(0) != grupoCaminos2[CaminoGenerar2])
                    {
                        miMundo.agregarCaminos(1, grupoCaminos2[CaminoGenerar2]);
                        grupoCaminos2[CaminoGenerar2] = -1;
                        continuar2 = false;
                    }
                    else
                    {
                        continuar2 = true;
                    }
                }
                //Agregar en el mundo creado en ese instante los caminos que tendrá, en su lista de caminos
                ListaMundos.add(i,miMundo);
            }
                //Crear caminos para el mundo inicial
                boolean continuarInicial = true;
                
                //Generar aleatoriamente los caminos y validar que no se dirigan al mismo mundo
                while(continuarInicial)
                {
                    int CaminoGenerarInicial1 = (int)(Math.random()*cantMundos);
                    int CaminoGenerarInicial2 = (int)(Math.random()*cantMundos);
                    
                    if(NumerosMundo[CaminoGenerarInicial1] != NumerosMundo[CaminoGenerarInicial2])
                    {
                        mundoInicial.agregarCaminos(0, NumerosMundo[CaminoGenerarInicial1]);
                        mundoInicial.agregarCaminos(1, NumerosMundo[CaminoGenerarInicial2]);
                        continuarInicial = false;
                    }
                    else
                    {
                        continuarInicial = true;
                    }
                }
            
                       
    }
    
    //Método para generar jugadores dependiendo de la dificultad
    private void GenerarJugadores()
    {
        //Se agregan instancias jugadores a la lista con sus parámetros, dependiendo de la dificultad asignada, y de la cantidad de jugadores que van a jugar
        
        //Fácil
        if(this.dificultad == 1)
        {
            for(int i = 0; i < this.ListaNombresJugadores.size(); i++)
            {   
                Jugador miJugador =  new Jugador(this.ListaNombresJugadores.get(i), 50, mundoInicial, 5, 8, 0);
                ListaJugadores.add(i,miJugador);
            }
            
        }
        
        //Intermedio
        else if(this.dificultad == 2)
        {
            for(int i = 0; i < this.ListaNombresJugadores.size(); i++)
            {   
                Jugador miJugador =  new Jugador(this.ListaNombresJugadores.get(i), 35, mundoInicial, 3, 6, 1);
                ListaJugadores.add(i,miJugador);
            }
        }
        
        //Avanzado
        else if(this.dificultad == 3)
        {
            for(int i = 0; i < this.ListaNombresJugadores.size(); i++)
            {   
                Jugador miJugador =  new Jugador(this.ListaNombresJugadores.get(i), 25, mundoInicial, 2, 4, 2);
                ListaJugadores.add(i,miJugador);
            }
        }
        
    }
    
    //Buscar y retornar mundo encontrado por medio de su id
    private Mundo buscarMundo(int NumeroMundo)
    {
        Mundo mundoEncontrado = null;
        int i = 0;
        while(i < ListaMundos.size() && mundoEncontrado == null)
        {
            Mundo mundo = ListaMundos.get(i);
            if(mundo.getNumeroDeMundo() == NumeroMundo)
            {
                mundoEncontrado = mundo;
            }
            i++;
        }
        return mundoEncontrado;
    }
    
    //Jugar el juego
    public void jugar() throws IOException
    {
        //Generar mundos y jugadores dependiendo de la dificultad y cantidad
        GenerarMundos();
        GenerarJugadores();
        
        //Variables necesarias
        int i = 0;
        int numContenido;
        int idMundoDestino;
        int jugadoresEliminados = 0;
        
        //Ciclo general que executa el juego mientras no se haya descubierto el tesoro y mientras ningun jugador haya perdido oportunidades
        do
        {
            //Jugador actual que está jugando
            jugadorJugando = ListaJugadores.get(i);
            
            //Validar si el jugador actual tiene turno para poder jugar, oportunidades
            if(jugadorJugando.isTieneTurno())
            {
                //Imprimir datos importantes
                System.out.println("----------------------------------------------------------------------------------------------------------");
                
                //Número de mundo actual y nombre del jugador
                System.out.println("Mundo: " + jugadorJugando.getMundoActual().NumeroDeMundo);
                System.out.println("Jugador: " + jugadorJugando.Nombre);
                
                //Caminos para ir a otros mundos, los caminos con los números de mundo
                int Camino1 = jugadorJugando.getMundoActual().getCaminos().get(0);
                int Camino2 = jugadorJugando.getMundoActual().getCaminos().get(1);

                //Si se encuentra el tesoro en el mundo actual, sale este mensaje
                if(jugadorJugando.getMundoActual().getContenidoDelMundo() == 1)
                {
                    System.out.println("Tesoro: Encontraste el tesoro");
                }
                
                //Si en los mundos vecinos hay tesoro, avisar que está cerca
                else if(buscarMundo(Camino1).getContenidoDelMundo() == 1 || buscarMundo(Camino2).getContenidoDelMundo() == 1)
                {
                    System.out.println("Tesoro: el tesoro está cerca, casi lo tocas");
                }
                else
                {
                    //Si ningun caso es cierto, poner este mensaje de que está lejos el tesoro
                    System.out.println("Tesoro: el tesoro se encuentra a la distancia");
                }
                
                //Poner la energía mágica actual del jugador
                System.out.println("Te queda " + jugadorJugando.getEnergiaMagica() + " de Energía mágica");

                //Colocar los caminos que hay, a dónde puede ir el jugador
                System.out.println("Hay salidas a los mundos: " + jugadorJugando.getMundoActual().getCaminos().get(0) + ", " + jugadorJugando.getMundoActual().getCaminos().get(1));
                            
                
                //Qué efectos recibirá el jugador dependiendo de lo que haya en el mundo actual en el que está
                System.out.println("***********************************************");
                numContenido = jugadorJugando.getMundoActual().QueHayEnElMundo(ListaMundos, jugadorJugando);
                System.out.println("***********************************************");
                              
                 //Si no tiene energía mágica
                
                 if(jugadorJugando.getEnergiaMagica() <=0)
                 {
                    //Si se le acaba la energía, y tiene revitalizadores, que el jugador los use, se pone 0 a su energía para evitar cantidades negativas
                    if(jugadorJugando.getCantidadRevitalizadores() != 0)
                    {
                        jugadorJugando.setEnergiaMagica(0);
                        jugadorJugando.UsarRevitalizador();
                    }
                    
                    //Si no tiene revitalizadores usa hechizos, se le regresa al mundo inicial y se pasa al siguiente jugador
                    else if(jugadorJugando.getCantidadHechizos() != 0)
                    {
                        System.out.println("Te quedaste sin energía mágica");
                        jugadorJugando.setEnergiaMagica(0);
                        jugadorJugando.UsarHechizo();
                        System.out.println("Volviste al mundo inicial");
                        jugadorJugando.setMundoActual(mundoInicial);
                        System.out.println("Turno del siguiente jugador");
                        i++;
                    }
                    else
                    {
                        //Eliminar jugador si ya no tiene oportunidades, desactivar su turno
                        System.out.println("El jugador " + jugadorJugando.Nombre + " fue eliminado, no tiene oportunidades, ni energía mágica");
                        jugadorJugando.setTieneTurno(false);
                    }
                 }
                 
                //Usar evasor de ataque mientras el jugador tenga evasores, energía, no haya sido atacado anteriormente y solo si se topa enemigos en el mundo.
                if((numContenido == 2 || numContenido == 3 || numContenido == 4) && (jugadorJugando.getCantidadEvasoresAtaque() > 0 && jugadorJugando.getEnergiaMagica() > 0 && !jugadorJugando.isFueAtacado()))
                {
                    jugadorJugando.UsarEvasorDeAtaque();
                }
                           
                
                //Si el jugador se topa con enemigos en el mundo, se verá como atacado
                if((numContenido == 2 || numContenido == 3 || numContenido == 4) && jugadorJugando.isFueAtacado())
                {
                    System.out.println("¡Has sido atacado!");
                    
                }
                
                //Si encuentra el tesoro, activar atributo TesoroEncontrado para salir del ciclo y mandar felicitaciones
                else if(numContenido == 1)
                {
                    this.TesoroEncontrado = true;
                    System.out.println("¡GENIAL, ENCONTRASTE EL TESORO, EL PUEBLO TE LO AGRADECE! :D");
                    System.out.println("¡GANAMOS!");
                }
                
                //Si el jugador esta en un mundo tranquilo, o ya fue atacado y es su oportunidad, y además tiene turno
                else if(numContenido == 0 || !jugadorJugando.isFueAtacado() && jugadorJugando.isTieneTurno())
                {
                    
                    //Preguntarle a dónde irá mientras ponga un camino no disponible, si coloca el correcto se busca y se guarda el mundo destino
                    do
                    {
                        mundoDestino = null;
                        
                        //Pregunta
                        System.out.println("¿A dónde quieres ir?");
                        idMundoDestino = Integer.parseInt(entrada.readLine());
                        
                        //Validar existencia del camino
                        if(jugadorJugando.getMundoActual().getCaminos().contains(idMundoDestino))

                            mundoDestino = buscarMundo(idMundoDestino);

                        else
                            {
                                System.out.println("Este camino no está disponible, intente otra vez");
                            }

                    }
                    while(mundoDestino == null);
                    
                    //El jugador se mueve a otro mundo y pierde 1 de energía mágica
                    jugadorJugando.CambiarDePosicion(mundoDestino);

                }


               System.out.println("----------------------------------------------------------------------------------------------------------");
            }
            else
            {
                //Si el jugador no tiene oportunidades, se pasa a otro.
                i++;
            }
                //Se reinicia el indice cuando tenga el tamaño de la lista de jugadores para volver a pasar por ella y volver a empezar con el jugador inicial
                if(i == ListaJugadores.size())
                {
                    i = 0;
                }
                
                //Contar la cantidad de jugadores eliminados de la lista
                for(int j = 0; j < ListaJugadores.size(); j++)
                {
                   if(ListaJugadores.get(j).isTieneTurno())
                   {
                       
                   }
                   else
                   {
                       jugadoresEliminados++;
                   }
                }
                
                //Si la cantidad de jugadores eliminados es igual al tamaño de la lista, avisar que se perdió el juego
                //Se sale del ciclo y se termina el juego si todos en la lista están eliminados
                if(jugadoresEliminados == ListaJugadores.size())
                {
                    System.out.println("¡Oh no! Perdiste el juego, suerte para la próxima");
                }          
                
        }while(!(this.TesoroEncontrado) && jugadoresEliminados != ListaJugadores.size());
        
    } 
}
