using System;

class Programa
{
    static void Main()
    {
        double precioProducto, cantidadBillete, cambio;
        int metodoPago;
        string numeroTarjeta;

        // Solicitar el precio del producto hasta que sea válido
        do
        {
            Console.WriteLine("Por favor, introduzca el precio del producto (debe ser mayor a 0):");
            precioProducto = Convert.ToDouble(Console.ReadLine());
        } while (precioProducto <= 0);

        // Solicitar la forma de pago (1 = efectivo, 0 = tarjeta)
        do
        {
            Console.WriteLine("Indique la forma de pago: 1 para efectivo, 0 para tarjeta:");
            metodoPago = Convert.ToInt32(Console.ReadLine());
        } while (metodoPago != 0 && metodoPago != 1);

        // Si el pago es en efectivo
        if (metodoPago == 1)
        {
            Console.WriteLine("Ingrese la cantidad entregada en billetes:");
            cantidadBillete = Convert.ToDouble(Console.ReadLine());
            cambio = cantidadBillete - precioProducto;
            Console.WriteLine($"Total pagado: {precioProducto}, su cambio es: {cambio}");
        }
        // Si el pago es con tarjeta
        else if (metodoPago == 0)
        {
            do
            {
                Console.WriteLine("Introduzca el número de tarjeta (16 dígitos):");
                numeroTarjeta = Console.ReadLine();
            } while (numeroTarjeta.Length != 16);

            Console.WriteLine($"El número de tarjeta ingresado es válido.");
            Console.WriteLine($"Usted ha pagado {precioProducto} con la tarjeta terminada en {numeroTarjeta.Substring(12)}.");
        }
        else
        {
            Console.WriteLine("Transacción no válida.");
        }
    }
}
