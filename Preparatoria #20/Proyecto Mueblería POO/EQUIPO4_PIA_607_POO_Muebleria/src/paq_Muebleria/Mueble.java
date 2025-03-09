package paq_Muebleria;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

public class Mueble extends Producto implements InterProducto {
	
	//Atributos
	protected double Peso;
	protected String Durabilidad;

	public Mueble() {
		// TODO Auto-generated constructor stub
	}

	public Mueble(String IdProducto, String Nombre, String Color, String Tamaño, String Material, double Precio, double Peso, String Durabilidad) {
		super(IdProducto, Nombre, Color, Tamaño, Material, Precio);
		// TODO Auto-generated constructor stub
		this.Peso = Peso;
		this.Durabilidad = Durabilidad;
	}
	
	//Método con polimorfismo
	public void verProducto() {
		System.out.println("Id Producto: " + this.IdProducto);
		System.out.println("Nombre: " + this.Nombre);
		System.out.println("Color: " + this.Color);
		System.out.println("Tamaño: " + this.Tamaño);
		System.out.println("Material: " + this.Material);
		System.out.println("Precio: " + this.Precio);
		System.out.println("Peso: " + this.Peso);
		System.out.println("Durabilidad: " + this.Durabilidad);
	
	}
	
	//Método para leer muebles de CSV
	public static ArrayList<Mueble> leerCSV (ArrayList<Mueble> Lista){
		try {
			//Archivo a leer
			BufferedReader br = new BufferedReader(new FileReader("C:\\Users\\reyna\\OneDrive\\Escritorio\\MATERIAS\\MATERIAS\\Programación Orientada a Objetos\\Workspace\\ProgramasJava\\CSV_PIA\\Muebles.csv"));
			
				//Recorrer linea por linea el archivo y por cada linea se genera un mueble
				String linea = "";
				while((linea = br.readLine()) != null) {
					System.out.println(linea);
				//Dividir los datos del mueble en un arreglo
					String[] DatosMueble = linea.split(",");
				
				//Crear un mueble
				Mueble Mue = new Mueble(DatosMueble[0], DatosMueble[1], DatosMueble[2], DatosMueble[3], DatosMueble[4], Double.valueOf(DatosMueble[5]), Double.valueOf(DatosMueble[6]), DatosMueble[7]);
				Lista.add(Mue);
			}
		}
		catch(IOException ee) {
			ee.printStackTrace();
		}
		return Lista;
	}
	
	//Métodos get/set
	protected double getPeso() {
		return this.Peso;
	}
	protected void setPeso(double Peso) {
		this.Peso = Peso;
	}
	
	protected String getDurabilidad() {
		return this.Durabilidad;
	}
	protected void setDurabilidad(String Durabilidad) {
		this.Durabilidad = Durabilidad;
	}

}
