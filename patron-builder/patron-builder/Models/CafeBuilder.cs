using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_builder.Models
{
    internal class CafeBuilder
    {
        private Cafe cafe = new Cafe();

        public CafeBuilder()
        {
            cafe.Descripcion = "Café simple";
            cafe.Costo = 1.0;
        }

        public CafeBuilder ConLeche()
        {
            cafe.Descripcion += ", con leche";
            cafe.Costo += 0.5;
            return this; //This hace referencia a la instancia actual de la clase y asi encadenar las llamadas a los metodos
        }

        public CafeBuilder ConAzucar()
        {
            cafe.Descripcion += ", con azúcar";
            cafe.Costo += 0.2;
            return this;
        }

        public Cafe Construir()
        {
            return cafe;
        }
    }
}
