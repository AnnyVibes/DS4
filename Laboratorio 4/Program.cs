namespace Laboratorio4
{
    //Problema 4-1
    internal class Contador
    {
        // Método para obtener el dato de n del usuario
        static void Main()
        {
            Console.Write("Ingrese un número entero: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}