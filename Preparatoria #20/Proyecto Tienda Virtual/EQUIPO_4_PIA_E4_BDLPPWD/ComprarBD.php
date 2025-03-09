<?php

	// Tomamos los valores actualizados en el formulario
	$usuario = $_POST['usuario'];
	$total_pagar = $_POST['total_pagar'];
	$cant_art = $_POST['cant_art'];
	$direccion = $_POST['direccion'];

	// Abrir conexión con BD tazas
	$con = mysqli_connect("localhost","root","", "bd_muebleria_life_shines");
	
	// Validar conexión con BD
	if (!$con)
	{
		// Si hubo error salir del programa
		die('No se estableció la conexión con el servidor de BD:' . mysqli_connect_error());
	}
	
	// Se elabora el estatuto para insertar el registro
	$estatuto = "INSERT INTO ventas 
					(Usuario, ID_Mueble, Cantidad_Mueble, Total_venta, Fecha_Venta, Direccion_Entrega)
				SELECT Usuario, ID_mueble, Cantidad_Mueble, Precio_Total, CURDATE(), '$direccion'
				FROM carrito
				WHERE Usuario = '$usuario'";
	
	//Validar estatuto 
	if(!mysqli_query($con,$estatuto))
	{
	echo '<style>';
	echo  'body {
			background: url(FondoMuebleria6.png);
			background-size: cover;
			background-repeat: no-repeat;
			margin: 0;
			height: 100vh;
			width: 200vh;
		}';
	echo '</style>';
	echo '<body>';
	echo "<br>";	
	echo '<div align="center">';
	echo "<h1><font size=30>Muebleria life shines</font></h1>";
	echo '<br><br>';

	echo '<img src="Tachita.png" alt="Tacha" width="100" height="100" />';
		die('<h1>Error al aplicar venta a la BD</h1><br><a href = "Listadocarrito.php?usuario='.$usuario.'"><font face = "Arial">Aceptar</font></a>');
	echo "<br><br>\n";

	echo '</div>';
	echo '</body>';
	}
	
	// Se limpia el carrito
	$estatuto = "DELETE FROM carrito
				WHERE Usuario = '$usuario'";
	
	if(!mysqli_query($con,$estatuto))
	{
		die('Error al limpiar el carrito en BD');
	}
	
	mysqli_close($con);
	//Mensaje de compra exitosa
	//Estilo del cuerpo
	echo '<style>';
	echo  'body {
			background: url(FondoMuebleria6.png);
			background-size: cover;
			background-repeat: no-repeat;
			margin: 0;
			height: 100vh;
			width: 200vh;
		}';
	echo '</style>';
	
	//Cuerpo
	echo '<body>';
	echo "<br>";	
	echo '<div align="center">';
	
	//Titulo
	echo "<h1><font size=30>Muebleria life shines</font></h1>";
	echo '<br>';
	echo '<img src="CarritoConPalomita.png" alt="BoteBasura" width="100" height="100" />';
	echo "<h1>¡Gracias por su compra!</h1>\n";
	echo "<h2>Su pedido llegará en un plazo no mayor a 3 dias</h2>\n";
	
	// Link de opción para ir a la página principal
	echo '<a href = "Principal.php?usuario='.$usuario.'"><font face = "Arial">Ir a Principal</font></a>';
	echo "<br><br>\n";
	echo '</div>';
	echo '</body>';
?>
