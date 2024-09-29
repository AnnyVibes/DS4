using System.Reflection;

Module Laboratorio103
    Sub Main()
       
        Dim num1, num2 As Integer

        Console.WriteLine("Ingrese el primer número:")
        num1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese el segundo número:")
        num2 = Convert.ToInt32(Console.ReadLine())

        Dim resultado As Integer = num1 + num2
        Console.WriteLine("El resultado de la suma es: " & resultado)

        Console.ReadLine() 
    End Sub
End Module
