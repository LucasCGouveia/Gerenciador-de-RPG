USE [DBSK002]
GO

/****** Object:  Table [dbo].[TB_PERSONAGENS]    Script Date: 27/11/2020 12:29:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
--DROP TABLE DBSK002..TB_PERSONAGENS
CREATE TABLE DBSK002..TB_PERSONAGENS(
	 COD          int IDENTITY(1,1) NOT NULL,
	 NOME         varchar(60)       NOT NULL,
	 RACA         varchar(50)       NOT NULL,
	 CLASSE       varchar(50)       NOT NULL,
	 ALINHAMENTO  varchar(50)       NOT NULL,
	 CA           int               NOT NULL,
	 PVTOTAL      int               NOT NULL,
	 PVATUAL      int               NOT NULL,
	 PATAQUE      int               NOT NULL,
	 INICIATIVA   int               NOT NULL,
	 DINHEIRO     int               NOT NULL,
	 EXPERIENCIA  int               NOT NULL,
	 NIVEL        int               NOT NULL,
	 GENERO       varchar(50)       NOT NULL,
	 CABELO       varchar(50)           NULL,
	 OLHOS        varchar(50)           NULL,
	 TAMANHO      varchar(50)           NULL,
	 ALTURA       varchar(50)           NULL,
	 PESO         varchar(50)           NULL,
	 HISTORIA     varchar(999)           NULL,
	 DataInclusao varchar(20)       NOT NULL,
	 COD_JOGADOR  int               NOT NULL,
	 COD_CAMPANHA int               NOT NULL,
	 ATIVO        int               NOT NULL,
 CONSTRAINT PK_COD_PERSONAGENS PRIMARY KEY CLUSTERED 
(COD ASC) WITH 
(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]) ON [PRIMARY]
GO

ALTER TABLE [dbo].TB_PERSONAGENS  WITH CHECK ADD  CONSTRAINT [FK_COD_JOGADOR] FOREIGN KEY(COD_JOGADOR)
REFERENCES [dbo].[Tb_JOGADORES] ([COD])
GO

ALTER TABLE [dbo].TB_PERSONAGENS CHECK CONSTRAINT [FK_COD_JOGADOR]
GO

--CREATE UNIQUE INDEX index_LOGIN
-- ON Tb_Usuarios (LOGIN);

