using patron_abstract_factory.Interfaces;
using patron_abstract_factory.Models.Factory;
using patron_abstract_factory.Models;
using patron_estrategy.Interfaces;

namespace patron_estrategy.Models.Preparaciones
{
    internal class PreparacionAmericano : IPreparacionCafe
    {
        public void Preparar()
        {
            AbstractCafeFactory cafeFactory = new AmericanoFactory();
            ICafe cafe = cafeFactory.CrearCafe(); //Repetimos codigo ESTO SE SOLUCIONA CON EL PROXIMO EL TEMPLATE METHOD
            Console.WriteLine($"{cafe.Descripcion} - Costo: ${cafe.Costo}"); //Repetimos codigo ESTO SE SOLUCIONA CON EL PROXIMO EL TEMPLATE METHOD
        }
    }
}
