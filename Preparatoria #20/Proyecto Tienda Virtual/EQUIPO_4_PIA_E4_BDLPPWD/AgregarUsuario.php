<?php

	// Tomamos los valores actualizados en el formulario
	$usuario = $_POST['user'];
	$password = $_POST['contrasena'];
	$passwordcript = crypt($password,"hn");

	// Abrir conexión con BD muebleria life shines
	$con = mysqli_connect("localhost","root","", "bd_muebleria_life_shines");
	
	// Validar conexión con BD
	if (!$con)
	{
		// Si hubo error salir del programa
		die('No se estableció la conexión con el servidor de BD:' . mysqli_connect_error());
	}
	
	// Estatuto para insertar el registro en la tabla de usuarios
	$estatuto = "INSERT INTO usuarios (Nombre, Password) 
					VALUES ('$usuario', '$passwordcript')";

	// Validacion al insertar datos
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
		//Error
		die('<h1>Error al insertar registro en tabla Usuario</h1><br><a href = "AltaUsuarios.html"><font face = "Arial">Aceptar</font></a>');

	echo "<br><br>\n";

	echo '</div>';
	echo '</body>';
	}
	//Cerrar conexion
	mysqli_close($con);
	
	// Ventana si el usuario se crea exitosamente
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
	echo '<img src="PalomitaVerde2.png" alt="BoteBasura" width="100" height="100" />';
	echo "<h1>¡Su cuenta fue creada con exito!</h1>\n";
	
	// Links para viajar entre páginas	
	echo '<a href = "Index.html"><font face = "Arial">Ir a inicio de sesion</font></a>';
	echo '<br><br>';
	echo '<a href = "AltaUsuarios.html"><font face = "Arial">Regresar</font></a>';
	echo "<br><br>\n";
	echo '</div>';
	echo '</body>';

?>
