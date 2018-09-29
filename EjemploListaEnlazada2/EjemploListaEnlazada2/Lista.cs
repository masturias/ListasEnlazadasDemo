using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListaEnlazada2
{
    public class Lista
    {
        public Nodo primero;


        public Lista()
        {
            primero = null;
        }

        public void InsertarInicioLista(object pDato)
        {
            Nodo nuevo = new Nodo(pDato);
            nuevo.enlace = primero;
            primero = nuevo;
        }


        public Nodo buscarLista(object destino)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.enlace)
                if (destino.Equals(indice.Dato))  //(destino == indice.Dato) // 
                    return indice;
            return null;
        }


    }
}
