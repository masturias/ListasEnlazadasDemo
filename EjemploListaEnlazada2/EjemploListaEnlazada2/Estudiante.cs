﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListaEnlazada2
{
    public class Estudiante
    {
        public string nombre;
        public int Punteo;
        public string Carrera;

        public List<string> Errores { get; private set; }
        public Estudiante()
        {
            nombre = "";
            Punteo = 0;
            Carrera = "" ;
        }

        public Estudiante(string pNombre, int pPunteo, string pCarrera)
        {
            nombre = pNombre;
            Punteo = pPunteo;
            Carrera = pCarrera;
        }


        public Estudiante(string pNombre)
        {
            nombre = pNombre;
            Punteo = 0;
            Carrera = "";
        }

        public Estudiante(int pPunteo)
        {
            nombre = "";
            Punteo = pPunteo;
            Carrera = "";
        }

        public override bool Equals(Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }
 
            Estudiante EstudianteBuscado;
            EstudianteBuscado = (Estudiante)obj;

            // Return true if the fields match:
            return (this.Punteo== EstudianteBuscado.Punteo);
        }

        public bool EstudianteValido()
        {
            Errores = new List<string>();

            var valido = true;
        
            if (string.IsNullOrWhiteSpace(this.nombre))
            {
               Errores.Add("El nombre del estudiante es requerido");
                valido = false;
            }

            if (this.Punteo > 100)
            {
                Errores.Add("El punteo del estudiante no puede ser mayor a 100");
                valido = false;
            }

            if (this.Punteo < 0)
            {
                Errores.Add("El punteo del estudiante no puede ser menor a 0");
                valido = false;
            }
            
            if (string.IsNullOrWhiteSpace(this.Carrera))
            {
                Errores.Add("La carrera del estudiante es requerida");
                valido = false;
            }
            return valido;
        }

    }
}
