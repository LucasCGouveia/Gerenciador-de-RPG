USE [DBSK001]
GO

--DROP TABLE TB_ENDERECOS
CREATE TABLE tb_Enderecos(
	COD int identity(1,1)   NOT NULL,
	COD_Func int            NULL,
	DESCRICAO varchar(50)   NOT NULL,
	CEP varchar(20)         NOT NULL,
	Endereco varchar(20)    NOT NULL,
	Numero varchar(20)      NULL,
	Complemento varchar(20) NULL,
	Bairro varchar(60)      NULL,
	Cidade varchar(20)      NULL,
	Estado varchar(20)      NULL,
	CONSTRAINT PK_COD_ENDERECO PRIMARY KEY (COD),
	CONSTRAINT FK_COD_FUNC FOREIGN KEY (COD_FUNC) REFERENCES tb_funcionarios (COD)
)
	


