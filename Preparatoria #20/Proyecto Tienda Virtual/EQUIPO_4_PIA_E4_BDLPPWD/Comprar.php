<?php
	
	// Obtener el parámetro a través de URL por el método GET
	// Validarlo
	if (isset($_GET['usuario']))
	{
		$usuario = $_GET['usuario'];
	} else
	{
		die ("Error, falta el parametro de usuario");
	}
	
	// Abrir conexión con BD muebleria life shines
	$con = mysqli_connect("localhost","root","", "bd_muebleria_life_shines");
	
	// Validar conexión con BD
	if (!$con)
	{
		// Si hubo error salir del programa
		die('No se estableció la conexión con el servidor de BD:' . mysqli_connect_error());
	}

	// Nos traemos de BD cuantos muebles va a comprar (SUMA DE TODAS LAS CANTIDADES DEL CARRITO)
	$resultset = mysqli_query($con,"SELECT SUM(Cantidad_Mueble) FROM carrito WHERE Usuario = '$usuario'");

	// Solo habrá un registro, 
	// No se ocupa el While para recorrer resultset
	$row = mysqli_fetch_array($resultset);
	
	// tomamos los valores del registro
	$cant_art = $row['SUM(Cantidad_Mueble)'];
	
	// Nos traemos de BD el total a pagar (SUMA DE TODOS LOS TOTALES DEL CARRITO)
	$resultset = mysqli_query($con,"SELECT SUM(Precio_Total) FROM carrito WHERE Usuario = '$usuario'");

	// Solo habrá registro, 
	// No se necesita While para recorrer el resultset
	$row=mysqli_fetch_array($resultset);
	
	// tomamos los valores del registro
	$total_pagar = $row['SUM(Precio_Total)'];

	//Estilo del cuerpo del formulario
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
	echo '<h1><font size="30px">Muebleria Life Shines</font></h1>';
	echo '<br>';
	// Creacion de formulario, usando echo para codigo html

	// Título
	echo "<h1>Comprar los articulos del Carrito</h1>\n";
	
	//Formulario, su accion y metodo
	echo "<form action = ComprarBD.php method = POST>";
	
	// Llenado de valores del formulario
	echo "<font face = 'Arial'>Hola de nuevo: </font><input type = 'Text' name = 'usuario' value = $usuario readonly =readonly> <br><br>";
	echo "<font face = 'Arial'>Cantidad de muebles a comprar: </font><input type = 'Text' name = 'cant_art' value = $cant_art readonly =readonly> <br><br>";
	echo "<font face = 'Arial'>Total a pagar: </font><input type = 'Text' name = 'total_pagar' value = $total_pagar readonly =readonly ><br><br>";
	echo "<font face = 'Arial'>Direccion entrega: </font><input type = 'Text' name = 'direccion' ><br><br>";
	
	echo '<input type = "Submit" value = "Comprar">';
	echo "</form>";
	echo "<br><br>";
	echo '</div>';
	echo '</body>';
	// Cerramos la conexión a la BD
	mysqli_close($con);
	
	//Links para transitar entre paginas
	echo '<div align = center>';
	echo '<a href = "Principal.php?usuario='.$usuario.'"><font face = "Arial">Ir a Principal</font></a>';
	echo '<br><br>';
	echo '<a href = "Listadocarrito.php?usuario='.$usuario.'"><font face = "Arial">Regresar</font></a>';
	echo '</div>';
?>
