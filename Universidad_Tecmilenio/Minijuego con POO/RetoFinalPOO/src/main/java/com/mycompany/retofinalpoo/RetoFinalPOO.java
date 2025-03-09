/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.retofinalpoo;

import java.io.*;
import java.util.ArrayList;

/**
 *
 * @author reyna
 */
public class RetoFinalPOO {
public static BufferedReader entrada = new BufferedReader(new InputStreamReader(System.in));
    public static void main(String[] args) throws IOException {
        
        //Bienvenidos
        //Lore del juego
        System.out.println("¡Bienvenido al universo fantástico de Alpha Centauri!");
        System.out.println("Un pueblo llamado Alpha Centauri es constantemente atacado por otros seres, y los aldeanos estan cansados de esto,");
        System.out.println("y lo único que quieren es estar en paz, además se rumorea que las criaturas planean unirse para hacer un superataque");
        System.out.println("que puede destruir el pueblo. La unica forma de salvarlo es encontrando un tesoro, que contiene una esfera mágica que");
        System.out.println("invoca a unos seres protectores de mundos. Pero está escondido, y solo tú puedes salvar al pueblo. Creemos en ti :)");
        System.out.println("");
        
        //Pedir al usuario dificultad del juego (facil, intermedio, dificil), y hacerlo mientras de un número fuera de rango
        int dificultad = 0;
        
        do
        {
            System.out.println("Elige el nivel de dificultad que quieres jugar:\n1. Facil\n2. Intermedio\n3. Avanzado");
            dificultad = Integer.parseInt(entrada.readLine());
            
            if(dificultad < 1 || dificultad > 3)
            {
                System.out.println("No se admite este nivel, intenta otra vez");
            }
            
        }while(dificultad < 1 || dificultad > 3);
        
        //Pedir al usuario el número de jugadores (1 a 3 jugadores), y hacerlo mientras de un número fuera de rango
        int numeroJugadores = 0;
        
        do
        {
            System.out.println("Elige el numero de jugadores (minimo 1, máximo 3)");
            numeroJugadores = Integer.parseInt(entrada.readLine());
        
            if(numeroJugadores < 1 || numeroJugadores > 3)
            {
                System.out.println("No se admiten esta cantidad de jugadores, intentalo de nuevo.");
            }
        }
        while(numeroJugadores < 1 || numeroJugadores > 3);
        
        //Lista de nombres de jugadores
        ArrayList<String> ListaJugadores = new ArrayList<String>();
        
        //Pedir al usuario nombres de los jugadores y guardarlos en la lista creada
        String nombreJugador = "";
        for(int i = 0; i < numeroJugadores; i++)
        {
            System.out.println("Inserta el nombre del jugador " + (i+1));
            nombreJugador = entrada.readLine();
            ListaJugadores.add(i, nombreJugador);
        }
        
        //Crear un nuevo juego con sus parámetros
        Juego miJuego = new Juego(dificultad, ListaJugadores);
        
        //Jugar el juego
        miJuego.jugar();
        
        //El juego ha terminado
        System.out.println("El juego ha terminado");
    }
}
