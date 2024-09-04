namespace Laboratorio3
{
    //Problema1
    class CalculosMatematicos
    {
        // Método que realiza la operación (a + b) * (a - b)
        public static int Cal(int valor1, int valor2)
        {
            return (valor1 + valor2) * (valor1 - valor2);
        }
        class Program
        {
            public static void Main(string[] args)
            {
                int valor1, valor2, resultado;
                Console.Write("Introduce el primer valor: ");
                valor1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce el segundo valor: ");
                valor2 = Convert.ToInt32(Console.ReadLine());
                resultado = CalculosMatematicos.Cal(valor1, valor2);
                Console.WriteLine("El resultado de la operación ({0} + {1}) * ({0} - {1}) es: {2}", valor1, valor2, resultado);
            }
        }
    }
}