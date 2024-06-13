using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // vector o array
        string[] generos = new string[3] { "terror", "accion", "comedia"};

        // matriz 
        string[,] peliculas = new string[3, 3]
        {
            {"T1", "T2", "T3" },
            {"A1", "A2", "A3" },
            {"C1", "C2", "C3" },
        };

        string[,] peliculasAgregadas = new string[3, 3]; // matriz vacia

        private void Form1_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < generos.Length; i++)
            {
                comboBoxGeneros.Items.Add(generos[i]);
                comboBox3.Items.Add(generos[i]);
            }
        }

        private void comboBoxGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPeliculas.Items.Clear();
            int row = comboBoxGeneros.SelectedIndex;

            for(int col = 0; col < peliculas.GetLength(1); col++)
            {
                comboBoxPeliculas.Items.Add(peliculas[row, col]);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fila = comboBox3.SelectedIndex;

            for (int col = 0; col < peliculasAgregadas.GetLength(1); col++)
            {
                if (peliculasAgregadas[fila, col] != null)
                {
                    listBoxPeliculas.Items.Add(peliculasAgregadas[fila, col]);
                }
                else return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fila = comboBox3.SelectedIndex;
            string nuevaPelicula = textBox1.Text;

            for(int col = 0; col < peliculasAgregadas.GetLength(1); col++)
            {
                if (peliculasAgregadas[fila, col] == null)
                {
                    peliculasAgregadas[fila, col] = nuevaPelicula;
                    return;
                }
            }
        }
    }
}