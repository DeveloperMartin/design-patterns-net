using patron_abstract_factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_abstract_factory.Models
{
    internal abstract class AbstractCafeFactory
    {
        public abstract ICafe CrearCafe();
    }
}
