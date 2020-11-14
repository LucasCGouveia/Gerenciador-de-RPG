USE [DBSK001]
GO

-- DROP TABLE Tb_Contatos
CREATE TABLE Tb_Contatos(
	COD        int identity(1,1) NOT NULL,
	COD_Func   int               NOT NULL,
	TIPO       varchar(30)       NOT NULL,
	Contato    varchar(60)       NOT NULL,
	Observacao varchar(255)      NULL,
	CONSTRAINT PK_COD_CONTATO PRIMARY KEY (COD),
	CONSTRAINT FK_COD_FUNC_CONTATO FOREIGN KEY (COD_FUNC) REFERENCES tb_funcionarios (COD)
)

--SELECT * FROM Tb_Contatos


