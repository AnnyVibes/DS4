namespace Laboratorio2{
class Program
{
    public static void Sumar(int valor1, int valor2)
    {
        int variableLocal = valor2; // declarando variable local variableLocal
        Console.WriteLine(variableLocal); // Imprime el resultado de la suma 
    }
    private static void Main(string[] args)
    {
        Client client = new Client();
            client.firstname = "Anllelina";
            client.lastname = "Varcasia";
            client.age = 18;
            client.Id = 1;
            Console.WriteLine(client.GetFullName());
        Sumar(2, 4);
    }
}

    class Client
    {
        public int Id { set; get; }
        public string firstname { set; get; }

        public string lastname { set; get; }

        public ushort age { set; get; }

        public string GetFullName()
        {
            return firstname + " " + lastname;
        }
    }

}

