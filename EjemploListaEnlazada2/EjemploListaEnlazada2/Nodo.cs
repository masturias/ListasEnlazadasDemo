using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListaEnlazada2
{
    public class Nodo
    {
        public Nodo enlace;
        public object Dato;

        public Nodo()
        {
            enlace = null;
            Dato = null;
        }

        public Nodo(object pDato)
        {
            enlace = null;
            Dato = pDato;
        }
    }
}
