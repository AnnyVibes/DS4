using System;

namespace Laboratorio3
{
    class CalculosMatematicos
    {
        // Método que realiza la operación (a + b) * (a - b)
        public static int Cal(int valor1, int valor2)
        {
            return (valor1 + valor2) * (valor1 - valor2);
        }
        // Método que calcula el área de un círculo dado su radio
        public static double CalculoArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        // Método que calcula el perímetro de un rectángulo dado los dos lados
        public static int CalculoPerimetroRectangulo(int lado1, int lado2)
        {
            return 2 * (lado1 + lado2);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Parte 1: Operación (a + b) * (a - b)
            int valor1, valor2, resultado;
            Console.Write("Introduce el primer valor: ");

            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo valor: ");

            valor2 = Convert.ToInt32(Console.ReadLine());
            resultado = CalculosMatematicos.Cal(valor1, valor2);
            Console.WriteLine("El resultado de la operación ({0} + {1}) * ({0} - {1}) es: {2}", valor1, valor2, resultado);
            // Parte 2: Cálculo del área de un círculo
            double radio, area;
            Console.Write("Introduce el radio del círculo: ");
            radio = Convert.ToDouble(Console.ReadLine());
            area = CalculosMatematicos.CalculoArea(radio);
            Console.WriteLine("El área de un círculo con radio {0} es: {1:F2}", radio, area
            // Parte 3: Cálculo del perímetro de un rectángulo
            int lado1, lado2, perimetro;
            Console.Write("Introduce el primer lado del rectángulo: ");
            lado1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo lado del rectángulo: ");
            lado2 = Convert.ToInt32(Console.ReadLine());
            perimetro = CalculosMatematicos.CalculoPerimetroRectangulo(lado1, lado2)
            Console.WriteLine("El perímetro del rectángulo con lados {0} y {1} es: {2}", lado1, lado2, perimetro);
        }
    }
}
