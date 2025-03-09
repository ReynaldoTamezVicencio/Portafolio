package paq_Muebleria;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JComboBox;
import javax.swing.JTextField;
import java.io.BufferedWriter;
import javax.swing.JOptionPane;
import java.io.FileWriter;
import java.io.IOException;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import javax.swing.JButton;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class PantallaMuebleria {

	private JFrame frmRealizaVenta;
	private JTextField txtTotalPagar;
	
	//Opciones que tendrán los combos
	protected ArrayList<Mueble> ListaMuebles = new ArrayList<Mueble>();
	
	protected ArrayList<Accesorio> ListaAccesorios = new ArrayList<Accesorio>();
	
	//Objetos auxiliares vacios que van a tomar valor cuando se seleccione una opción en el combo
	protected Mueble Mseleccionado = new Mueble();
	protected Accesorio Aseleccionado = new Accesorio();
	
	//Auxiliares para PrecioTotal Mueble y Accesorio
	protected double PrecioMueble = 0.0;
	protected double PrecioAccesorio = 0.0;
	protected double PrecioTotal = 0.0;
	
	protected String FechaHoy = "";

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PantallaMuebleria window = new PantallaMuebleria();
					window.frmRealizaVenta.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public PantallaMuebleria() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		
		//Llenar listas de Muebles y accesorios invocando el método static de lectura de csv's
		Mueble.leerCSV(ListaMuebles);
		Accesorio.leerCSV(ListaAccesorios);
		
		DateTimeFormatter dtf = DateTimeFormatter.ofPattern("yyyy/MM/dd");
		FechaHoy = dtf.format(LocalDateTime.now());
		
		frmRealizaVenta = new JFrame();
		frmRealizaVenta.setTitle("Venta");
		frmRealizaVenta.setBounds(100, 100, 313, 300);
		frmRealizaVenta.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmRealizaVenta.getContentPane().setLayout(null);
		
		txtTotalPagar = new JTextField();
		txtTotalPagar.setBounds(92, 150, 185, 20);
		frmRealizaVenta.getContentPane().add(txtTotalPagar);
		txtTotalPagar.setColumns(10);
		
		JLabel lblNewLabel = new JLabel("Muebleria EQUIPO 4");
		lblNewLabel.setBounds(90, 11, 128, 14);
		frmRealizaVenta.getContentPane().add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("Muebles");
		lblNewLabel_1.setBounds(20, 60, 84, 14);
		frmRealizaVenta.getContentPane().add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Accesorios");
		lblNewLabel_2.setBounds(20, 98, 97, 14);
		frmRealizaVenta.getContentPane().add(lblNewLabel_2);
		
		JComboBox cboMuebles = new JComboBox();
		cboMuebles.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if (cboMuebles.getSelectedIndex()>0) {
				int IndMueSelecc = Math.max(cboMuebles.getSelectedIndex() - 1, 0);
				Mseleccionado = ListaMuebles.get(IndMueSelecc);
				
				PrecioMueble = Mseleccionado.Precio;
				PrecioTotal = PrecioMueble + PrecioAccesorio;
				System.out.println("Total a pagar: " + PrecioTotal);
				txtTotalPagar.setText(String.format("%.2f", PrecioTotal));
				}
				}
		});
		
		cboMuebles.addItem("Selecciona un mueble");
		for(Mueble MueAux: ListaMuebles) {
			cboMuebles.addItem(MueAux.Nombre);
		}
		
		cboMuebles.setBounds(90, 56, 185, 22);
		frmRealizaVenta.getContentPane().add(cboMuebles);
		
		JComboBox cboAccesorios = new JComboBox();
		cboAccesorios.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(cboAccesorios.getSelectedIndex()>0) {
				int IndAccSelecc = Math.max(cboAccesorios.getSelectedIndex() - 1, 0);
				Aseleccionado = ListaAccesorios.get(IndAccSelecc);
				
				PrecioAccesorio = Aseleccionado.Precio;
				PrecioTotal = PrecioMueble + PrecioAccesorio;
				System.out.println("Total a pagar: " + PrecioTotal);
				txtTotalPagar.setText(String.format("%.2f", PrecioTotal));
				}
				}
		});
		
		cboAccesorios.addItem("Selecciona un accesorio");
		for(Accesorio AccAux: ListaAccesorios) {
			cboAccesorios.addItem(AccAux.Nombre);
		}
		
		cboAccesorios.setBounds(90, 94, 185, 22);
		frmRealizaVenta.getContentPane().add(cboAccesorios);
		
		JLabel lblNewLabel_3 = new JLabel("Total a pagar");
		lblNewLabel_3.setBounds(10, 153, 97, 14);
		frmRealizaVenta.getContentPane().add(lblNewLabel_3);
		
		
		
		JLabel lblNewLabel_4 = new JLabel("Equipo 4 --- 607 --- PIA --- POO");
		lblNewLabel_4.setBounds(10, 221, 265, 14);
		frmRealizaVenta.getContentPane().add(lblNewLabel_4);
		
		JButton btnCalcularTotal = new JButton("Calcular total");
		btnCalcularTotal.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				//Validar que esté capturada la información completa para crear una venta
				if(Mseleccionado.Nombre==null) {
					JOptionPane.showMessageDialog(null, "Debe seleccionar un mueble");
				}else {
					if(Aseleccionado.Nombre==null) {
						JOptionPane.showMessageDialog(null, "Debe seleccionar un accesorio");
					}else {
						if (Mseleccionado==null && Aseleccionado!=null) {
							Venta V1 = new Venta(FechaHoy, Aseleccionado);
							V1.calcularTotalVenta();
							V1.escribirCSV();
						}
						
						if (Mseleccionado!=null && Aseleccionado==null) {
							Venta V1 = new Venta(FechaHoy, Mseleccionado);
							V1.calcularTotalVenta();
							V1.escribirCSV();
						}
						
						if (Mseleccionado!=null && Aseleccionado!=null) {
							Venta V1 = new Venta(FechaHoy, Mseleccionado, Aseleccionado);
							V1.calcularTotalVenta();
							V1.escribirCSV();
						}
						
						JOptionPane.showMessageDialog(null, "La venta fue realizada. El detalle saldrá en consola");
					}
				}
			}
		});
		btnCalcularTotal.setBounds(129, 187, 115, 23);
		frmRealizaVenta.getContentPane().add(btnCalcularTotal);
	}
}
