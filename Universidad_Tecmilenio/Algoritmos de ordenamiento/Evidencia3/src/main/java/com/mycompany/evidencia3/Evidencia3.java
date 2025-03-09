/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.evidencia3;
import java.util.*;
import java.io.*;
import java.util.Timer;
import java.util.TimerTask;
/**
 *
 * @author reyna
 */
public class Evidencia3 {
public static BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args) throws IOException{
        
        System.out.println("Ordenamientos de datos y búsqueda de elementos\n");
        
        System.out.println("Eficiencia de algoritmos de ordenamiento");
        int timeEjecution;
        
        //Pedir al usuario tiempo mientras ponga cantidades negativas o 0 minutos
        do
        {
            //Establecer tiempo de ejecución en minutos
            System.out.println("Establesca el tiempo de ejecución en minutos (Diferente de 0 y que no sea una cantidad negativa): ");
            timeEjecution = Integer.parseInt(input.readLine());
        }
        while(timeEjecution == 0 || timeEjecution < 0);
        
        int numberOfDesiredLists;
        
        //Preguntar al usuario la cantidad de listas ordenadas que espera como mínimo
        do
        {
            //Establecer cantidad de listas ordenadas que se esperan al menos
            System.out.println("Coloque la cantidad de listas que espera que sean ordenadas, para determinar qué algoritmos cumplieron con esta cantidad: ");
             numberOfDesiredLists = Integer.parseInt(input.readLine());
        }
        while(numberOfDesiredLists == 0 || timeEjecution < 0);
        
        
        //Transformar de minutos a milisegundos
        int limitTimeEjecution = timeEjecution * 60 * 1000;
        
        
        //HashMaps para organizar la información, para guardar el tiempo de ejecución y el número de listas ordenadas de cada algoritmo
        HashMap<String, Long> algorithmsTimeEjecution = new HashMap<>();
        HashMap<String, Long> algorithmsTimeEjecutionBinarySearch = new HashMap<>();
        HashMap<String, Integer> algorithmsNumberOfListsOrdered = new HashMap<>();
        
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //Ordenamiento burbuja
        //Cantidad de listas ordenadas y tiempo de tardanza de ordenamiento
        int listasOrdenadasBurbuja = 0;
        
        //Tiempo inicial antes de ejecutar
        long startTime = System.currentTimeMillis();
        
        //Mientras no se haya pasado del tiempo establecido para ejecutar, hacer lo siguiente
        while(System.currentTimeMillis() - startTime < limitTimeEjecution && listasOrdenadasBurbuja < Integer.MAX_VALUE){
            
            //Generamos lista de números enteros aleatorios, los ordenamos con un método/algoritmo y sumamos la cantidad de listas ordenadas
            ArrayList<Integer> listOfNumbers = GenerateListOfNumbers();
            
            burbuja(listOfNumbers);   
            
            listasOrdenadasBurbuja++;
            
        }
        
        //Agregar al HashMap resultado del algoritmo, y colocar en consola la cantidad de listas ordenadas del método
        algorithmsNumberOfListsOrdered.put("Método Burbuja", listasOrdenadasBurbuja);
        System.out.println("Cantidad de listas ordenadas de 100,000 elementos en " + timeEjecution + " minutos con método burbuja: " + listasOrdenadasBurbuja);
        
        //---------------------------------------------------------------------------------------------------------------------------------------------
        //Ordenamiento selección
        //Cantidad de listas ordenadas y tiempo de tardanza de ordenamiento
        int listasOrdenadasSeleccion = 0;
        
        //Tiempo inicial antes de ejecutar
        startTime = System.currentTimeMillis();
        
        //Mientras no se haya pasado del tiempo establecido para ejecutar, hacer lo siguiente
        while(System.currentTimeMillis() - startTime < limitTimeEjecution && listasOrdenadasSeleccion < Integer.MAX_VALUE){
            
            //Generamos lista de números enteros aleatorios, los ordenamos con un método/algoritmo y sumamos la cantidad de listas ordenadas
            ArrayList listOfNumbers = GenerateListOfNumbers();
            
            selection(listOfNumbers);   
            
            listasOrdenadasSeleccion++;
            
        }
        
        //Agregar al HashMap resultado del algoritmo, y colocar en consola la cantidad de listas ordenadas del método
        algorithmsNumberOfListsOrdered.put("Método Selección", listasOrdenadasSeleccion);
        System.out.println("Cantidad de listas ordenadas de 100,000 elementos en " + timeEjecution + " minutos con método selección: " + listasOrdenadasSeleccion);
        
        //---------------------------------------------------------------------------------------------------------------------------------------------
        //Ordenamiento Merge
        //Cantidad de listas ordenadas
        int listasOrdenadasMerge = 0;
        
        //Tiempo inicial antes de ejecutar
        startTime = System.currentTimeMillis();
        
        //Mientras no se haya pasado del tiempo establecido para ejecutar, hacer lo siguiente
        while(System.currentTimeMillis() - startTime < limitTimeEjecution && listasOrdenadasMerge < Integer.MAX_VALUE){
            
            //Generamos lista de números enteros aleatorios, los ordenamos con un método/algoritmo y sumamos la cantidad de listas ordenadas
            ArrayList listOfNumbers = GenerateListOfNumbers();
            
            listOfNumbers = MergeSort(listOfNumbers);   
            
            listasOrdenadasMerge++;
            
        }
        
        //Agregar al HashMap resultado del algoritmo, y colocar en consola la cantidad de listas ordenadas del método
        algorithmsNumberOfListsOrdered.put("Método Merge", listasOrdenadasMerge);
        System.out.println("Cantidad de listas ordenadas de 100,000 elementos en " + timeEjecution + " minutos con método merge: " + listasOrdenadasMerge);
        
        //---------------------------------------------------------------------------------------------------------------------------------------------
        //Ordenamiento Quick
        //Cantidad de listas ordenadas
        int listasOrdenadasQuick = 0;
        
        //Tiempo inicial antes de ejecutar
        startTime = System.currentTimeMillis();
        
        //Mientras no se haya pasado del tiempo establecido para ejecutar, hacer lo siguiente
        while(System.currentTimeMillis() - startTime < limitTimeEjecution && listasOrdenadasQuick < Integer.MAX_VALUE){
            
            //Generamos lista de números enteros aleatorios, los ordenamos con un método/algoritmo y sumamos la cantidad de listas ordenadas
            ArrayList listOfNumbers = GenerateListOfNumbers();
            
            QuickSort(listOfNumbers);   
            
            listasOrdenadasQuick++;
            
        }
        
        //Agregar al HashMap resultado del algoritmo, y colocar en consola la cantidad de listas ordenadas del método
        algorithmsNumberOfListsOrdered.put("Método Quick", listasOrdenadasQuick);
        System.out.println("Cantidad de listas ordenadas de 100,000 elementos en " + timeEjecution + " minutos con método quick: " + listasOrdenadasQuick);
        
        //---------------------------------------------------------------------------------------------------------------------------------------------
        //Ordenamiento Shell
        //Cantidad de listas ordenadas
        int listasOrdenadasShell = 0;
        
        //Establecer nivel de incremento
            System.out.println("Nivel de incremento para el ordenamiento Shell ");
            int nShell = Integer.parseInt(input.readLine());
        
        //Tiempo inicial antes de ejecutar
        startTime = System.currentTimeMillis();
        
        //Mientras no se haya pasado del tiempo establecido para ejecutar, hacer lo siguiente
        while(System.currentTimeMillis() - startTime < limitTimeEjecution && listasOrdenadasShell < Integer.MAX_VALUE){
            
            //Generamos lista de números enteros aleatorios, los ordenamos con un método/algoritmo y sumamos la cantidad de listas ordenadas
            ArrayList listOfNumbers = GenerateListOfNumbers();
            
            ShellSort(listOfNumbers, nShell);   
            
            listasOrdenadasShell++;
            
        }
        
        //Agregar al HashMap resultado del algoritmo, y colocar en consola la cantidad de listas ordenadas del método
        algorithmsNumberOfListsOrdered.put("Método Shell", listasOrdenadasShell);
        System.out.println("Cantidad de listas ordenadas de 100,000 elementos en " + timeEjecution + " minutos con método shell: " + listasOrdenadasShell);
        
        //---------------------------------------------------------------------------------------------------------------------------------------------
        //Ordenamiento Inserción
        //Cantidad de listas ordenadas
        int listasOrdenadasInsertion = 0;
        
        //Tiempo inicial antes de ejecutar
        startTime = System.currentTimeMillis();
        
        //Mientras no se haya pasado del tiempo establecido para ejecutar, hacer lo siguiente
        while(System.currentTimeMillis() - startTime < limitTimeEjecution && listasOrdenadasInsertion < Integer.MAX_VALUE){
            
            //Generamos lista de números enteros aleatorios, los ordenamos con un método/algoritmo y sumamos la cantidad de listas ordenadas
            ArrayList listOfNumbers = GenerateListOfNumbers();
            
            InsertionSort(listOfNumbers);   
            
            listasOrdenadasInsertion++;
            
        }
        
        //Agregar al HashMap resultado del algoritmo, y colocar en consola la cantidad de listas ordenadas del método
        algorithmsNumberOfListsOrdered.put("Método Inserción", listasOrdenadasInsertion);
        System.out.println("Cantidad de listas ordenadas de 100,000 elementos en " + timeEjecution + " minutos con método inserción: " + listasOrdenadasInsertion);
        
        //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
        
        System.out.println("");
        //Ordenar HashMap de algoritmos por su cantidad de listas ordenadas (de mayor a menor)       
        List<Map.Entry<String, Integer>> numberOfListsOrderedByAlgorithms = new ArrayList<>(algorithmsNumberOfListsOrdered.entrySet());
        Collections.sort(numberOfListsOrderedByAlgorithms, Map.Entry.comparingByValue());
        
        //Mostrar el orden de los algoritmos por eficiencia
        System.out.println("Orden de algoritmos, del más eficiente al menos eficiente");
        for(int i = numberOfListsOrderedByAlgorithms.size() - 1; i >= 0; i--) {
            Map.Entry<String, Integer> entry = numberOfListsOrderedByAlgorithms.get(i);
            System.out.println(entry.getKey() + ": " + " (" + entry.getValue() + " listas ordenadas)");
            
        }
               System.out.println("");
               
        //Recorrer HashMap y validar los algoritmos que hayan cumplido con la cantidad de listas ordenadas esperada
        for(String key : algorithmsNumberOfListsOrdered.keySet()){
            if(algorithmsNumberOfListsOrdered.get(key) >= numberOfDesiredLists)
            {
                System.out.println("El " + key + " cumplió con la cantidad de listas ordenadas esperada");
            }
            else
            {
                System.out.println("El " + key + " no cumplió con la cantidad de listas ordenadas esperada");
            }
        }
        System.out.println("");
        System.out.println("Eficiencia de algoritmos de ordenamiento: ");
        
        //Lista de números
        ArrayList<Integer> listForTimeEjecution;
        
        //Se medirá la eficiencia de los algoritmos de ordenamiento, contanto los milisegundos que tardan en ordenar una lista
        //Los milisegundos se guardarán en el HashMap correspondiente
        //Burbuja
        listForTimeEjecution = GenerateListOfNumbers();
        long start = System.currentTimeMillis();
        burbuja(listForTimeEjecution);
        long end = System.currentTimeMillis();
        
        long duration = end - start;
        algorithmsTimeEjecution.put("Método burbuja", duration);
        
        //selección
        listForTimeEjecution = GenerateListOfNumbers();
        start = System.currentTimeMillis();
        selection(listForTimeEjecution);
        end = System.currentTimeMillis();
        
        duration = end - start;
        algorithmsTimeEjecution.put("Método selección", duration);
        
        //inserción
        listForTimeEjecution = GenerateListOfNumbers();
        start = System.currentTimeMillis();
        InsertionSort(listForTimeEjecution);
        end = System.currentTimeMillis();
        
        duration = end - start;
        algorithmsTimeEjecution.put("Método inserción", duration);
        
        //merge
        listForTimeEjecution = GenerateListOfNumbers();
        start = System.currentTimeMillis();
        listForTimeEjecution = MergeSort(listForTimeEjecution);
        end = System.currentTimeMillis();
        
        duration = end - start;
        algorithmsTimeEjecution.put("Método merge", duration);
        
        //quick
        listForTimeEjecution = GenerateListOfNumbers();
        start = System.currentTimeMillis();
        QuickSort(listForTimeEjecution);
        end = System.currentTimeMillis();
        
        duration = end - start;
        algorithmsTimeEjecution.put("Método quick", duration);
        
        //shell
        listForTimeEjecution = GenerateListOfNumbers();
        
        //Pedir al usuario nivel de incremento
        System.out.println("Nivel de incremento para el ordenamiento Shell ");
        int nIncrement = Integer.parseInt(input.readLine());
        
        start = System.currentTimeMillis();
        listForTimeEjecution = ShellSort(listForTimeEjecution, nIncrement);
        end = System.currentTimeMillis();
        
        duration = end - start;
        algorithmsTimeEjecution.put("Método shell", duration);
        
        
        //Ordenar HashMap de algoritmos por su tardanza de ejecución en milisegundos     
        List<Map.Entry<String, Long>> timeEjecutionAlgorithms = new ArrayList<>(algorithmsTimeEjecution.entrySet());
        Collections.sort(timeEjecutionAlgorithms, Map.Entry.comparingByValue());
        
        //Recorrer y mostrar el orden de los algoritmos por eficiencia (de menos a más milisegundos de tardanza)
        System.out.println("Orden de algoritmos, de menor a mayor tiempo de ejecución");
        for(Map.Entry<String, Long> entry : timeEjecutionAlgorithms) {
            
            System.out.println(entry.getKey() + ": " + " (" + entry.getValue() + " milisegundos)");
            
        }
        
        System.out.println("-----------------------------------------------------------------------------------------------------------------------------------");
        System.out.println("Búsquedas de datos");
        
        //Ejecutar
        boolean ejecute = true;
        
        //Pedirle al usuario que escoga un método de ordenamiento, se ordene la lista creada, y se usen los métodos de búsqueda
        while(ejecute)
        {
            //Generar lista
            ArrayList<Integer> listForSearch = GenerateListOfNumbers();
            
            //Elemento de la lista, y elemento que buscará el usuario
            int element = listForSearch.get((int)Math.random() * listForSearch.size());
            int elementUser = 0;
            
            //Pedir al usuario tipo de ordenamiento
            System.out.println("Seleccione el tipo de ordenamiento que quiera implementar: \n1. Burbuja \n2. Selección \n3. Inserción \n4. Merge \n5. Quick \n6. Shell \n7. Salir ");
            int tipo = Integer.parseInt(input.readLine());
            
            //Si no seleccionó "salir", mostrar elemento de prueba dentro de la lista, y preguntarle al usuario un número que quiera buscar
            if(tipo != 7)
            {
                System.out.println("Elemento de prueba dentro de la lista a buscar: " + element);
                System.out.println("¿Qué elemento desea buscar?");
                elementUser = Integer.parseInt(input.readLine());
            }
            
            
            
            switch(tipo){
                case 1: //Burbuja
                    System.out.println("Ordenando con método burbuja");
                    burbuja(listForSearch);
                    break;
                    
                case 2: //Selección
                    System.out.println("Ordenando con método de selección");
                    selection(listForSearch);
                    break;
                    
                case 3: //Inserción
                    System.out.println("Ordenando con método de inserción");
                    InsertionSort(listForSearch);
                    break;
                    
                case 4: //Merge
                    System.out.println("Ordenando con método merge");
                    listForSearch = MergeSort(listForSearch);
                    break;
                    
                case 5: //Quick
                     System.out.println("Ordenando con método quick");
                    QuickSort(listForSearch);
                    break;
                    
                case 6: //Shell
                    System.out.println("Ordenando con método shell");
                    
                    //Pedir al usuario nivel de incremento para el ordenamiento Shell
                    System.out.println("Nivel de incremento para el ordenamiento Shell ");
                    int n = Integer.parseInt(input.readLine());
                    
                    listForSearch = ShellSort(listForSearch, n);
                    break;
                    
                case 7: //Salir del ciclo
                    ejecute = false;
                    break;
                    
                    
            }
            
            //Si no se escogió 7, mostrar resultados (true o false) con el valor de prueba, y con el introducido por el usuario.
            if(tipo != 7)
            {
                System.out.println("");           
                System.out.println("Para el valor de prueba: ");
                System.out.println("Resultado con búsqueda secuencial: " + busquedaSecuencial(listForSearch, element));
                System.out.println("Resultado con búsqueda binaria: " + busquedaBinaria(listForSearch, element));
                System.out.println("Resultado con búsqueda interpolada: -------");
                System.out.println("");
                System.out.println("Para el valor buscado por el usuario: ");
                System.out.println("Resultado con búsqueda secuencial: " + busquedaSecuencial(listForSearch, elementUser));
                System.out.println("Resultado con búsqueda binaria: " + busquedaBinaria(listForSearch, elementUser));
                System.out.println("Resultado con búsqueda interpolada: -------");
                System.out.println("");
            }
            

        }
            
        
            
            //Generar otra lista nueva
            ArrayList<Integer> listForTimeEjecutionSearch;
            
            System.out.println("");
            System.out.println("Nivel de eficiencia de algoritmos de ordenamiento, con búsqueda binaria");
            
            //Compararemos el nivel de eficacia de los algoritmos en milisegundos, pero ahora usando la búsqueda binaria.
            //Los resultados se guardarán en un HashMap
            //Burbuja
            listForTimeEjecutionSearch = GenerateListOfNumbers();
                      
            int anotherElement = listForTimeEjecutionSearch.get((int)Math.random() * listForTimeEjecutionSearch.size());
            System.out.println("Elemento a buscar: " + anotherElement);
            
            long startS = System.currentTimeMillis();
            burbuja(listForTimeEjecutionSearch);
            System.out.println("Resultado: " + busquedaBinaria(listForTimeEjecutionSearch, anotherElement));

            long endS = System.currentTimeMillis();

            long durationS = endS - startS;
            
            algorithmsTimeEjecutionBinarySearch.put("Método burbuja", durationS);
            
            //selección
            listForTimeEjecutionSearch = GenerateListOfNumbers();
            
            anotherElement = listForTimeEjecutionSearch.get((int)Math.random() * listForTimeEjecutionSearch.size());
            System.out.println("Elemento a buscar: " + anotherElement);
            
            startS = System.currentTimeMillis();
            selection(listForTimeEjecutionSearch);
            System.out.println("Resultado: " + busquedaBinaria(listForTimeEjecutionSearch, anotherElement));
            endS = System.currentTimeMillis();

            durationS = endS - startS;
            algorithmsTimeEjecutionBinarySearch.put("Método selección", durationS);

            //inserción
            listForTimeEjecutionSearch = GenerateListOfNumbers();
            
            anotherElement = listForTimeEjecutionSearch.get((int)Math.random() * listForTimeEjecutionSearch.size());
            System.out.println("Elemento a buscar: " + anotherElement);
            
            startS = System.currentTimeMillis();
            InsertionSort(listForTimeEjecutionSearch);
            System.out.println("Resultado: " + busquedaBinaria(listForTimeEjecutionSearch, anotherElement));
            endS = System.currentTimeMillis();

            durationS = endS - startS;
            algorithmsTimeEjecutionBinarySearch.put("Método inserción", durationS);

            //merge
            listForTimeEjecutionSearch = GenerateListOfNumbers();
            
            anotherElement = listForTimeEjecutionSearch.get((int)Math.random() * listForTimeEjecutionSearch.size());
            System.out.println("Elemento a buscar: " + anotherElement);
            
            startS = System.currentTimeMillis();
            listForTimeEjecutionSearch = MergeSort(listForTimeEjecutionSearch);
            System.out.println("Resultado: " + busquedaBinaria(listForTimeEjecutionSearch, anotherElement));
            endS = System.currentTimeMillis();

            durationS = endS - startS;
            algorithmsTimeEjecutionBinarySearch.put("Método Merge", durationS);


            //quick
            listForTimeEjecutionSearch = GenerateListOfNumbers();
            
            anotherElement = listForTimeEjecutionSearch.get((int)Math.random() * listForTimeEjecutionSearch.size());
            System.out.println("Elemento a buscar: " + anotherElement);
            
            startS = System.currentTimeMillis();
            QuickSort(listForTimeEjecutionSearch);
            System.out.println("Resultado: " + busquedaBinaria(listForTimeEjecutionSearch, anotherElement));
            endS = System.currentTimeMillis();

            durationS = endS - startS;
            algorithmsTimeEjecutionBinarySearch.put("Método Quick", durationS);


            //shell
            listForTimeEjecutionSearch = GenerateListOfNumbers();
            
            anotherElement = listForTimeEjecutionSearch.get((int)Math.random() * listForTimeEjecutionSearch.size());
            
            //Pedir al usuario nivel de incremento
            System.out.println("Nivel de incremento para el ordenamiento Shell ");
            int nIncrementShell = Integer.parseInt(input.readLine());
            
            System.out.println("Elemento a buscar: " + anotherElement);
                        
            startS = System.currentTimeMillis();
            listForTimeEjecutionSearch = ShellSort(listForTimeEjecutionSearch, nIncrementShell);
            System.out.println("Resultado: " + busquedaBinaria(listForTimeEjecutionSearch, anotherElement));
            endS = System.currentTimeMillis();
            
            durationS = endS - startS;
            algorithmsTimeEjecutionBinarySearch.put("Método Shell", durationS);
            
            //Ordenar HashMap de menor a mayor cantidad de milisegundos para ver la eficiencia de los algoritmos de ordenamiento agregando búsqueda binaria
            List<Map.Entry<String, Long>> timeEjecutionBinarySearchList = new ArrayList<>(algorithmsTimeEjecutionBinarySearch.entrySet());
            Collections.sort(timeEjecutionBinarySearchList, Map.Entry.comparingByValue());
        
            //Recorrer mostrar el orden de los algoritmos por eficiencia, es decir, de menor a mayor cantidad de milisegundos 
            System.out.println("Orden de algoritmos, del más eficiente al menos eficiente (usándolos con el algoritmo de búsqueda binaria)");
            for(Map.Entry<String, Long> entry : timeEjecutionBinarySearchList) {
            
                System.out.println(entry.getKey() + ": " + " (" + entry.getValue() + " milisegundos)");
            
            }
        
        
            
    }
    
    //Método búsqueda secuencial (datos ordenados)
    public static boolean busquedaSecuencial(ArrayList<Integer> data, int number){
        
        //Recorrer lista
        for (int i = 0; i < data.size() ; i++)
            
            //Si el valor que se encuentra en el índice es mayor que el número esperado, quiere decir que no está el número que se está buscando
            if (data.get(i) > number)
                return false;
            
            //Si el valor que se encuentra en el índice, es igual al número buscado, se habrá encontrado
            else if (data.get(i) == number)
                return true;
        
        //Si se recorre toda la lista y no se encontró el número, retornamos falso
        return false;
        
    }
    
    //Método para búsqueda binaria (datos ordenados)
    public static boolean busquedaBinaria(ArrayList<Integer> data, int number){
        
        //Definir variables para el índice del centro, primer índice, último índice, y valor central        
        int center, firstIndex, lastIndex, centerValue;
        
        //Definir valores al primer y úlimo índice
        firstIndex = 0;
        lastIndex = data.size() - 1;
        
        //Mientras el´primer índice sea menor o igual al último índice, se hace lo siguiente
        while(firstIndex <= lastIndex){
            
            //Definir índice central, y obtener su valor central
            center = (firstIndex + lastIndex) / 2;
            centerValue = data.get(center);
            
            //Si el número que se busca es igual al valor central, retornamos true, habremos encontrado el número
            if(number == centerValue){
                return true;
                
                //Si no, si el número que se busca es menor que el valor del centro, el último índice será ahora el índice del centro menos uno
                //Nos vamos a la mitad izquierda para buscar
            }else if(number < centerValue){
                lastIndex = center - 1;  
            }
            else //Si no, el primer índice ahora será ahora el índice del centro mas uno. Nos vamos a la mitad derecha para buscar
            {
                firstIndex = center + 1;
            }
        }
        
        //Retirnar falso si no se encontró nada
        return false;
    }
    
    //Método de búsqueda interpolada (datos ordenados)
    public static boolean findInterPoladaArrayList(ArrayList<Integer> lista, int data){
      
      //Definir índice de inicio y de fin
      int inicio = 0, fin = lista.size()-1;
      
      //Mientras el índice inicio sea menor o igual al índice de fin, y el valor buscado sea mayor o igual al valor en el índice de inicio,
      // y sea menor o igual al valor en el índice final, hacer lo siguiente
      while (inicio <= fin && data >= lista.get(inicio) && data <= lista.get(fin)) {
          
        //Definir posición posible del número a buscar, con la siguiente fórmula
        int pos = inicio + (((data - lista.get(inicio)) * (fin - inicio)) / (lista.get(fin) - lista.get(inicio)));
        
        //Si en la posición de la fórmula está el número que se busca, se habrá encontrado, y retornamos true
        if (lista.get(pos) == data) {
            return true; // Elemento encontrado
            
            } else if (lista.get(pos) < data) { //Si no, si el valor en la posición de la fórmula es menor al número que se busca, hacer lo siguiente
                inicio = pos + 1; // Buscar en la mitad derecha
                
            } else {
                fin = pos - 1; // Buscar en la mitad izquierda
            }
        
        }
      
        return false;
    }
    
    //Método generador de listas
    public static ArrayList<Integer> GenerateListOfNumbers(){
        //Creación de lista
        ArrayList<Integer> listOfNumbers = new ArrayList<>();
        
        //Rango de números aleatorios
        int min = -100000;
        int max = 100000;
        
        //Crear 100,000 números aleatorios y agregarlos a la lista
        for (int i = 0; i < 100000; i++) {
            int randomNumber = (int) (Math.random() * ((max - min) + 1)) + min;
            listOfNumbers.add(i, randomNumber);
        }
        
        return listOfNumbers;
    }
    
    //Método burbuja
    public static void burbuja(ArrayList<Integer> list){
        
        //Tamaño de lista
        int n = list.size();
        //Variable que continuará o terminará el siguiente ciclo
        boolean intercambiando;
        do{
            //Se deja de intercambiar al terminar de ordenar, cuando ya no se pueda iterar más.
            intercambiando = false;
            
            //Recorrer el arreglo hasta el límite establecido
            for (int i = 0; i < n - 1; i++) {
                
                //Si el número actual es mayor que el número siguiente de la lista, hacer intercambio
               if(list.get(i) > list.get(i + 1)){
                   
                   //Intercambio de elemento actual con elemento posterior (se usa variable auxiliar para realizar el cambio adecuadamente)
                    int aux = list.get(i);
                    list.set(i, list.get(i + 1));
                    list.set(i + 1, aux);
                    
                    //Continuar intercambiando
                    intercambiando = true;
               } 
            }
            
            //Recorremos ahora n - 1 elementos en el arreglo
            n = n - 1;
            
        }while(intercambiando);
        
    }
    
    //Método selección
    public static void selection(ArrayList<Integer> list){
        
        //Tamaño de la lista
        int n = list.size();
        
        //Posición del número más pequeño
        int minimo;
        
        //Recorrer arreglo
        for (int i = 0; i < n; i++) {
            
            //Suponemos que la posición inicial i es el mínimo
            minimo = i;
            
            //Buscamos para ver si hay números más pequeños que el mínimo definido
            for (int j = i+1; j < n; j++) {
                
                //Si algún elemento posterior es mayor al elemento mínimo definido
                if(list.get(j) < list.get(minimo )){
                    
                    //Definir nueva posición del mínimo
                    minimo = j;
                }
            }
            //Intercambio del elemento actual por el elemento mínimo (uso de variable auxiliar para apoyarnos con el proceso)
            int aux = list.get(i);
            list.set(i, list.get(minimo));
            list.set(minimo, aux);
        }
    }
    
    //Método MergeSort (primero se divide)    
    private static ArrayList<Integer> MergeSort(ArrayList<Integer> data){
        
        //Caso base: se tiene una lista de un solo elemento, se retorna
        if(data.size() == 1){
            return data;
        }
        
        //Creamos dos listas para guardar las dos mitades de la lista original
        ArrayList<Integer> arreglo1 = new ArrayList<>(), 
                           arreglo2 = new ArrayList<>();
        
        //Agregar valores de la mitad izquierda de la lista original a la primer lista.
        for (int i = 0; i < data.size()/2; i++) {
            arreglo1.add(data.get(i));
        }
        
        //Agregar valores de la mitad derecha de la lista original a la segunda lista.
        for (int i = data.size()/2; i < data.size(); i++) {
            arreglo2.add(data.get(i));
        }
        
        //Recursividad: se guarda el resultado de la union ordenada de las mitades de las listas.
        data = union(MergeSort(arreglo1), MergeSort(arreglo2));
        
        //Se retorna la lista ordenada
        return data;
        
    }
    
    //Método para unir mitades de listas
    public static ArrayList<Integer> union(ArrayList<Integer> a1, ArrayList<Integer> a2){
        
        //Lista resultante
        ArrayList<Integer> result = new ArrayList<>();
        
        //Índices para cada mitad
        int index1 = 0, index2 = 0;
        
        //Mientras ambos índices estén dentro del rango de tamaño de las mitades de listas
        while(index1 < a1.size() && index2 < a2.size())
        {
            //Si el elemento de la primera mitad es mayor que el elemento de la segunda mitad, el elemento de la primera
            //mitad se agrega a la lista resultante, y el índice se incrementa después.
            if(a1.get(index1) < a2.get(index2))
            {
                result.add(a1.get(index1++));
                
            }
            //Si no, el elemento de la segunda mitad se agrega a la lista resultante y luego se incrementa el índice.
            else
            {
                result.add(a2.get(index2++));
                
            }
                       
        }
        //Para ambas mitades, obtener los elementos que hayan faltado y agregarlos a la lista resultante.
        for (int i = index1; i < a1.size(); i++) {
                result.add(a1.get(i));
            }
        for (int i = index2; i < a2.size(); i++) {
                result.add(a2.get(i));
            }
        
        //Retornar lista ordenada
        return result;
    }
    
    //Quicksort método, (se manda la lista, con el índide del primer elemento, y del último.
    public static void QuickSort(ArrayList<Integer> list){
        QuickSort(list, 0, list.size() - 1);
    }
    
    //Método recursivo quicksort
    private static void QuickSort(ArrayList<Integer> list, int firstElementIndex, int lastElementIndex){
        
        //Definimos variables
        int leftIndex, rightIndex, pivot, aux;
        
        //Indice de la mitad izquierda será del primer elemento y el índice de la mitad derecha será del último elemento
        leftIndex = firstElementIndex;
        rightIndex = lastElementIndex;
        
        //Definir pivote, que será el elemento que está a la mitad de la lista y formará las dos mitades
        pivot = list.get((firstElementIndex + lastElementIndex) / 2);
        
        //Lo siguiente se realiza mientras el índice izquierdo sea menor o igual al índice derecho, hasta que se topen
        do
        {
            //Mientras los elementos de la parte izquierda de la lista sean mayores que el pivote, se incrementa el índice izquierdo
            while(list.get(leftIndex) < pivot)
            {
                leftIndex++;
            }
            //Mientras los elementos de la parte derecha de la lista sean menores que el pivote, se incrementa el índice derecho
            while(list.get(rightIndex) > pivot)
            {
                rightIndex--;
            }
            //Al terminar recorrido, si el índice izquierdo es menor o igual que el índice derecho, hacer intercambio y mover ambos índices una posición
            if(leftIndex <= rightIndex)
            {
                aux = list.get(leftIndex);
                list.set(leftIndex, list.get(rightIndex));
                list.set(rightIndex, aux);
                leftIndex++;
                rightIndex--;
            }
        }while(leftIndex <= rightIndex);
        
        //Si el índice del primer elemento es menor que el índice derecho, llamar recursivamente
        //El último elemento ahora será el índice derecho actual
        if(firstElementIndex < rightIndex)
        {
            QuickSort(list, firstElementIndex, rightIndex);
        }
        
        //Si el índice izquierdo es menor que el índice del último elemento, llamar recursivamente
        //El primer elemento ahora será el índice izquierdo actual
        if(leftIndex < lastElementIndex)
        {
            QuickSort(list, leftIndex, lastElementIndex);
        }
        
    }
    
    public static ArrayList<Integer> ShellSort(ArrayList<Integer> data, int n){
        ArrayList<Integer> result = data;
        if(n == 1)
        {
            result = MergeSort(data);
        }
        else
        {
            for (int i = 0; i < n; i++) 
            {
                ArrayList<Integer> aux = new ArrayList<>();
                for (int j = i; j < data.size(); j+=n) 
                {
                    aux.add(result.get(j));
                }
                aux = MergeSort(aux);
                
                for (int j = i, idx = 0; j < data.size(); j+=n, idx++) 
                {
                    result.set(j, aux.get(idx));
                }
            }
            result = ShellSort(result, n - 1);
        }
        
        return result;
    }
    
    //Método de inserción
    public static void InsertionSort(ArrayList<Integer> list){
        
        //Definir auxiliar e índice iterador para ir moviendo y posicionando los elementos 
        int pos, aux;
        
        //Recorrer lista
        for (int i = 0; i < list.size(); i++) {
            
            //El índice iterador pos será i, y el auxiliar será el valor en i
            pos = i;
            aux = list.get(i);
            
            //Mientras el índice pos sea mayor a cero, y el elemento a pos - 1 (izquierda) sea menor que el auxiliar
            while((pos > 0) && (list.get(pos - 1) > aux)){
                
                //cambiar en pos por el elemento que estaba a la izquierda, y nos movemos a una posición a la izquierda
                list.set(pos, list.get(pos - 1));
                pos--;
            }
            //Agregar en pos recorrido el auxiliar
            list.set(pos, aux);
        }
        
        
    }
    
}
