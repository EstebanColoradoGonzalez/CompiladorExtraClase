using Compilador.Source.AnalizadorLexico;
using Compilador.src.cache;
using Compilador.src.transversal.componentes;
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

        private void limpiarEntradaConsolaButton_Click(object sender, EventArgs e)
        {
            consolaTextBox.Clear();
        }

        private void limpiarSalidaConsolaButton_Click(object sender, EventArgs e)
        {
            salidaConsolaTextBox.Clear();
        }

        private void limpiarSalidaArchivoButton_Click(object sender, EventArgs e)
        {
            salidaArchivoTextBox.Clear();
        }

        private void compilarConsolaButton_Click(object sender, EventArgs e)
        {
            compilarConsola();
        }

        private void compilarConsola()
        {
            try
            {
                ProgramaFuente cache = ProgramaFuente.obtenerProgramaFuente();

                salidaConsolaTextBox.Text = String.Empty;
                procesarTextoConsola();

                foreach (Linea linea in cache.obtenerLineas())
                {
                    salidaConsolaTextBox.AddLine(linea.obtenerNumeroLinea() + " >> " + linea.obtenerContenido());
                }

                AnalizadorLexico analizadorLexico = AnalizadorLexico.crear();

                ComponenteLexico componente = null;

                do
                {
                    componente = analizadorLexico.devolverComponente();

                    MessageBox.Show(componente.ToString());
                }
                while (!componente.obtenerCategoria().Equals(Categoria.FIN_ARCHIVO));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void limpiarCompilarArchivoButton_Click(object sender, EventArgs e)
        {
            compilarArchivo();
        }

        private void compilarArchivo()
        {
            try
            {
                ProgramaFuente cache = ProgramaFuente.obtenerProgramaFuente();

                salidaArchivoTextBox.Text = String.Empty;
                procesarTextoArchivo();

                foreach (Linea linea in cache.obtenerLineas())
                {
                    salidaArchivoTextBox.AddLine(linea.obtenerNumeroLinea() + " >> " + linea.obtenerContenido());
                }

                AnalizadorLexico analizadorLexico = AnalizadorLexico.crear();

                ComponenteLexico componente = null;

                do
                {
                    componente = analizadorLexico.devolverComponente();

                    MessageBox.Show(componente.ToString());
                }
                while (!componente.obtenerCategoria().Equals(Categoria.FIN_ARCHIVO));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void seleccionarArchivoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos de Texto (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label.Text = openFileDialog1.FileName;
            }
        }

        private void procesarTextoConsola()
        {
            ProgramaFuente cache = ProgramaFuente.obtenerProgramaFuente();
            cache.inicializar();

            foreach (String valorLinea in consolaTextBox.Lines)
            {
                cache.agregarLinea(valorLinea);
            }

            cache.agregarLinea(CategoriaGramatical.FIN_ARCHIVO);
        }

        private void procesarTextoArchivo()
        {
            ProgramaFuente cache = ProgramaFuente.obtenerProgramaFuente();
            cache.inicializar();

            if (label.Text != "")
            {
                string[] lines;

                using (StreamReader sr = new StreamReader(label.Text))
                {
                    String file = sr.ReadToEnd();
                    lines = file.Split(new String[] { System.Environment.NewLine }, StringSplitOptions.None);
                }
                foreach (String valorLinea in lines)
                {
                    cache.agregarLinea(valorLinea);
                }
                cache.agregarLinea(CategoriaGramatical.FIN_ARCHIVO);
            }
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
