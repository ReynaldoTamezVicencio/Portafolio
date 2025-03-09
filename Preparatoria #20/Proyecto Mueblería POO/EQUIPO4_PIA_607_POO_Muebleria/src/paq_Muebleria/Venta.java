package paq_Muebleria;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class Venta {
	
	//Atributos
	protected String Fecha;
	protected Mueble Mueble;
	protected Accesorio Accesorio;
	
	//Métodos constructores
	public Venta() {
		
	}
	
	public Venta (String Fecha, Mueble Mueble, Accesorio Accesorio) {
		this.Fecha = Fecha;
		this.Mueble = Mueble;
		this.Accesorio = Accesorio;
	}
	
	public Venta (String Fecha, Mueble Mueble) {
		this.Fecha = Fecha;
		this.Mueble = Mueble;
		
	}
	
	public Venta (String Fecha, Accesorio Accesorio) {
		this.Fecha = Fecha;
		this.Accesorio = Accesorio;
	}
	
	//Método propio
	protected double calcularTotalVenta() {
		double TotalPagar = 0;
		
		if(this.Mueble!=null) {
			System.out.println("El mueble ordenado fue " + this.Mueble.Nombre + " y cuesta " + this.Mueble.Precio);
			TotalPagar = TotalPagar + this.Mueble.Precio;
		}
		
		if(this.Accesorio!=null) {
			System.out.println("El accesorio ordenado fue " + this.Accesorio.Nombre + " y cuesta " + this.Accesorio.Precio);
			TotalPagar = TotalPagar + this.Accesorio.Precio;
		}
		
		return TotalPagar;
	}
	
	protected void escribirCSV() {
		try {
			BufferedWriter bw = new BufferedWriter(new FileWriter("C:\\Users\\reyna\\OneDrive\\Escritorio\\MATERIAS\\MATERIAS\\Programación Orientada a Objetos\\Workspace\\ProgramasJava\\CSV_PIA\\Ventas.csv"));
			
			//Preparar la linea
			DateTimeFormatter dtf = DateTimeFormatter.ofPattern("yyyy/MM/dd");
			String Linea = dtf.format(LocalDateTime.now());

			if(this.Mueble!=null) {
				Linea = Linea + "," + this.Mueble.Nombre;
			}
			
			if(this.Accesorio!=null) {
				Linea = Linea + "," + this.Accesorio.Nombre;
			}
			
			double Cuenta = this.calcularTotalVenta();
			
			Linea = Linea + "," + Double.toString(Cuenta);
			
			bw.append(Linea);
			bw.flush();
			bw.close();
		}
		catch(IOException er) {
			er.printStackTrace();
		}
	}
	
	//Métodos Get y Set
	protected String getFecha() {
		return this.Fecha;
	}
	protected void setFecha(String Fecha) {
		this.Fecha = Fecha;
	}
	
	protected Mueble getMuebles() {
		return this.Mueble;
	}
	protected void setMuebles(Mueble Mueble) {
		this.Mueble = Mueble;
	}
	
	protected Accesorio getAccesorio() {
		return this.Accesorio;
	}
	protected void setAccesorio(Accesorio Accesorio) {
		this.Accesorio = Accesorio;
	}	

}
