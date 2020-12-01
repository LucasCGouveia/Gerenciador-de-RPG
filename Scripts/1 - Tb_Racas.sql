USE [DBSK002]
GO

--DROP TABLE TB_ENDERECOS
--DROP TABLE TB_CONTATOS
--DROP TABLE Tb_JOGADOR
CREATE TABLE Tb_Racas(
	COD       int identity(1,1) NOT NULL,
	Raca      varchar(20)       NOT NULL,
	Descricao varchar(100)      NOT NULL,
	ATIVO     int               NOT NULL,
	CONSTRAINT PK_COD_RACAS PRIMARY KEY (COD),
)

	


