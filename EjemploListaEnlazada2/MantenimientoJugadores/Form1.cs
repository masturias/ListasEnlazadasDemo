using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploListaEnlazada2;

namespace MantenimientoJugadores
{
    public partial class Form1 : Form
    {
        Lista miListaEstudiantes;
        public Form1()
        {
            InitializeComponent();
            //Instanciando mi lista de Jugares
            miListaEstudiantes = new Lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante miEstudiante = 
                                new Estudiante(textBox1.Text, 
                                            int.Parse(textBox2.Text), 
                                            textBox3.Text);
            if (miEstudiante.EstudianteValido())
            {
                miListaEstudiantes.InsertarInicioLista(miEstudiante);
            }
            else
            {
                foreach(string ErrorEstudiante in miEstudiante.Errores)
                {
                    MessageBox.Show(ErrorEstudiante);
                }
                 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estudiante miJugador;
            miJugador = (Estudiante)miListaEstudiantes.primero.Dato;
            label4.Text = miJugador.nombre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nodo MiNodo;
            Estudiante miEstudianteBuscado =
                               new Estudiante(int.Parse(textBox2.Text));
            MiNodo= miListaEstudiantes.buscarLista(miEstudianteBuscado);

            Estudiante miEstudianteEncontrado;
            miEstudianteEncontrado = (Estudiante)MiNodo.Dato;
            //textBox2.Text = miJugadorEncontrado.Punteo.ToString();
            textBox1.Text = miEstudianteEncontrado.nombre.ToString();
            textBox3.Text = miEstudianteEncontrado.Carrera.ToString();
        }
    }
}
