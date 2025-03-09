package paq_Muebleria;

public class Producto {
	
	//Atributos
	protected String IdProducto;
	protected String Nombre;
	protected String Color;
	protected String Tama�o;
	protected String Material;
	protected double Precio;
	
	//M�todos constructores
	public Producto() {

	}
	
	public Producto(String IdProducto, String Nombre, String Color, String Tama�o, String Material, double Precio) {
		this.IdProducto = IdProducto;
		this.Nombre = Nombre;
		this.Color = Color;
		this.Tama�o = Tama�o;
		this.Material = Material;
		this.Precio = Precio;
	}
	
	//M�todo propio para polimorfismo en clases hijas
	public void verProducto() {
		System.out.println("Id Producto: " + this.IdProducto);
		System.out.println("Nombre: " + this.Nombre);
		System.out.println("Color: " + this.Color);
		System.out.println("Tama�o: " + this.Tama�o);
		System.out.println("Material: " + this.Material);
		System.out.println("Precio: " + this.Precio);
	
	}
	
	//M�todos Get y Set
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
	
	protected String getTama�o() {
		return this.Tama�o;
	}
	protected void setTama�o(String Tama�o) {
		this.Tama�o = Tama�o;
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