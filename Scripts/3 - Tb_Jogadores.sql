USE [DBSK002]
GO

/****** Object:  Table [dbo].[tb_Jogadores]    Script Date: 27/11/2020 12:29:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
--DROP TABLE DBSK002..tb_Jogadores
CREATE TABLE DBSK002..tb_Jogadores(
	 COD            int IDENTITY(1,1) NOT NULL,
	 NOME           varchar(60)       NOT NULL,
	 Nascimento     varchar(20)       NOT NULL,
	 RG             varchar(20)           NULL,
	 CPF            varchar(20)           NULL,
	 QtdPersonagens varchar(20)           NULL,
	 DataInclusao   varchar(20)       NOT NULL,
	 COD_USUARIO    int                   NULL,
	 ATIVO          int               NOT NULL,
 CONSTRAINT PK_COD_JOGADOR PRIMARY KEY CLUSTERED 
(COD ASC) WITH 
(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]) ON [PRIMARY]
GO

ALTER TABLE [dbo].tb_Jogadores  WITH CHECK ADD  CONSTRAINT [FK_COD_USUARIO] FOREIGN KEY([COD_USUARIO])
REFERENCES [dbo].[Tb_Usuarios] ([COD])
GO

ALTER TABLE [dbo].tb_Jogadores CHECK CONSTRAINT [FK_COD_USUARIO]
GO


