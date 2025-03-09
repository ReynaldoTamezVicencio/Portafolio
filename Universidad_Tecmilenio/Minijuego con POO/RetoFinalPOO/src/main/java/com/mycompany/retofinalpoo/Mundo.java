/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.retofinalpoo;

import java.util.ArrayList;
import java.lang.Math;


/**
 *
 * @author reyna
 */
public class Mundo {
    
    // Atributos
    public int NumeroDeMundo;
    private int ContenidoDelMundo;
    private ArrayList<Integer> Caminos;
    
    // Constructor
    public Mundo(int NumeroDeMundo, int ContenidoDelMundo) {
        this.NumeroDeMundo = NumeroDeMundo;
        this.ContenidoDelMundo = ContenidoDelMundo;
        this.Caminos = new ArrayList<Integer>();
    }
    
    //Constructor default
    public Mundo()
    {
        this.NumeroDeMundo = 0;
        this.ContenidoDelMundo = 0;
    }
    
    //Método para obtener el número del mundo
    public int getNumeroDeMundo() {
        return this.NumeroDeMundo;
    }
    
    //Método para obtener el contenido del mundo
    public int getContenidoDelMundo() {
        return this.ContenidoDelMundo;
    }
    
    //Método para agregar caminos en el mundo
    public void agregarCaminos(int i, int camino)
    {
        this.Caminos.add(i, camino);
    }
    
    //Método para obtener la lista de caminos del mundo
    public ArrayList<Integer> getCaminos() {
        return Caminos;
    }
   
    //Método para ver que hay en el mundo (nada, tesoro, brujas, pantanos o ataques mágicos)
    public int QueHayEnElMundo(ArrayList<Mundo> ListaDeMundos ,Jugador jugadorActual){
        
        //Si el jugador no ha sido atacado, ejecutar efecto
        //Si no hay nada
        if(this.ContenidoDelMundo == 0 && !jugadorActual.isFueAtacado())
        {
            System.out.println("No hay brujas.");
            System.out.println("Estas en tierra firme.");
            System.out.println("Los seres de este mundo son pacíficos.");
            System.out.println("Estas de suerte, no has encontrado nada malo.");
            
            
        }
        
        //Si hay un tesoro
        else if(this.ContenidoDelMundo == 1 && !jugadorActual.isFueAtacado())
        {
            System.out.println("No hay brujas.");
            System.out.println("Estas en tierra firme.");
            System.out.println("Los seres de este mundo son pacíficos.");
            System.out.println("¡Felicidades, encontraste el tesoro!");
            
        }
        
        //Si el jugador no ha sido atacado anteriormente, y no tiene evasores de ataque, ejecutar efecto. Se establece que fue atacado ahora
        //Si hay un pantano, perder toda la energía
        else if(this.ContenidoDelMundo == 2 && jugadorActual.getCantidadEvasoresAtaque() == 0 && !jugadorActual.isFueAtacado())
        {
            jugadorActual.setFueAtacado(true);
            System.out.println("No hay brujas.");
            System.out.println("Estas en un pantano");
            System.out.println("Los seres de este mundo son pacíficos.");
            System.out.println("¡Aguas! has caido en un pantano, perdiste toda tu energía");
            jugadorActual.PerderEnergiaMagica(jugadorActual.getEnergiaMagica());
        }
        
        //Si hay una bruja, teletransportar al jugador aleatoriamente a un mundo
        else if(this.ContenidoDelMundo == 3 && jugadorActual.getCantidadEvasoresAtaque() == 0 && !jugadorActual.isFueAtacado())
        {
            //Llevar a otros mundo al jugador mientras en el siguiente haya otra bruja, y al finalizar, recibir ejectos del mundo destino            
            do
            {
                jugadorActual.setFueAtacado(true);
                System.out.println("Hay una bruja");
                System.out.println("Estas en tierra firme.");
                System.out.println("Los seres de este mundo son pacíficos.");
                System.out.println("¡Te ha atacado una bruja!");
                int indice = (int)(Math.random()*ListaDeMundos.size());
                jugadorActual.setMundoActual(ListaDeMundos.get(indice));
                System.out.println("Te fuiste al mundo " + jugadorActual.getMundoActual().getNumeroDeMundo());
                System.out.println("------------------------------------------------------------------------");
                
            }
            while(jugadorActual.getMundoActual().getContenidoDelMundo() == 3);
            
            //Si no hay nada
            if(jugadorActual.getMundoActual().getContenidoDelMundo() == 0)
            {
                System.out.println("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                System.out.println("No hay brujas.");
                System.out.println("Estas en tierra firme.");
                System.out.println("Los seres de este mundo son pacíficos.");
                System.out.println("Estas de suerte, no has encontrado nada malo.");
                System.out.println("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            
            }
        
            //Si hay un tesoro
            else if(jugadorActual.getMundoActual().getContenidoDelMundo() == 1)
            {
                System.out.println("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                System.out.println("No hay brujas.");
                System.out.println("Estas en tierra firme.");
                System.out.println("Los seres de este mundo son pacíficos.");
                System.out.println("¡Felicidades, encontraste el tesoro!");
                System.out.println("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }
        
            //Si hay un pantano
            else if(jugadorActual.getMundoActual().getContenidoDelMundo() == 2)
            {
                System.out.println("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                System.out.println("No hay brujas.");
                System.out.println("Estas en un pantano");
                System.out.println("Los seres de este mundo son pacíficos.");
                System.out.println("¡Aguas! has caido en un pantano, perdiste tu energía");
                jugadorActual.PerderEnergiaMagica(jugadorActual.getEnergiaMagica());
                System.out.println("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }
            
            //Si hay un ataque mágico
            else if(jugadorActual.getMundoActual().getContenidoDelMundo() == 4)
            {
                System.out.println("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                System.out.println("No hay brujas.");
                System.out.println("Estas en tierra firme");
                System.out.println("Los seres de este mundo son agresivos.");
                System.out.println("¡Te han atacado! Has recibido un ataque mágico.");
                int cantidadAtaque = (int)(Math.random() * 3) + 3;
                jugadorActual.PerderEnergiaMagica(cantidadAtaque);
                System.out.println("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            }
            
        }
        
        //Si hay un ataque mágico, perder entre 3 y 5 puntos de energía
        else if(this.ContenidoDelMundo == 4 && jugadorActual.getCantidadEvasoresAtaque() == 0 && !jugadorActual.isFueAtacado())
        {
            jugadorActual.setFueAtacado(true);
            System.out.println("No hay brujas.");
            System.out.println("Estas en tierra firme");
            System.out.println("Los seres de este mundo son agresivos.");
            System.out.println("¡Te han atacado! Has recibido un ataque mágico.");
            int cantidadAtaque = (int)(Math.random() * 3) + 3;
            jugadorActual.PerderEnergiaMagica(cantidadAtaque);
        }
        
        
        else
        {
            //Se cambia a false el atributo cuando el jugador vuelva a tener la oportunidad de jugar e ir a otros mundos, no tendrá efectos del mundo actual
            jugadorActual.setFueAtacado(false);
            
        }
        
        //Establecer energía mágica a 0 en caso de que sea negativa
        if(jugadorActual.getEnergiaMagica() < 0)
        {
            jugadorActual.setEnergiaMagica(0);
        }
        
        //Retornar contenido del mundo, representado con un número entero
        return this.ContenidoDelMundo;
    }
    
}
