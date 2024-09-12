namespace Laboratorio5
{
    //Problema 5-1
    internal class Problema5_1
    {
        private int[] sueldos;
        public void Cargar()
        {
            sueldos = new int[5]; // Array de 5 elementos, no 6
            for (int f = 0; f < 5; f++) // Índices empiezan en 0
            {
                Console.Write("Ingrese sueldo del operario " + (f + 1) + ": ");
                string linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Los 5 sueldos de los operarios:");
            for (int f = 0; f < 5; f++) // Índices empiezan en 0
            {
                Console.WriteLine("[" + sueldos[f] + "]");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Problema5_1 pv = new Problema5_1();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}