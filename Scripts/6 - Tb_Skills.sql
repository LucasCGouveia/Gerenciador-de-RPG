USE [DBSK002]
GO

--DROP TABLE TB_ENDERECOS
--DROP TABLE TB_CONTATOS
--DROP TABLE Tb_Skills
CREATE TABLE Tb_Skills(
	COD       int identity(1,1) NOT NULL,
	Skill     varchar(20)       NOT NULL,
	Descricao varchar(100)      NOT NULL,
	ATIVO     int               NOT NULL,
	CONSTRAINT PK_COD_SKILLS PRIMARY KEY (COD),
)

	


