using System.Reflection;

Module Laboratorio104
    Sub Main()
        Try
            Console.WriteLine("Ingrese un número:")
            Dim numero As Integer = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("El número ingresado es: " & numero)
        Catch ex As Exception
            Console.WriteLine("Ocurrió un error: " & ex.Message)
        Finally
            Console.WriteLine("Fin del programa.")
        End Try
            Console.ReadLine() 
    End Sub
End Module
