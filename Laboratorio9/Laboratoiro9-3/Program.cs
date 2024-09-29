internal class Programa
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los lados de un triángulo para determinar su tipo.");

        double lado1, lado2, lado3;

        Console.WriteLine("Ingrese el valor del lado 1:");
        lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor del lado 2:");
        lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor del lado 3:");
        lado3 = Convert.ToDouble(Console.ReadLine());

        string tipoTriangulo = ClasificarTriangulo(lado1, lado2, lado3);
        Console.WriteLine(tipoTriangulo);
    }

    static string ClasificarTriangulo(double lado1, double lado2, double lado3)
    {
        // Verificar si los lados forman un triángulo
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "El triángulo es equilátero.";
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                return "El triángulo es isósceles.";
            }
            else
            {
                return "El triángulo es escaleno.";
            }
        }
        else
        {
            return "Los lados ingresados no forman un triángulo.";
        }
    }
}
