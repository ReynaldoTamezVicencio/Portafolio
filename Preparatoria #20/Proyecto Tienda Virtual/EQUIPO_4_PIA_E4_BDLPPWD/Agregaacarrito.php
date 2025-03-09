<?php
	
	// Pasaje de parametros por URL usando el metodo GET
	// Se valida
	if (isset($_GET['usuario'], $_GET['ID_Mueble']))
	{
		$usuario = $_GET['usuario'];
		$ID_Mueble = $_GET['ID_Mueble'];
	} else
	{
		die ("Error, faltan los parametros");
	}
	
	// Abrir conexión con BD muebleria life shines
	$con = mysqli_connect("localhost","root","", "bd_muebleria_life_shines");
	
	// Validar conexión con BD
	if (!$con)
	{
		// Si hubo error salir del programa
		die('No se estableció la conexión con el servidor de BD:' . mysqli_connect_error());
	}

	// Nos traemos el registro completo para el ID mueble seleccionado, de tabla de muebles
	$resultset = mysqli_query($con,"SELECT * FROM muebles WHERE ID_Mueble = $ID_Mueble");

	// Solo habrá registro, 
	// No es necesario el While para recorrer resultset
	$row = mysqli_fetch_array($resultset);
	
	// Se toman los valores del registro
	$Nombre_Mueble = $row['Nombre_Mueble'];
	$descripcion = $row['Descripcion'];
	$precio = $row['Precio'];
	$Imagen = $row['Imagen'];
	// Creacion de un formulario, usando echo para codigo html

	// Estilo al cuerpo del formulario
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
	
	// Cuerpo del formulario
	// Titulos
	echo '<body>';
	echo '<div align="center">';
	echo '<br>';
	echo '<h1><font size="30px">Muebleria Life Shines</font></h1>';
	echo '<br>';
	echo "<h1>Agregar articulo a Carrito</h1>\n";
	
	echo "<form action = AgregaacarritoBD.php method = POST>";
	
	// Llenar valores del formulario
	echo "<font face='Arial'>Hola: </font><input type = 'Text' name = 'usuario' value = $usuario readonly =readonly> <br><br>";
	echo "<font face='Arial'>Id mueble: </font><input type = 'Text' name = 'Id_Mueble' value = $ID_Mueble readonly =readonly> <br><br>";
	echo "<font face='Arial'>Nombre del Mueble: </font><input type = 'Text' name = 'Nom_Mueble' value = '$Nombre_Mueble' maxlength = 100 readonly = readonly><br><br>";
	echo "<font face='Arial'>Descripcion: </font><input type = 'Text' name = 'descripcion' value = '$descripcion' size = 40 maxlength = 120  readonly =readonly><br><br>";
	echo "<font face='Arial'>Precio: </font><input type = 'Text' name = 'precio' value = '$precio'  readonly =readonly ><br><br>";
	echo "<font face='Arial'>Cantidad: </font><input type = 'Text' name = 'cantidad' value = '1' ><br><br>";
	echo '<img src="'.$Imagen.'" alt="'.$Nombre_Mueble.'" width="220" height="220" /><br><br>';
	
	echo '<input type = "Submit" value = "Agregar a carrito">';
	echo "</form>";
	echo "<br>";

	// Cerramos la conexión a la BD
	mysqli_close($con);
	
	// Link para regresar a la pagina principal
	echo '<a href = "Principal.php?usuario='.$usuario.'"><font face="Arial">Ir a Principal</font></a>';

	echo '</div>';
	echo '</body>';
?>
