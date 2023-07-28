using patron_estrategy.Models.Preparaciones;
using patron_estrategy.Models;

namespace patron_template_method
{
    internal class Program
    {
        // El template method define el esqueleto de un algoritmo en una operacion.
        // Llevando algunos pasos a las subclases. De esa manera se pueden redefinir
        // ciertos pasos de un algoritmo sin cambiar la estructura del mismo.
        static void Main(string[] args)
        {
            Cafetera cafetera = new Cafetera(new PreparacionAmericano());
            cafetera.PrepararCafe();

            cafetera.CambiarEstrategia(new PreparacionLatte());
            cafetera.PrepararCafe();
        }
    }
}