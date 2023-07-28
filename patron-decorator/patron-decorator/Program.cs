using patron_decorator.Interfaces;
using patron_decorator.Models.Cafe;

namespace patron_decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICafe cafe = new CafeSimple();
            cafe = new CafeConLeche(cafe);
            cafe = new CafeConAzucar(cafe);

            Console.WriteLine($"{cafe.ObtenerDescripcion()} - Costo: ${cafe.ObtenerCosto()}");
        }
    }
}