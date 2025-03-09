<?php

	// Tomamos el usuario del formulario
	$usuario = $_GET['usuario'];
	
	//Estilo al cuerpo de la pagina
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
	
    // Abrir conexión con BD 
	$con = mysqli_connect("localhost","root","", "bd_muebleria_life_shines");
	
	// Validar conexión con BD
	if (!$con)
	{
		// Si hubo error salir del programa
		die('No se estableció la conexión con el servidor de BD:' . mysqli_connect_error());
	}
	
	// Realizar consulta a la tabla datos de BD 
	$resultset = mysqli_query($con,"SELECT * FROM carrito WHERE Usuario = '$usuario'");
	echo '<body>';
	echo "<br>";	
	

	echo '<div align="center">';
	echo '<h1><font size="30px">Muebleria Life Shines</font></h1>';
	echo '<br>';
	echo '<h1>Listado de carrito</h1>';
	
	// Links de opción para ir a la página principal y comprar
	echo '<a href = "Principal.php?usuario='.$usuario.'"><font face="Arial">Ir a Principal</font></a>';
	echo '<br><br>';
	echo '<a href = "Comprar.php?usuario='.$usuario.'"><font face="Arial">Comprar</font></a>';
	echo "<br><br>\n";
	echo "<h2>Tienes estos articulos en tu carrito</h2>";
		
	// Tabla con las columnas: Imagen (ID mueble, Nombre mueble, Descripcion), Cantidad muebles, Precio Total, borrar del carrito
	echo "<table border='1'>
      <tr>
		  <th bgcolor='#F4FF67'>Imagen</th>
		  <th bgcolor='#F4FF67'>ID Mueble</th>
		  <th bgcolor='#F4FF67'>Nombre mueble</th>
		  <th bgcolor='#F4FF67'>Descripcion</th>
		  <th bgcolor='#F4FF67'>Cantidad Muebles</th>
		  <th bgcolor='#F4FF67'>Precio Total</th>
		  <th bgcolor='#F4FF67'>Borrar del carrito</th>
	  </tr>" ;

	// Agregar un renglón a la tabla por cada registro de la tabla carrito
	while($row = mysqli_fetch_array($resultset))       
	{
		$ID_Mueble = $row['ID_mueble'];
		
		// Traer la descripción de cada mueble
		$resultset2 = mysqli_query($con,"SELECT Descripcion 
										FROM muebles 
										WHERE ID_Mueble = $ID_Mueble");
		$row2 = mysqli_fetch_array($resultset2);
		
		// Traer el nombre de cada mueble
		$resultset3 = mysqli_query($con, "SELECT Nombre_Mueble
										 FROM muebles
										 WHERE ID_Mueble = $ID_Mueble");
		$row3 = mysqli_fetch_array($resultset3);
		
		
		// Traer imagen de cada mueble
		$resultset4 = mysqli_query($con, "SELECT Imagen 
		                                  FROM muebles 
										  WHERE ID_Mueble = $ID_Mueble");
		$row4 = mysqli_fetch_array($resultset4);
		
		// Rellenar tabla
		echo "<tr align='center'>";
		echo '  <td bgcolor="#F5E596"> <img src="'.$row4['Imagen'].'" alt="'.$row3['Nombre_Mueble'].'" width="100" height="100" /> </td>';
		echo "	<td bgcolor='#F5E596'> <font face='Arial'>" . $row['ID_mueble'] . "</font></td>";
		echo "  <td bgcolor='#F5E596'> <font face='Arial'>" . $row3['Nombre_Mueble'] . "</font></td>";
		echo "	<td bgcolor='#F5E596'> <font face='Arial'>" . $row2['Descripcion'] . "</font></td>";
		echo "	<td bgcolor='#F5E596'> <font face='Arial'>" . $row['Cantidad_Mueble'] . "</font></td>";
		echo "	<td bgcolor='#F5E596'> <font face='Arial'>" . $row['Precio_Total'] . "</font></td>";
		
		// Por cada registro agregamos un link para borrarlo
		echo '<td bgcolor="#F5E596"> <font face="Arial"> <a href = "Borrararticulocarrito.php?ID_Mueble='. $row['ID_mueble'] .'&usuario=' . $usuario . '"><img src="BoteBasura.png" alt="BoteBasura" width="40" height="40" /></a></font></td>';
		echo "</tr>" ;
	}
	echo '</div>';
	echo "<br><br>\n";
	echo '</body>';
	
	// Cerrar conexión con la BD
	mysqli_close($con);
		
?>