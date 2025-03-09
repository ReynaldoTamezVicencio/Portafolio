CREATE TABLE Pedidos (
ID_Pedido INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
Nombre_Cliente VARCHAR(50) NOT NULL, 
Orden VARCHAR(50) NOT NULL,
Notas VARCHAR(50) NOT NULL,
Total_Pago INT NOT NULL,
Envio VARCHAR(50) NOT NULL,
Direccion VARCHAR(50) NOT NULL,
Estatus_del_Pedido VARCHAR(50) NOT NULL,
Fecha DATE
);

INSERT INTO Pedidos 
VALUES ('Reynaldo', 'Enchiladas', 'Con aguacate', 149, 'Va a recoger', 'Santiago, Nuevo Leon', 'En proceso', '2021-11-11');

SELECT * FROM Pedidos

go
CREATE PROCEDURE Cambiar_Estatus
@Est AS VARCHAR(50),
@id  AS INT
AS
UPDATE Pedidos SET Estatus_del_Pedido = @Est 
WHERE ID_Pedido = @id
Go

Execute Cambiar_Estatus 'Finalizado', 5

