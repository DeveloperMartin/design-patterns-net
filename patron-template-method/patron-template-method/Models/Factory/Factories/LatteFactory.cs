using patron_abstract_factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_abstract_factory.Models.Factory
{
    internal class LatteFactory : AbstractCafeFactory
    {
        public override ICafe CrearCafe()
        {
            return new CafeLatte();
        }
    }
}
