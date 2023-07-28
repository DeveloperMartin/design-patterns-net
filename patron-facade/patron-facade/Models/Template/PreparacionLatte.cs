using patron_abstract_factory.Models;
using patron_abstract_factory.Models.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_template_method.Models.Template
{
    internal class PreparacionLatte : PreparacionCafeTemplate
    {
        protected override AbstractCafeFactory CrearCafeFactory()
        {
            return new LatteFactory();
        }
    }
}
