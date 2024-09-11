namespace Laboratorio4
{
    // Problema 4-4
    internal class Contador
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota del estudiante");
            float score = float.Parse(Console.ReadLine());
            if (score >= 70)
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota es {score} ha aprobado");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota es {score} ha reprobado, debe repetir");
            }
        }
    }
}