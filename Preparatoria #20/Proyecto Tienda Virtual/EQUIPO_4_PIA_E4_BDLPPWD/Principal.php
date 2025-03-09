
<?php
	//Se toman los valores del formulario
	$usuario = $_GET['usuario'];
	
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
	
	echo "<body>";
	echo "<div align='center'>";
	echo '<br>';
	echo '<h1><font size="30px">Muebleria Life Shines</font></h1>';
	echo '<br>';
	echo '<h1>Bienvenido</h1>';
	echo "<font face='Arial'>Hola " . $usuario . '</font>';
	echo "<br><br>";
	echo '<a href="Listadocarrito.php?usuario='.$usuario.'"><font face="Arial"> <img src="Carrito.png" alt="Carrito" height="70" width="70"><br>Ver listado de carrito </font></a>';
	echo "<br>";
	echo "<h2>Articulos Disponibles</h2>";
	echo "<br>";
	echo "<font face='Arial'>Haz clic sobre la imagen para agregar al Carrito</font>";
	echo "<br><br>";
	
	echo "</div>";
	
	
	// En esta seccion se hará un query para obtener los articulos desde la BD
	// Abrir conexión con BD 
	$con = mysqli_connect("localhost","root","", "bd_muebleria_life_shines");
	
	// Validar conexión con BD
	if (!$con)
	{
		// Si hubo error salir del programa
		die('No se estableció la conexión con el servidor de BD:' . mysqli_connect_error());
	}
	
	echo "<div align = 'center'>";
	echo "<table border='1'>
      <tr>
		  <th bgcolor='#F4FF67'>ID_Mueble</th> 
		  <th bgcolor='#F4FF67'>Nombre del mueble</th>   
		  <th bgcolor='#F4FF67'>Descripcion</th>
		  <th bgcolor='#F4FF67'>Precio</th>
		  <th bgcolor='#F4FF67'>Imagen</th>
	  </tr>" ;
	
	
	// Realizar consulta a la tabla muebles de BD 
	$resultset = mysqli_query($con,"SELECT * FROM muebles");
	
	while($row = mysqli_fetch_array($resultset))       
	{
		echo "<tr align='center'>";
		echo "  <td bgcolor='#F5E596'><font face='Arial' size='20pt'>" . $row['ID_Mueble'] . "</font></td>";
		echo "  <td bgcolor='#F5E596'><font face='Arial'>" . $row['Nombre_Mueble'] . "</font></td>";
		echo "  <td bgcolor='#F5E596'><font face='Arial'>" . $row['Descripcion'] . "</font></td>";
		echo "  <td bgcolor='#F5E596'><font face='Arial'>" . $row['Precio'] . "</font></td>";

		
		echo '<td bgcolor="#F5E596"> <a href="Agregaacarrito.php?usuario='.$usuario.'&ID_Mueble='.$row['ID_Mueble'].'"> <img src="'.$row['Imagen'].'" alt="'.$row['Nombre_Mueble'].'" width="100" height="100" /></a><br><br> </tr>'; 
		echo '</tr>';
		
	}
		echo '</table>';
		echo "</div>";
	// ************  termina la sección del query para el desplegado de articulos
	echo '<br><br>';
	echo '<div align="center">';
	echo '<a href="Index.html"><font face="Arial">Cerrar Sesion</font></a>';
	echo '</div>';
	echo '<br>';
	
	
?>

