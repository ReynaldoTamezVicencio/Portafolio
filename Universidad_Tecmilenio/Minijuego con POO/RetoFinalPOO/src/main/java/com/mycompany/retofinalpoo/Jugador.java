/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.retofinalpoo;
import java.util.ArrayList;

/**
 *
 * @author reyna
 */
public class Jugador {
    
    //Atributos
    public String Nombre;
    private int EnergiaMagica;
    private Mundo mundoActual;
    private int CantidadRevitalizadores;
    private int CantidadHechizos;
    private int EnergiaMagicaOriginal;
    private int CantidadEvasoresAtaque;
    private boolean fueAtacado;
    private boolean tieneTurno;
    
    
    //Construcor
    public Jugador(String Nombre, int EnergiaMagica, Mundo mundoActual, int CantidadRevitalizadores, int CantidadHechizos, int CantidadEvasoresAtaque) {
        this.Nombre = Nombre;
        this.EnergiaMagica = EnergiaMagica;
        this.mundoActual = mundoActual;
        this.CantidadRevitalizadores = CantidadRevitalizadores;
        this.CantidadHechizos = CantidadHechizos;
        this.EnergiaMagicaOriginal = this.EnergiaMagica;
        this.CantidadEvasoresAtaque = CantidadEvasoresAtaque;
        this.fueAtacado = false;
        this.tieneTurno = true;
        
    }
    
    //Constructor default
    public Jugador() {
        this.Nombre = "";
        this.EnergiaMagica = 0;
        this.mundoActual = new Mundo();
        this.CantidadRevitalizadores = 0;
        this.CantidadHechizos = 0;
        this.EnergiaMagicaOriginal = 0;
        this.CantidadEvasoresAtaque = 0;
        this.fueAtacado = false;
        this.tieneTurno = false;
    }
       
    
    //Métodos
    
    //Cambiar de posicion del jugador (de mundo)
    public void CambiarDePosicion(Mundo mundoDestino)
    {
        this.EnergiaMagica = this.EnergiaMagica - 1;  
        this.mundoActual = mundoDestino;
    }
    
    //Perder energía mágica 
    public void PerderEnergiaMagica(int cantidadAPerder)
    {
        System.out.println("Perdiste: " + cantidadAPerder + " puntos");
        this.EnergiaMagica = this.EnergiaMagica - cantidadAPerder;
    }
    
    //Usar un revitalizador
    public void UsarRevitalizador()
    {
        System.out.println("Usaste un revitalizador, tu energía mágica ha aumentado");
        this.CantidadRevitalizadores = this.CantidadRevitalizadores - 1;
        this.EnergiaMagica = this.EnergiaMagica + 25;
    }
    
    //Usar un hechizo
    public void UsarHechizo()
    {
        System.out.println("Usaste un hechizo, se te dió otra oportunidad");
        this.CantidadHechizos = this.CantidadHechizos - 1;
        this.EnergiaMagica = this.EnergiaMagicaOriginal;
    }
    
    //Usar evasor de ataque
    public void UsarEvasorDeAtaque()
    {
        System.out.println("Usaste un evasor de ataque, te atacaron y no recibiste ningún daño o efecto");
        this.CantidadEvasoresAtaque = this.CantidadEvasoresAtaque - 1;
        
    }
      
    //Obtener su energía mágica
    public int getEnergiaMagica() {
        return this.EnergiaMagica;
    }
    
    //Obtener su posición, mundo actual

    public Mundo getMundoActual() {
        return mundoActual;
    }
    
    
    //Obtener la cantidad de revitalizadores que tiene
    public int getCantidadRevitalizadores() {
        return this.CantidadRevitalizadores;
    }
    
    //Obtener la cantidad de hechizos que tiene
    public int getCantidadHechizos() {
        return this.CantidadHechizos;
    }
    
    //Obtener cantidad de evasores de ataque que tiene
    public int getCantidadEvasoresAtaque() {
        return CantidadEvasoresAtaque;
    }

    //Asignar otro mundo (para cuando haya un ataque de bruja, o el jugador tenga que usar un hechizo y regresar al mundo inicial)
    public void setMundoActual(Mundo mundoActual) {
        this.mundoActual = mundoActual;
    }
    
    //Determinar si el jugador recibió un ataque, o no
    public void setFueAtacado(boolean fueAtacado)
    {
        this.fueAtacado = fueAtacado;
    }
    
    //Ver si el jugador ya fue atacado anteriormente
    public boolean isFueAtacado() {
        return fueAtacado;
    }
    
    //Establecer energía mágica al jugador
    public void setEnergiaMagica(int EnergiaMagica) {
        this.EnergiaMagica = EnergiaMagica;
    }
    
    //Ver si el jugador tiene el turno habilidato, si puede jugar o ya no por falta de oportunidades
    public boolean isTieneTurno() {
        return tieneTurno;
    }
    
    //Establecer el turno del jugador, ver si ya no puede jugar por no tener oportunidades (hechizos)
    public void setTieneTurno(boolean tieneTurno) {
        this.tieneTurno = tieneTurno;
    }
    
}
