using Compilador.Cache;
using Compilador.Transversal;
using Compilador.Transversal.Componente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Compilador : Form
    {
        public Compilador()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonConsola_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonConsola.Checked)
            {
                groupBox1.Show();
                groupBox2.Hide();
            }
        }

        private void radioButtonArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonArchivo.Checked)
            {
                groupBox2.Show();
                groupBox1.Hide();
            }
        }

        private void buttonSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ProgramaFuente cache = ProgramaFuente.obtenerProgramaFuente();

            textBoxResultado.Text = String.Empty;
            procesarTexto();

            foreach (Linea linea in cache.obtenerLineas())
            {
                textBoxResultado.AddLine(linea.obtenerNumeroLinea() + " >> " + linea.obtenerContenido());
            }

            AnalizadorLexico.AnalizadorLexico analizadorLexico = AnalizadorLexico.AnalizadorLexico.crear();

            ComponenteLexico componente = null;

            do
            {
                componente = analizadorLexico.devolverComponente();

                MessageBox.Show(componente.ToString());
            }
            while (!componente.obtenerCategoria().Equals(Categoria.FIN_ARCHIVO));
        }

        private void procesarTexto()
        {
            ProgramaFuente cache = ProgramaFuente.obtenerProgramaFuente();
            cache.inicializar();

            if (radioButtonConsola.Checked)
            {
                foreach (String valorLinea in textBoxConsola.Lines)
                {
                    cache.agregarLinea(valorLinea);
                }

                cache.agregarLinea(CategoriaGramatical.FIN_ARCHIVO);
            }
            else if (radioButtonArchivo.Checked)
            {
                if (label1.Text != "")
                {
                    string[] lines;

                    using (StreamReader sr = new StreamReader(label1.Text))
                    {
                        String file = sr.ReadToEnd();
                        lines = file.Split(new String[] {System.Environment.NewLine}, StringSplitOptions.None);
                    }
                    foreach (String valorLinea in lines)
                    {
                        cache.agregarLinea(valorLinea);
                    }
                    cache.agregarLinea(CategoriaGramatical.FIN_ARCHIVO);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpiarEntrada_Click(object sender, EventArgs e)
        {
            textBoxConsola.Clear();
        }

        private void buttonLimpiarSalida_Click(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
        }
    }
    public static class WinFormsExtensions
    {
        public static void AddLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText("\r\n" + value);
        }
    }
}
