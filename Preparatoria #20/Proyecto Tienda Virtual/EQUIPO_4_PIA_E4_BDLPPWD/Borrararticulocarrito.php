<?php
	
	// Tomamos el id del parámetro del URL (Usando GET) Y validamos
	if (isset($_GET['usuario'], $_GET['ID_Mueble']))
	{
		$usuario = $_GET['usuario'];
		$ID_Mueble = $_GET['ID_Mueble'];
	} else
	{
		die ('Falta los parámetros, no proviene de navegación segura');
	}
	
    // Abrir conexión con BD muebleria life shines
	$con = mysqli_connect("localhost","root","", "bd_muebleria_life_shines");
	
	// Validar conexión con BD
	if (!$con)
	{
		// Si hubo error salir del programa
		die('No se estableció la conexión con el servidor de BD:' . mysqli_connect_error());
	}

	// Estatuto para borrar el registro de la tabla carrito
	$estatuto = "DELETE FROM carrito 
				WHERE Usuario = '$usuario' and ID_mueble = $ID_Mueble";
	
	// Validar el borrado
	if(!mysqli_query($con,$estatuto))
	{
		die('Error al borrar el registro');
	}
	
	echo "<br><br>\n";
	
	// Se cierra la conexión a la BD
	mysqli_close($con);
	
	// Ubicar de nuevo en el listado de articulos
	header("Location: Listadocarrito.php?usuario=$usuario");
	
?>
