using patron_decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_decorator.Models.Cafe
{
    internal class CafeConLeche : DecoradorCafe
    {
        public CafeConLeche(ICafe cafe) : base(cafe)
        {
        }

        public override string ObtenerDescripcion()
        {
            return cafeDecorado.ObtenerDescripcion() + ", con leche";
        }

        public override double ObtenerCosto()
        {
            return Math.Round(base.ObtenerCosto() + 0.4, 3);
        }
    }
}
