using Laboratorio9_4;

internal class Programa
{
    private static void Main(string[] args)
    {
        Aleatorios aleatorio = new Aleatorios();

        int minimo = aleatorio.GenerarNumeroEntre(1, 10);
        int maximo = aleatorio.GenerarNumeroEntre(11, 20);

        Console.WriteLine($"El rango generado es de {minimo} a {maximo}.");

        int[] numerosNoRepetidos = aleatorio.GenerarArregloDeNumeros(minimo, maximo, 5);

        Console.WriteLine("Números aleatorios no repetidos generados: " + string.Join(", ", numerosNoRepetidos));
    }
}
