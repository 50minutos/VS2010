Public Class PoneyMaldito
    Inherits CS.Poney

    Public Sub Atolar()
        Console.WriteLine("O Poney atolou")
    End Sub

    Public Overrides Sub Comer()
        Console.WriteLine("O Poney comeu com a pontinha dos dedos")
    End Sub
End Class
