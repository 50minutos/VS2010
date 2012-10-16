Module Module1

    Sub Main()

        Dim nomes As String() = {"agnaldo", "marcelinho", "leandro", "felipe", "flávio", "rafael"}

        Dim xml As XElement = <nomes>
                                  <%= From x In nomes
                                      Select <nome>
                                                 <%= x %>
                                             </nome> %>
                              </nomes>

        Console.WriteLine(xml)

        Console.ReadKey()
    End Sub

End Module
