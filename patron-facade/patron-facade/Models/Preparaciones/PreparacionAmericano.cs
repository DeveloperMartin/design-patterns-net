using patron_abstract_factory.Interfaces;
using patron_abstract_factory.Models.Factory;
using patron_abstract_factory.Models;
using patron_estrategy.Interfaces;
using patron_template_method.Models.Template;

namespace patron_estrategy.Models.Preparaciones
{
    internal class PreparacionAmericano : PreparacionCafeTemplate
    {
        protected override AbstractCafeFactory CrearCafeFactory()
        {
           return  new AmericanoFactory();
        }
    }
}
