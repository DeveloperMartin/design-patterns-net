using patron_abstract_factory.Interfaces;
using patron_abstract_factory.Models.Factory;
using patron_abstract_factory.Models;
using patron_estrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_template_method.Models.Template
{
    //Tiene que ser abstracta
    internal abstract class PreparacionCafeTemplate : IPreparacionCafe
    {
        public void Preparar()
        {
            AbstractCafeFactory cafeFactory = CrearCafeFactory();
            ICafe cafe = cafeFactory.CrearCafe(); 
            Console.WriteLine($"{cafe.Descripcion} - Costo: ${cafe.Costo}"); 
        }

        protected abstract AbstractCafeFactory CrearCafeFactory();
    }
}
