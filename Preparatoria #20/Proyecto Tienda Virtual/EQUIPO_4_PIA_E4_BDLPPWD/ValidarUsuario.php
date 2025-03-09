<?php

	// Tomamos los valores actualizados en el formulario
	$usuario = $_POST['usuario'];
	$password = $_POST['clave'];
	$passwordcript = crypt($password,"hn");

	// Abrir conexión con BD muebleria life shines
	$con = mysqli_connect("localhost","root","", "bd_muebleria_life_shines");
	
    // Validar la comunicación
    if (!$con)
	{
		die('No se estableció la conexión con el servidor de BD:' . mysqli_connect_error());
	}
	
	// Traer el registro completo para el usuario y password seleccionado
	$resultset = mysqli_query($con,"SELECT count(*) FROM usuarios 
									WHERE Nombre = '$usuario' 
									  and Password = '$passwordcript'");
	
	// Solo habrá registro, 
	// No es necesario el While para recorrer resultset
	$row = mysqli_fetch_array($resultset); 

	// Cerrar conexión
	mysqli_close($con);	
	
	//Verificar si existe un registro con lo colocado en el formulario
	$cantreg = $row['count(*)'];
	if ($cantreg == 1)
	{
		//Si existe, va a la pagina principal
		header("Location: Principal.php?usuario=$usuario");
	}
	else
	{
	//Error en caso de que no exista
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
	echo '<img src="SignoDeInterrogacion.jpg" alt="Tachita" width="100" height="100" />';
	echo "<h1>Este usuario no existe, verifique si puso los datos correctamente</h1>\n";
	
	// Links de opción para ir a la transitar entre paginas
	echo '<a href = "Index.html"><font face = "Arial">Regresar</font></a>';
	echo '<br><br>';
	echo '<font face = "Arial"><a href = "AltaUsuarios.html">Ir a registro de usuarios</a></font>';
	echo "<br><br>\n";
	echo '</div>';
	echo '</body>';
	}
	
	
?>
