using patron_builder.Models;

namespace patron_builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cafeBuilder = new CafeBuilder();
            var cafe = cafeBuilder.ConLeche().ConAzucar().ConLeche().Construir();

            Console.WriteLine($"{cafe.Descripcion} - Costo: ${cafe.Costo}");
        }
    }
}