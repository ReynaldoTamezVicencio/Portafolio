package paq_Muebleria;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

public class Accesorio extends Producto implements InterProducto {
	
	//Atributos
	protected String Tipo;

	public Accesorio() {
		// TODO Auto-generated constructor stub
	}

	public Accesorio(String IdProducto, String Nombre, String Color, String Tamaño, String Material, double Precio, String Tipo) {
		super(IdProducto, Nombre, Color, Tamaño, Material, Precio);
		// TODO Auto-generated constructor stub
		this.Tipo = Tipo;
	}
	
	//Método con polimorfismo
	public void verProducto() {
		System.out.println("Id Producto: " + this.IdProducto);
		System.out.println("Nombre: " + this.Nombre);
		System.out.println("Color: " + this.Color);
		System.out.println("Tamaño: " + this.Tamaño);
		System.out.println("Material: " + this.Material);
		System.out.println("Precio: " + this.Precio);
		System.out.println("Tipo: " + this.Tipo);
	}
	
	//Método para leer accesorio de CSV
	public static ArrayList<Accesorio> leerCSV (ArrayList<Accesorio> Lista){
		try {
			//Reserva de bufer y archivo que se va a leer
			BufferedReader br = new BufferedReader(new FileReader("C:\\Users\\reyna\\OneDrive\\Escritorio\\MATERIAS\\MATERIAS\\Programación Orientada a Objetos\\Workspace\\ProgramasJava\\CSV_PIA\\Accesorios.csv"));
			
			//Se recorre linea por linea el archivo al que nos conectamos, por cada linea se genera un accesorio
			String linea = "";
			while( (linea = br.readLine() ) != null ) {
				System.out.println(linea);
				
				//Se dividen los datos del accesorio en un arreglo
				String[] DatosAccesorio = linea.split(",");
				
				//Crear un accesorio
				Accesorio Acc = new Accesorio(DatosAccesorio[0], DatosAccesorio[1], DatosAccesorio[2], DatosAccesorio[3], DatosAccesorio[4], Double.valueOf(DatosAccesorio[5]), DatosAccesorio[6]);
				Lista.add(Acc);
				
			}
		}
		catch (IOException ee) {
			ee.printStackTrace();
		}
		return Lista;
	}
	
	//Métodos Get y Set

		protected String getTipo() {
			return this.Tipo;
		}
		protected void setTipo(String Tipo) {
			this.Tipo = Tipo;
		}

}
