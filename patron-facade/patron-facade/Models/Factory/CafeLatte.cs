using patron_abstract_factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_abstract_factory.Models
{
    internal class CafeLatte : ICafe
    {
        public string Descripcion => "Café Latte";
        public double Costo => 1.5;
    }
}
