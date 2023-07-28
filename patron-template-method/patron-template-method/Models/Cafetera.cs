using patron_estrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_estrategy.Models
{
    internal class Cafetera
    {
        private IPreparacionCafe _estrategia;

        public Cafetera(IPreparacionCafe estrategia)
        {
            _estrategia = estrategia;
        }

        public void PrepararCafe()
        {
            _estrategia.Preparar();
        }

        public void CambiarEstrategia(IPreparacionCafe estrategia)
        {
            this._estrategia = estrategia;
        }
    }
}
