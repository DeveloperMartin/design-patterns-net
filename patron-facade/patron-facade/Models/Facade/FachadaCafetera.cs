using patron_estrategy.Models.Preparaciones;
using patron_estrategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_facade.Models.Facade
{
    internal class FachadaCafetera
    {
        private Cafetera _cafetera;

        public FachadaCafetera(Cafetera cafetera)
        {
            _cafetera = cafetera;
        }

        public void PrepararCafeAmericano()
        {
            _cafetera.CambiarEstrategia(new PreparacionAmericano());
            _cafetera.PrepararCafe();
        }

        public void PrepararCafeLatte()
        {
            _cafetera.CambiarEstrategia(new PreparacionLatte());
            _cafetera.PrepararCafe();
        }
    }
}
