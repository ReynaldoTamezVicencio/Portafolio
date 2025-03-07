/* Reynaldo Tamez Vicencio */

/* Creación BD */
CREATE DATABASE Biblioteca_Vicencio

/* Creación tablas */
CREATE TABLE SOCIOS (Num_Socio INT Primary Key, Nombre VARCHAR(50), Direccion VARCHAR(50), Telefono VARCHAR(10), Fecha_Inscripcion Date)
CREATE TABLE LIBROS (ID_Libro INT Primary Key, Nombre_Libro VARCHAR(50), Editorial VARCHAR(20), GENERO VARCHAR(15))
CREATE TABLE PRESTAMOS (ID_Prestamos INT Primary key, Socio INT, Libro INT, Fecha_Prestamo Date, Costo INT)


/* RTV Registros tabla socios */
INSERT INTO SOCIOS (Num_Socio, Nombre, Direccion, Telefono, Fecha_Inscripcion)
			VALUES (01, 'Reynaldo Tamez', 'El Barrial', '8186041671', '2021-05-01')

INSERT INTO SOCIOS (Num_Socio, Nombre, Direccion, Telefono, Fecha_Inscripcion)
			VALUES (02, 'Karina Vicencio', 'Reynosa', '8115456978', '2021-05-01')

INSERT INTO SOCIOS (Num_Socio, Nombre, Direccion, Telefono, Fecha_Inscripcion)
			VALUES (03, 'José Antonio', 'San Andres', '8137429175', '2021-05-02')

INSERT INTO SOCIOS (Num_Socio, Nombre, Direccion, Telefono, Fecha_Inscripcion)
			VALUES (04, 'Oliver Vicencio', 'San Nicolas', '8175917281', '2021-05-02')

INSERT INTO SOCIOS (Num_Socio, Nombre, Direccion, Telefono, Fecha_Inscripcion)
			VALUES (05, 'Angel Vicencio', 'San Pedro', '8134197518', '2021-05-03')

INSERT INTO SOCIOS (Num_Socio, Nombre, Direccion, Telefono, Fecha_Inscripcion)
			VALUES (06, 'Andrea Vicencio', 'Monterrey', '8145917252', '2021-05-03')

INSERT INTO SOCIOS (Num_Socio, Nombre, Direccion, Telefono, Fecha_Inscripcion)
			VALUES (07, 'Alicia Reyna', 'El Barrial', '8192719476', '2021-05-04')

INSERT INTO SOCIOS (Num_Socio, Nombre, Direccion, Telefono, Fecha_Inscripcion)
			VALUES (08, 'Oscar Vicencio', 'Villahermosa', '8192551257', '2021-05-04')

INSERT INTO SOCIOS (Num_Socio, Nombre, Direccion, Telefono, Fecha_Inscripcion)
			VALUES (09, 'Alondra Vicencio', 'Reynosa', '8172439482', '2021-05-05')

INSERT INTO SOCIOS (Num_Socio, Nombre, Direccion, Telefono, Fecha_Inscripcion)
			VALUES (10, 'Jahir Vicencio', 'Guadalupe', '8194758425', '2021-05-05')

/* RTV Creación tabla libros */
INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (01, 'Sangre de Campeon', 'Diamante', 'Historia')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (02, 'Diario de Greg', 'Molino', 'Novela Comimca')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (03, 'Cien años de soledad', 'Sudamericana', 'Novela')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (04, 'Harry Potter', 'BloomsburyPublishing', 'Fantasia')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (05, 'Biología en la Salud', 'TD&IS', 'Documental')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (06, 'Libro de inglés progresivo', 'LA&GO', 'Ensayo')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (07, 'Diario de Ana Frank', 'Contact', 'Autobiografía')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (08, 'Hamlet', 'Desconocida', 'Tragedia')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (09, 'Uzumaki', 'Shogakukan', 'Horror')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (10, 'Los Viajes de Gulliver', 'Benjamin Motte', 'Novela')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (11, 'El señor de los Anillos', 'George & Unwin', 'Novela')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (12, 'El principito', 'Reynal & Hitchcock', 'Novela')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (13, 'Alicia en el país de las maravillas', 'Macmillan Publishers', 'Novela')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (14, 'Diez negritos', 'Collins Crime', 'Detectives')

INSERT INTO LIBROS (ID_Libro, Nombre_Libro, Editorial, GENERO)
			VALUES (15, 'El alquimista', 'Das Letras', 'Narrativa')


/* RTV Creacion tabla prestamos */
INSERT INTO PRESTAMOS (ID_Prestamos, Socio, Libro, Fecha_Prestamo, Costo)
			VALUES (01, 06, 14, '2020-05-16', 199)

INSERT INTO PRESTAMOS (ID_Prestamos, Socio, Libro, Fecha_Prestamo, Costo)
			VALUES (02, 02, 06, '2020-05-16', 239)

INSERT INTO PRESTAMOS (ID_Prestamos, Socio, Libro, Fecha_Prestamo, Costo)
			VALUES (03, 05, 08, '2020-05-17', 269 )

INSERT INTO PRESTAMOS (ID_Prestamos, Socio, Libro, Fecha_Prestamo, Costo)
			VALUES (04, 09, 01, '2020-05-17', 319)

INSERT INTO PRESTAMOS (ID_Prestamos, Socio, Libro, Fecha_Prestamo, Costo)
			VALUES (05, 01, 04, '2020-05-18', 219)

INSERT INTO PRESTAMOS (ID_Prestamos, Socio, Libro, Fecha_Prestamo, Costo)
			VALUES (06, 05, 10, '2020-05-18', 309)

INSERT INTO PRESTAMOS (ID_Prestamos, Socio, Libro, Fecha_Prestamo, Costo)
			VALUES (07, 08, 04, '2020-05-19', 159)

INSERT INTO PRESTAMOS (ID_Prestamos, Socio, Libro, Fecha_Prestamo, Costo)
			VALUES (08, 07, 13, '2020-05-19', 419)

INSERT INTO PRESTAMOS (ID_Prestamos, Socio, Libro, Fecha_Prestamo, Costo)
			VALUES (09, 02, 12, '2020-05-20', 349)

INSERT INTO PRESTAMOS (ID_Prestamos, Socio, Libro, Fecha_Prestamo, Costo)
			VALUES (10, 03, 02, '2020-05-20', 279)

/* RTV CONSULTAS TABLAS */
SELECT * FROM PRESTAMOS
SELECT * FROM LIBROS
SELECT * FROM SOCIOS

/* RTV Más sentencias */
/* RTV Update */
SELECT * FROM SOCIOS

UPDATE SOCIOS SET Direccion = 'Reynosa' WHERE Nombre = 'Jahir Vicencio'

/* RTV Delete */
SELECT * FROM LIBROS
DELETE FROM LIBROS WHERE ID_Libro = '15'

/* RTV Uso de Like */
SELECT * FROM SOCIOS

SELECT * FROM SOCIOS WHERE Nombre LIKE 'A%'

/* RTV funciones de agregado */
SELECT * FROM PRESTAMOS

SELECT AVG(Costo) AS Promedio_Costo FROM PRESTAMOS
SELECT COUNT(*) AS Costos_Mayores_De_300_Pesos FROM PRESTAMOS WHERE Costo > 300
SELECT SUM(Costo) As Suma_Costos FROM PRESTAMOS
SELECT MAX(Costo) As Costo_Maximo FROM PRESTAMOS
SELECT MIN(Costo) As Costo_Minimo FROM PRESTAMOS