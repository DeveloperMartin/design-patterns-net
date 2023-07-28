namespace todo_mal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipoDeCafe = "americano";
            string cafe;
            double costo;

            if (tipoDeCafe == "americano")
            {
                cafe = "Café Americano";
                costo = 1.0;
                Console.WriteLine($"{cafe} - Costo: ${costo}");
            }
            else if (tipoDeCafe == "latte")
            {
                cafe = "Café Latte";
                costo = 1.5;
                Console.WriteLine($"{cafe} - Costo: ${costo}");
            }
            else
            {
                Console.WriteLine("Tipo de café desconocido");
            }

            tipoDeCafe = "latte";

            if (tipoDeCafe == "americano")
            {
                cafe = "Café Americano";
                costo = 1.0;
                Console.WriteLine($"{cafe} - Costo: ${costo}");
            }
            else if (tipoDeCafe == "latte")
            {
                cafe = "Café Latte";
                costo = 1.5;
                Console.WriteLine($"{cafe} - Costo: ${costo}");
            }
            else
            {
                Console.WriteLine("Tipo de café desconocido");
            }
        }
    }
}