package paq_Muebleria;

public class Producto {
	
	//Atributos
	protected String IdProducto;
	protected String Nombre;
	protected String Color;
	protected String Tamaño;
	protected String Material;
	protected double Precio;
	
	//Métodos constructores
	public Producto() {

	}
	
	public Producto(String IdProducto, String Nombre, String Color, String Tamaño, String Material, double Precio) {
		this.IdProducto = IdProducto;
		this.Nombre = Nombre;
		this.Color = Color;
		this.Tamaño = Tamaño;
		this.Material = Material;
		this.Precio = Precio;
	}
	
	//Método propio para polimorfismo en clases hijas
	public void verProducto() {
		System.out.println("Id Producto: " + this.IdProducto);
		System.out.println("Nombre: " + this.Nombre);
		System.out.println("Color: " + this.Color);
		System.out.println("Tamaño: " + this.Tamaño);
		System.out.println("Material: " + this.Material);
		System.out.println("Precio: " + this.Precio);
	
	}
	
	//Métodos Get y Set
	protected String getIdProducto() {
		return this.IdProducto;
	}
	protected void setIdProducto(String IdProducto) {
		this.IdProducto = IdProducto;
	}
	
	protected String getNombre() {
		return this.Nombre;
	}
	protected void setNombre(String Nombre) {
		this.Nombre = Nombre;
	}
	
	protected String getColor() {
		return this.Color;
	}
	protected void setColor(String Color) {
		this.Color = Color;
	}
	
	protected String getTamaño() {
		return this.Tamaño;
	}
	protected void setTamaño(String Tamaño) {
		this.Tamaño = Tamaño;
	}
	
	protected String getMaterial() {
		return this.Material;
	}
	protected void setMaterial(String Material) {
		this.Material = Material;
	}
	
	protected double getPrecio() {
		return this.Precio;
	}
	protected void setPrecio(double Precio) {
		this.Precio = Precio;
	}
}