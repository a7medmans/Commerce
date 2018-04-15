Module Module1
    Public Class load
        Overloads Sub Cost(ByVal s As Integer)
            Console.WriteLine("Cost of spike")
            Console.WriteLine(s)

        End Sub
        Overloads Sub Cost(ByVal m As Integer, ByVal n As String)
            Console.WriteLine("Cost of mono")
            Console.WriteLine(m & "    " & n)

        End Sub
        Overloads Sub Cost(ByVal t As Double)
            Console.WriteLine("Cost of tandem")
            Console.WriteLine(t)

        End Sub
    End Class

    Sub Main()

        Dim testobj As New load()
        Dim x As Integer = 400
        Dim y As Integer = 600
        Dim z As String = "mid"
        Dim f As Double = 500.45
        testobj.Cost(x)
        Console.WriteLine("*********************************************")
        testobj.Cost(y, z)
        Console.WriteLine("*********************************************")
        testobj.Cost(f)
        Console.ReadLine()
    End Sub

End Module
