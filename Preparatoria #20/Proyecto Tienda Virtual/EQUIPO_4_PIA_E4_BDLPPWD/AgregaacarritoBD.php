<?php

	// Tomamos los valores actualizados en el formulario
	$usuario = $_POST['usuario'];
	$ID_Mueble = $_POST['Id_Mueble'];
	$precio = $_POST['precio'];
	$cantidad = $_POST['cantidad'];
	
	//Calcular el precio total
	$preciototal = $precio * $cantidad;

	// Abrir conexión con BD muebleria life shines
	$con = mysqli_connect("localhost","root","", "bd_muebleria_life_shines");
	
	// Validar conexión con BD
	if (!$con)
	{
		// Si hubo error salir del programa
		die('No se estableció la conexión con el servidor de BD:' . mysqli_connect_error());
	}
	
	// Se elabora el estatuto para insertar el registro a la tabla carrito de la BD
	$estatuto = "INSERT INTO carrito (Usuario, ID_mueble, Cantidad_Mueble, Precio_Total)
				VALUES ('$usuario', $ID_Mueble, $cantidad, $preciototal)";
				
	// Validar estatuto para insertar
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
		die('<h1>Error al agregar articulo a carrito</h1><br><a href = "Principal.php?usuario='.$usuario.'"><font face = "Arial">Aceptar</font></a>');
	echo "<br><br>\n";

	echo '</div>';
	echo '</body>';
	}
	
	// Cierre de conexión a la BD
	mysqli_close($con);
	
	// Ir a página principal
	header("Location: Principal.php?usuario=$usuario");

?>
