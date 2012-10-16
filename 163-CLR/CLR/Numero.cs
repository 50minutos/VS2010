using System.Data.SqlTypes;
using System;

public partial class Numero
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlInt32 GerarNumeroAleatorio(Int32 x)
    {
        return new Random(x + DateTime.Now.Millisecond).Next(1, 11);
    }
};

//ACESSO = SAFE

/*
USE VS2010
 
SELECT CAST(RAND() * 100 AS INT) % 10 + 1

SELECT *, DBO.UDF_GERAR_ALEATORIO() AS 'NUMERO' 
FROM PESSOA

GO

CREATE FUNCTION UDF_GERAR_ALEATORIO()
RETURNS INT
AS
	BEGIN
		RETURN(4)
	END
GO

DROP FUNCTION UDF_GERAR_ALEATORIO

--CREATE FUNCTION UDF_GERAR_ALEATORIO()
--RETURNS INT
--AS
--	BEGIN
--		RETURN(CAST(RAND() * 100 AS INT) % 10 + 1)
--	END
--GO

GO

--POG
CREATE VIEW UV_NUMERO
AS
	SELECT (CAST(RAND() * 100 AS INT) % 10 + 1) AS 'NUMERO'
GO

SELECT * FROM UV_NUMERO

GO

CREATE FUNCTION UDF_GERAR_ALEATORIO()
RETURNS INT
AS
	BEGIN
		RETURN(SELECT * FROM UV_NUMERO)
	END
GO

SELECT DBO.UDF_GERAR_ALEATORIO()

SELECT *, DBO.UDF_GERAR_ALEATORIO() AS 'NUMERO' 
FROM PESSOA

--FIM DO POG

--PERMITIR A EXECUÇÃO DE CLR

EXEC sp_configure

EXEC sp_configure 'show advanced options', 1
RECONFIGURE
GO

EXEC sp_configure 'clr enabled', 1
RECONFIGURE
GO

EXEC sp_configure 'show advanced options', 0
RECONFIGURE
GO

--ou faço o deploy pelo VS2010 ou sigo os dois passos abaixo

--REGISTRAR O ASSEMBLY
CREATE ASSEMBLY CLR
AUTHORIZATION dbo
FROM 'C:\Users\Usuario\Desktop\VS2010\162-CLR\CLR\bin\Debug\CLR.dll'
WITH PERMISSION_SET = SAFE

--CRIAR A FUNÇÃO
CREATE FUNCTION dbo.GerarNumeroAleatorio(@x [int])
	RETURNS int 
	WITH EXECUTE AS CALLER
AS 
EXTERNAL NAME CLR.Numero.GerarNumeroAleatorio
GO

--CLR é o nome do assembly, Numero é a classe e GerarNumeroAleatorio é o método

SELECT DBO.GerarNumeroAleatorio()

SELECT *, DBO.GerarNumeroAleatorio(COD_PESSOA) AS 'NUMERO' 
FROM PESSOA a
*/
