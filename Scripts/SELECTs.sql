

SELECT * FROM DBSK002..Tb_Usuarios

SELECT * FROM DBSK002..Tb_Racas

--UPDATE DBSK001..Tb_Cargos set Cargo = 'Nenhum' where cod = 1

SELECT * FROM DBSK002..tb_UserDefinitivo

SELECT * FROM DBSK002..tb_Enderecos

SELECT * FROM DBSK002..Tb_Contatos

SELECT * FROM DBSK002..Tb_TipoContatos

SELECT U.COD,U.LOGIN from Tb_Usuarios as U
INNER JOIN tb_UserDefinitivo as F 
on U.COD != F.COD_USUARIO
where U.ATIVO = 1 and U.TIPOUSER != 'A'

SELECT U.COD,U.LOGIN from Tb_Usuarios as U INNER JOIN tb_UserDefinitivo as F on U.COD != F.COD_USUARIO where U.TIPOUSER != 'A' and U.ATIVO = 1