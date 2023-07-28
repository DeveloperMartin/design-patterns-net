using patron_decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_decorator.Models.Cafe
{
    internal class CafeSimple : ICafe
    {
        public double ObtenerCosto()
        {
            return 1.0;
        }

        public string ObtenerDescripcion()
        {
            return "Cafe simple";
        }
    }
}
