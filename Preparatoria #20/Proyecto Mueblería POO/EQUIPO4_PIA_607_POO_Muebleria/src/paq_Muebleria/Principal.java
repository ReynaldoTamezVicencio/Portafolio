package paq_Muebleria;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;

public class Principal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		DateTimeFormatter dtf = DateTimeFormatter.ofPattern("yyyy/MM/dd");
		String FechaActual = dtf.format(LocalDateTime.now());
		
		Mueble M1 = new Mueble("1", "Closet", "Negro", "Grande", "Madera", 10000, 800, "Alta durabilidad");
		
		Venta V1 = new Venta(FechaActual, M1);
		V1.escribirCSV();

	}

}
