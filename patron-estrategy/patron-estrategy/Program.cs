using patron_estrategy.Models;
using patron_estrategy.Models.Preparaciones;

namespace patron_estrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El patrón Strategy es útil cuando necesitamos definir una familia de algoritmos y hacerlos intercambiables en tiempo de ejecución.
            //Este patrón puede ayudar a encapsular el comportamiento que varía entre las clases.
            Cafetera cafetera = new Cafetera(new PreparacionAmericano());
            cafetera.PrepararCafe();

            cafetera.CambiarEstrategia(new PreparacionLatte()); //uso del estrategy
            cafetera.PrepararCafe();
        }
    }
}