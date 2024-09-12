namespace Laboratorio5
{
    //Problema 5-3
    internal class Problema5_3
    {
        private string[] frutas = { "manzana", "plátano", "naranja" };

        public void MostrarFrutas()
        {
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }

        static void Main(string[] args)
        {
            Problema5_3 problema = new Problema5_3();
            problema.MostrarFrutas();
            Console.ReadKey();
        }
    }
}
