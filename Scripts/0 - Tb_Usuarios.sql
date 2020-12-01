USE [DBSK002]
GO

--DROP TABLE tb_Enderecos
--DROP TABLE Tb_Contatos
--DROP TABLE tb_Funcionarios
--DROP TABLE Tb_Usuarios
CREATE TABLE Tb_Usuarios(
	COD int identity(1,1) NOT NULL,
	LOGIN varchar(20) identity(1,1)     NOT NULL,
	SENHA varchar(20)     NOT NULL,
	TIPOUSER char         NOT NULL,
	ATIVO int             NOT NULL,
	CONSTRAINT PK_COD_USUARIOS PRIMARY KEY (COD)
)

insert into Tb_Usuarios (LOGIN,SENHA,TIPOUSER,ATIVO) 
VALUES ('null','null','N',0)

insert into Tb_Usuarios (LOGIN,SENHA,TIPOUSER,ATIVO) 
VALUES ('ADM','123456','A',1)

CREATE UNIQUE INDEX index_LOGIN
 ON Tb_Usuarios (LOGIN);


