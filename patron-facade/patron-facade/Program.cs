using patron_estrategy.Models.Preparaciones;
using patron_estrategy.Models;
using patron_facade.Models.Facade;

namespace patron_facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cafetera cafetera = new Cafetera(new PreparacionAmericano());
            FachadaCafetera fachada = new FachadaCafetera(cafetera);

            fachada.PrepararCafeLatte();
            fachada.PrepararCafeAmericano();
        }
    }
}