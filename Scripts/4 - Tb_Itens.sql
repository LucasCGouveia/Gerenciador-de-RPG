USE [DBSK002]
GO

--DROP TABLE TB_USUARIOS
--DROP TABLE TB_CONTATOS
--DROP TABLE Tb_JOGADOR
CREATE TABLE TB_CAMPANHAS(
	COD           int identity(1,1) NOT NULL,
	NomeCompanha  varchar(20)       NOT NULL,
	Sistema       varchar(20)       NOT NULL,
	Descricao     varchar(100)      NOT NULL,
	COD_MESTRE    int               NOT NULL,
	ATIVO         int               NOT NULL,
	CONSTRAINT PK_COD_CAMPANHAS PRIMARY KEY (COD),
	CONSTRAINT FK_COD_MESTRE FOREIGN KEY (COD_MESTRE)
)

ALTER TABLE [dbo].TB_CAMPANHAS  WITH CHECK ADD  CONSTRAINT COD_MESTRE FOREIGN KEY(COD)
REFERENCES [dbo].TB_USUARIOS (COD)
GO

	


