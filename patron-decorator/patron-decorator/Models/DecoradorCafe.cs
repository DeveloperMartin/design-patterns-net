using patron_decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_decorator.Models
{
    //clase abstracta
    internal abstract class DecoradorCafe : ICafe
    {
        protected ICafe cafeDecorado; //Permite el acceso desde la misma clase y de las clases que la hereden, es decir cualquier subclase.
        public DecoradorCafe(ICafe cafe)
        {
            cafeDecorado = cafe;
        }

        // Se le pone virtual se usa para modificar la declaracion de metodo, propiedad, indice o evento.
        // Y permitir que sea anulada en una clase derivada
        // Esto se hace utilizando la palabra clave override. 
        public virtual string ObtenerDescripcion() 
        {
            return cafeDecorado.ObtenerDescripcion();
        }
        public virtual double ObtenerCosto()
        {
            return cafeDecorado.ObtenerCosto();
        }
    }
}
