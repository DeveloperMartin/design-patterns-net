using patron_abstract_factory.Models.Factory;
using patron_abstract_factory.Models;
using patron_abstract_factory.Interfaces;

namespace patron_abstract_factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nos abstraemos de conocer su construccion ya que para eso esta la factory respectiva (americano factory y latte factory)
            //De esta forma desacoplamos el codigo y nos aislamos de los detalles de creacion de objetos. 
            // De esta forma nos permitimos trabajar con abstraccion (La interfaz ICafe y la fabrica abstracta) en lugar de clase concretas (CafeAmericano y CafeLatte).
            AbstractCafeFactory cafeFactory = new AmericanoFactory();
            ICafe cafe = cafeFactory.CrearCafe();
            Console.WriteLine($"{cafe.Descripcion} - Costo: ${cafe.Costo}");

            cafeFactory = new LatteFactory();
            cafe = cafeFactory.CrearCafe();
            Console.WriteLine($"{cafe.Descripcion} - Costo: ${cafe.Costo}");
        }
    }
}