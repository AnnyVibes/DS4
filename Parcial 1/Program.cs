using System;

class Parcial1 
{
    static void Main()
    {
        Console.WriteLine("Ingresa un valor N de la matriz (debe ser un número par): ");
        int N = int.Parse(Console.ReadLine());

        if (N % 2 != 0)
        {
            Console.WriteLine("El número debe ser par.");
            return;
        }

        int[,] matriz = new int[N, N];

        Random random = new Random();
        for (int i = N / 2 - 1; i <= N / 2; i++)
        {
            for (int j = 1; j < N - 1; j++)
            {
                matriz[i, j] = random.Next(101, 201); 
            }
        }

        Console.WriteLine("Matriz creada:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        long producto = 1;
        for (int i = N / 2 - 1; i <= N / 2; i++)
        {
            for (int j = 1; j < N - 1; j++)
            {
                producto *= matriz[i, j];
            }
        }

       Console.WriteLine("Multiplicación de los valores distintos de cero: " + producto);
    }
}
