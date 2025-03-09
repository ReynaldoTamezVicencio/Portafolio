-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 13-11-2021 a las 00:56:58
-- Versión del servidor: 10.4.17-MariaDB
-- Versión de PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_muebleria_life_shines`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `carrito`
--

CREATE TABLE `carrito` (
  `ID_Folio` int(4) NOT NULL,
  `ID_usuario` int(4) NOT NULL,
  `ID_mueble` int(4) NOT NULL,
  `Cantidad_Mueble` int(4) NOT NULL,
  `Precio_Total` int(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `muebles`
--

CREATE TABLE `muebles` (
  `ID_Mueble` int(4) NOT NULL,
  `Nombre_Mueble` varchar(50) NOT NULL,
  `Descripcion` varchar(50) NOT NULL,
  `Precio` int(6) NOT NULL,
  `Imagen` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `muebles`
--

INSERT INTO `muebles` (`ID_Mueble`, `Nombre_Mueble`, `Descripcion`, `Precio`, `Imagen`) VALUES
(1, 'Base de Cama', 'Color negro', 7000, 'BaseCamaNegro.jpeg'),
(2, 'Base de cama', 'Color blanco', 8000, 'BaseCamaBlanco.jpg'),
(3, 'Comedor', 'Color Blanco y amplio', 13000, 'ComedorBlanco.jpg'),
(4, 'Comedor', 'Color rosa claro y amplio', 14000, 'ComedorRosaClaro.jpg'),
(5, 'Sala', 'Color gris con base y brazos de color negro', 9500, 'SalaGris.jpg'),
(6, 'Sala', 'Color rojo con base y brazos color cafe oscuro', 8500, 'SalaRoja.jpg'),
(7, 'Sala minimalista', 'Color blanco base cafe oscuro y brazo blanco', 11000, 'SalaMinimalistaBlanca.png'),
(8, 'Vanity', 'Color blanco, con cajones, una silla y luces', 9000, 'VanityBlanco.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `ID_Usuario` int(4) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`ID_Usuario`, `Nombre`, `Password`) VALUES
(1, 'Reynaldo', 'hnXaXZAUQjjWk'),
(2, 'Ariana', 'hn4GOvz0o8nB2'),
(3, 'Mario', 'hngm8Ln9zVPmU'),
(4, 'Luis', 'hnJw9KkPdr/e2'),
(5, 'Devany', 'hn5ptH8Kj0S0c');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `Folio_Venta` int(4) NOT NULL,
  `ID_usuario` int(4) NOT NULL,
  `ID_Mueble` int(4) NOT NULL,
  `Cantidad_Mueble` int(4) NOT NULL,
  `Total_venta` int(8) NOT NULL,
  `Fecha_Venta` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `carrito`
--
ALTER TABLE `carrito`
  ADD PRIMARY KEY (`ID_Folio`),
  ADD UNIQUE KEY `ID_usuario` (`ID_usuario`,`ID_mueble`),
  ADD KEY `ID_mueble` (`ID_mueble`);

--
-- Indices de la tabla `muebles`
--
ALTER TABLE `muebles`
  ADD PRIMARY KEY (`ID_Mueble`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID_Usuario`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`Folio_Venta`),
  ADD UNIQUE KEY `ID_usuario` (`ID_usuario`,`ID_Mueble`),
  ADD KEY `ID_Mueble` (`ID_Mueble`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `carrito`
--
ALTER TABLE `carrito`
  MODIFY `ID_Folio` int(4) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `muebles`
--
ALTER TABLE `muebles`
  MODIFY `ID_Mueble` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `ID_Usuario` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `Folio_Venta` int(4) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `carrito`
--
ALTER TABLE `carrito`
  ADD CONSTRAINT `carrito_ibfk_1` FOREIGN KEY (`ID_usuario`) REFERENCES `usuarios` (`ID_Usuario`),
  ADD CONSTRAINT `carrito_ibfk_2` FOREIGN KEY (`ID_mueble`) REFERENCES `muebles` (`ID_Mueble`);

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`ID_usuario`) REFERENCES `usuarios` (`ID_Usuario`),
  ADD CONSTRAINT `ventas_ibfk_2` FOREIGN KEY (`ID_Mueble`) REFERENCES `muebles` (`ID_Mueble`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
