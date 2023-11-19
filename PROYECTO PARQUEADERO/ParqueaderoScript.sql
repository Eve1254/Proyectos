USE master;
GO
create database Parqueadero;
go
use Parqueadero;
go
CREATE TABLE Control_Acceso
(
Nombre nvarchar(50) primary key not null,
Clave nvarchar(50) not null,
Rol int not null,
Pregunta nvarchar(50),
Respuesta nvarchar(50)
);
go
CREATE TABLE Celdas
(
CeldaId INT PRIMARY KEY NOT NULL,
TipoCelda VARCHAR(50),
TarifaHora INT,
EstadoCelda VARCHAR(50)
);
go
CREATE TABLE Clientes
(
Cedula INT PRIMARY KEY NOT NULL,
Nombre VARCHAR(50) default 'Anonimo',
Placa VARCHAR(50),
TipoVehiculo VARCHAR(50),
CodigoCelda INT,
FOREIGN KEY(CodigoCelda) REFERENCES CELDAS(CeldaId) ON DELETE CASCADE,
FOREIGN KEY(CodigoCelda) REFERENCES CELDAS(CeldaId) ON UPDATE CASCADE
);
go
CREATE TRIGGER Actualizar_EStadoCelda on Clientes
AFTER INSERT, UPDATE , DELETE
AS BEGIN SET NOCOUNT ON;

UPDATE C SET EstadoCelda = 'Ocupada'
FROM CELDAS C
INNER JOIN INSERTED i ON C.CeldaId = i.CodigoCelda;

UPDATE C SET EstadoCelda = 'Vac�o'
FROM CELDAS C
INNER JOIN DELETED d ON C.CeldaId = d.CodigoCelda;
END;
go
--1. Administrador 2. Taquillero
INSERT INTO Control_Acceso VALUES
('Santiago Correa','1234',1,'Mascota','Manito'),
('Jose Manuel Morales','4567',2,'Color','Negro');
go
INSERT INTO Celdas VALUES
(01,'Moto',1000,'Vac�a'),
(02,'Moto',1000,'Vac�a'),
(03,'Moto',1000,'Ocupada'),
(04,'Moto',1000,'Vac�a'),
(06,'Moto',1000,'Ocupada'),
(07,'Moto',1000,'Vac�a'),
(08,'Moto',1000,'Vac�a'),
(09,'Moto',1000,'Ocupada'),
(10,'Moto',1000,'Vac�a'),
(11,'Moto',1000,'Vac�a'),
(12,'Moto',1000,'Ocupada'),
(13,'Moto',1000,'Vac�a'),
(14,'Moto',1000,'Vac�a'),
(15,'Moto',1000,'Ocupada'),
(16,'Moto',1000,'Vac�a'),
(17,'Moto',1000,'Vac�a'),
(18,'Moto',1000,'Ocupada'),
(19,'Moto',1000,'Ocupada'),
(20,'Moto',1000,'Vac�a'),
(21,'Carro',3000,'Vac�a'),
(22,'Carro',3000,'Vac�a'),
(23,'Carro',3000,'Ocupada'),
(24,'Carro',3000,'Ocupada'),
(25,'Carro',3000,'Vac�a'),
(26,'Carro',3000,'Vac�a'),
(27,'Carro',3000,'Vac�a'),
(28,'Carro',3000,'Vac�a'),
(29,'Carro',3000,'Vac�a'),
(30,'Carro',3000,'Ocupada'),
(31,'Carro',3000,'Ocupada'),
(32,'Carro',3000,'Ocupada'),
(33,'Carro',3000,'Ocupada'),
(34,'Carro',3000,'Ocupada'),
(35,'Carro',3000,'Ocupada'),
(36,'Carro',3000,'Ocupada'),
(37,'Carro',3000,'Ocupada'),
(38,'Carro',3000,'Ocupada'),
(39,'Carro',3000,'Ocupada'),
(40,'Carro',3000,'Ocupada'),
(41,'Carro',3000,'Ocupada'),
(42,'Carro',3000,'Vac�a'),
(43,'Bus',4000,'Vac�a'),
(44,'Bus',4000,'Ocupada'),
(45,'Bus',4000,'Vac�a'),
(46,'Bus',4000,'Ocupada'),
(0101,'Bicicleta',2000,'Ocupada'),
(0202,'Bicicleta',2000,'Vac�a'),
(0303,'Bicicleta',2000,'Vac�a'),
(0404,'Bicicleta',2000,'Vac�a');
go
INSERT INTO Clientes VALUES
(1010,'Juan Pablo Moreno','LRV026','Camioneta',23),
(1110,'Maria Clara Velez','TWR471','Automovil',24),
(1212,'Liliana Lopera','LIO54C','Moto',06),
(1313,'Pedro Cifuentes','QWD865','Bus',46),
(1414,'Sim�n Pulgar�n','JUM89D','Moto',09),
(1515,'Mariana Orrego','PHT892','Camioneta',30),
(1616,'Evelyn Mu�etones','B1','Bicicleta',0101),
(1717,'Gabriel Rend�n','LRV026','Camioneta',31),
(1818,'Camila Garc�a','LIK898','Camioneta',32),
(1919,'Samantha Alvarez','POL896','Camioneta',33),
(2020,'Camilo Restrepo','OPI869','Camioneta',34),
(2121,'Anonimo','OIO888','Camioneta',35),
(2222,'Karen Taborda','UYH256','Camioneta',36),
(2323,'Pablo Tabares','JKI78A','Moto',12),
(2424,'Carlos Echeverry','TUB587','Bus',44),
(2525,'Anonimo','OPL45F','Moto',15),
(2626,'Oscar Avenda�o','HIJ789','Camioneta',37),
(2727,'Lizeth Alvarez','FGL46G','Moto',18),
(2828,'Juli�n Otalvaro','MOR171','Camioneta',38),
(2929,'Brayan Mu�oz','TQM256','Bus',001),
(3030,'Isabel Lopera','OPL456','Camioneta',39),
(3131,'Anonimo','BXB708','Camioneta',40),
(3232,'Cleopatra Palacio','LRV026','Moto',19),
(3333,'Dar�o Gom�z','EIM336','Camioneta',41);

select * from Clientes;
select * from Celdas;