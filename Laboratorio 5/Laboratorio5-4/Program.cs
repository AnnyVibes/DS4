namespace Laboratorio5
{
    // Problema 5-4
    internal class Problema5_4
    {
        private List<int> calificaciones = new List<int> { 85, 90, 78, 92, 88 };
        public void CalcularPromedio()
        {
            int suma = 0;
            foreach (int calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedio = suma / (double)calificaciones.Count;
            Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
        }

        static void Main(string[] args)
        {
            Problema5_4 problema = new Problema5_4();
            problema.CalcularPromedio();
            Console.ReadKey();
        }
    }
}