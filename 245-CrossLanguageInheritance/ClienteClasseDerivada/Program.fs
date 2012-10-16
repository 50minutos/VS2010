// Learn more about F# at http://fsharp.net
let poney = CS.Poney()
let poneyMaldito = VB.PoneyMaldito()

System.Console.WriteLine(poney.Acordar())
System.Console.WriteLine(poney.Comer())
System.Console.WriteLine(poney.Dormir())

System.Console.WriteLine()

System.Console.WriteLine(poneyMaldito.Acordar())
System.Console.WriteLine(poneyMaldito.Comer())
System.Console.WriteLine(poneyMaldito.Atolar())
System.Console.WriteLine(poneyMaldito.Dormir())

ignore (System.Console.ReadKey())