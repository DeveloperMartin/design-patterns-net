using patron_decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_decorator.Models.Cafe
{
    internal class CafeConAzucar : DecoradorCafe
    {
        // base se utiliza para acceder a miembros (metodos, propiedades) declarados en la clase base desde la clase derivada.
        public CafeConAzucar(ICafe cafe) : base(cafe) { } 

        public override string ObtenerDescripcion()
        {
            return cafeDecorado.ObtenerDescripcion().Contains("azucar") ? base.ObtenerDescripcion() : cafeDecorado.ObtenerDescripcion() + ", con azucar";
        }

        public override double ObtenerCosto()
        {
            return Math.Round(base.ObtenerCosto() + 0.2, 3);
        }
    }
}
