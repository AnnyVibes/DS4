namespace Laboratorio4
{
    // Problema 4-5
    internal class Contador
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el radio del circulo");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.Pow(radio, 2) * Math.PI;
            Console.WriteLine($"El area del circulo es: {area}");
        }
    }
}