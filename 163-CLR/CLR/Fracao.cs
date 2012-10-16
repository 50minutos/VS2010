using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedType(Format.Native)]
public struct Fracao : INullable
{
    private int numerador;
    public int Numerador
    {
        get { return this.numerador; }
        set
        {
            this.numerador = value;
            this.Simplificar();
        }
    }

    private int denominador;

    public int Denominador
    {
        get { return this.denominador; }
        set
        {
            this.denominador = value;
            this.Simplificar();
        }
    }

    private void Simplificar()
    {
        int mdc = this.CalcularMDC(); //usa o algoritmo de Euclides

        this.numerador /= mdc;
        this.denominador /= mdc;
    }

    private int CalcularMDC()
    {
        int n = Math.Abs(this.numerador);
        int d = Math.Abs(this.denominador);

        while (n != 0 && d != 0)
        {
            if (n > d)
                n %= d;
            else
                d %= n;
        }

        return n == 0 ? d : n;
    }
    
    public override string ToString()
    {
        return this.numerador == 0
            ? "0"
            : this.denominador == 1
            ? this.numerador.ToString()
            : String.Format("{0}/{1}", this.numerador, this.denominador);
    }

    public bool IsNull { get; private set; }

    public static Fracao Null
    {
        get
        {
            Fracao h = new Fracao();
            h.IsNull = true;
            return h;
        }
    }

    public static Fracao Parse(SqlString s)
    {
        String[] tmp = s.ToString().Split('/');

        Fracao f = Null;

        if (!s.IsNull)
        {
            f = new Fracao();

            f.numerador = Int32.Parse(tmp[0]);
            f.denominador = Int32.Parse(tmp[1]);
            
            f.Simplificar();
        } 
        
        return f;
    }

    public static Fracao Adicionar(Fracao f1, Fracao f2)
    {
        Fracao f = new Fracao()
        {
            numerador = f1.numerador * f2.denominador + f2.numerador * f1.denominador,
            denominador = f1.denominador * f2.denominador
        };

        f.Simplificar();

        return f;
    }

    public static Fracao Subtrair(Fracao f1, Fracao f2)
    {
        Fracao f = new Fracao()
        {
            numerador = f1.numerador * f2.denominador - f2.numerador * f1.denominador,
            denominador = f1.denominador * f2.denominador
        };

        f.Simplificar();

        return f;
    }

    public static Fracao Multiplicar(Fracao f1, Fracao f2)
    {
        Fracao f = new Fracao()
        {
            numerador = f1.numerador * f2.numerador,
            denominador = f1.denominador * f2.denominador
        };

        f.Simplificar();

        return f;
    }

    public static Fracao Dividir(Fracao f1, Fracao f2)
    {
        Fracao f = new Fracao()
        {
            numerador = f1.numerador * f2.denominador,
            denominador = f1.denominador * f2.numerador
        };

        f.Simplificar();

        return f;
    }

}

/*
-ou faço o deploy pelo VS2010 ou sigo os dois passos abaixo

--REGISTRAR O ASSEMBLY
CREATE ASSEMBLY CLR
AUTHORIZATION dbo
FROM 'C:\Users\Usuario\Desktop\VS2010\162-CLR\CLR\bin\Debug\CLR.dll'
WITH PERMISSION_SET = EXTERNAL_ACCESS --POR CAUSA DA PROCEDURE!!!

GO

--CRIAR O TIPO
CREATE TYPE dbo.Fracao
EXTERNAL NAME CLR.Fracao

GO

DECLARE @F1 Fracao = '22/10' --11/5
DECLARE @F2 Fracao = '1/7'

SELECT @F1.ToString() as '@F1', 
	@F2.ToString() as '@F2', 
	Fracao::Adicionar(@F1,@F2).ToString() as '@F1 + @f2', 
	Fracao::Subtrair(@F1,@F2).ToString() as '@F1 - @f2', 
	Fracao::Multiplicar(@F1,@F2).ToString() as '@F1 * @f2', 
	Fracao::Dividir(@F1,@F2).ToString() as '@F1 / @f2' 
*/
