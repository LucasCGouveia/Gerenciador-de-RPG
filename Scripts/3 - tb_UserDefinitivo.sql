USE [DBSK002]
GO

CREATE TABLE tb_UserDefinitivo(
	COD [int] identity(1,1) NOT NULL,
	COD_USUARIO int         NULL,
	DataInclusao varchar(20) NOT NULL,
	NOME varchar(60)        NOT NULL,
	Nascimento varchar(20)  NOT NULL,
	RG varchar(20)          NULL,
	CPF varchar(20)         NULL,
	DataAdmissao varchar(30)       NULL,
	COD_RACA int			NOT NULL,
	SALARIO varchar(20)		NOT NULL,
	ATIVO int               NOT NULL,
	CONSTRAINT PK_COD_FUNC PRIMARY KEY (COD),
	CONSTRAINT FK_COD_USUARIO FOREIGN KEY (COD_USUARIO) REFERENCES tb_usuarios (COD),
	CONSTRAINT COD_Cargo FOREIGN KEY (COD_RACA) REFERENCES tb_Racas (COD),
 
)

--select * from tb_Funcionarios

USE [DBSK002]
GO

INSERT INTO [dbo].[tb_UserDefinitivo]
           ([COD_USUARIO],[DataInclusao],[NOME],[Nascimento],[RG],[CPF],[DataAdmissao],[COD_RACA],[SALARIO],[ATIVO])
     VALUES(2,GETDATE(),'Admin','12/10/1997','','','',1,'',1)

	


