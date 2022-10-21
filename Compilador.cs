using Compilador.src.analizadorsintactico;
using Compilador.src.cache;
using Compilador.src.manejadorerrores;
using Compilador.src.transversal.componentes;
using Compilador.src.transversal.tablas;
using System;
using System.IO;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Compilador : Form
    {
        public Compilador()
        {
            GestorErrores.reiniciar();
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

                AnalizadorSintactico analizadorSintactico = new AnalizadorSintactico();

                analizadorSintactico.analizar();

                /*AnalizadorLexico analizadorLexico = AnalizadorLexico.crear();

                ComponenteLexico componente = null;

                do
                {
                    componente = analizadorLexico.devolverComponente();

                    MessageBox.Show(componente.ToString());
                }
                while (!componente.obtenerCategoria().Equals(Categoria.FIN_ARCHIVO));*/
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

                AnalizadorSintactico analizadorSintactico = new AnalizadorSintactico();

                analizadorSintactico.analizar();

                /*AnalizadorLexico analizadorLexico = AnalizadorLexico.crear();

                ComponenteLexico componente = null;

                do
                {
                    componente = analizadorLexico.devolverComponente();

                    MessageBox.Show(componente.ToString());
                }
                while (!componente.obtenerCategoria().Equals(Categoria.FIN_ARCHIVO));*/
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

        private void tablaSimbolosButton_Click(object sender, EventArgs e)
        {
            tablaSimboloGroupBox.Show();
            tablaLiteralGroupBox.Hide();
            tablaDummyGroupBox.Hide();
            tablaPalabraReservadaGroupBox.Hide();

            limpiarTabla(simbolosDataGridView);
            llenarTablaSimbolos();
        }

        private void llenarTablaSimbolos()
        {
            var tabla = TablaMaestra.obtenerComponente(Tipo.SIMBOLO);

            foreach (ComponenteLexico componente in tabla)
            {
                adicionarCeldaATablaSimbolos(componente.obtenerNumeroLinea(), componente.obtenerPosicionInicial(), componente.obtenerPosicionFinal(), componente.obtenerCategoria(), componente.obtenerLexema());
            }

            autocompletarColumnas(simbolosDataGridView, 5);
        }

        private void adicionarCeldaATablaSimbolos(int numeroLinea, int posicionInicial, int posicionFinal, Categoria categoria, string lexema)
        {
            int numero = simbolosDataGridView.Rows.Add();

            simbolosDataGridView.Rows[numero].Cells[0].Value = numeroLinea.ToString();
            simbolosDataGridView.Rows[numero].Cells[1].Value = posicionInicial.ToString();
            simbolosDataGridView.Rows[numero].Cells[2].Value = posicionFinal.ToString();
            simbolosDataGridView.Rows[numero].Cells[3].Value = categoria;
            simbolosDataGridView.Rows[numero].Cells[4].Value = lexema;
        }

        private void tablaLiteralesButton_Click(object sender, EventArgs e)
        {
            tablaSimboloGroupBox.Hide();
            tablaLiteralGroupBox.Show();
            tablaDummyGroupBox.Hide();
            tablaPalabraReservadaGroupBox.Hide();

            limpiarTabla(literalesDataGridView);
            llenarTablaLiterales();
        }

        private void llenarTablaLiterales()
        {
            var tabla = TablaMaestra.obtenerComponente(Tipo.LITERAL);

            foreach (ComponenteLexico componente in tabla)
            {
                adicionarCeldaATablaLiterales(componente.obtenerNumeroLinea(), componente.obtenerPosicionInicial(), componente.obtenerPosicionFinal(), componente.obtenerCategoria(), componente.obtenerLexema());
            }

            autocompletarColumnas(literalesDataGridView, 5);
        }

        private void adicionarCeldaATablaLiterales(int numeroLinea, int posicionInicial, int posicionFinal, Categoria categoria, string lexema)
        {
            int numero = literalesDataGridView.Rows.Add();

            literalesDataGridView.Rows[numero].Cells[0].Value = numeroLinea.ToString();
            literalesDataGridView.Rows[numero].Cells[1].Value = posicionInicial.ToString();
            literalesDataGridView.Rows[numero].Cells[2].Value = posicionFinal.ToString();
            literalesDataGridView.Rows[numero].Cells[3].Value = categoria;
            literalesDataGridView.Rows[numero].Cells[4].Value = lexema;
        }

        private void tablaDummiesButton_Click(object sender, EventArgs e)
        {
            tablaSimboloGroupBox.Hide();
            tablaLiteralGroupBox.Hide();
            tablaDummyGroupBox.Show();
            tablaPalabraReservadaGroupBox.Hide();

            limpiarTabla(dummiesDataGridView);
            llenarTablaDummies();
        }

        private void llenarTablaDummies()
        {
            var tabla = TablaMaestra.obtenerComponente(Tipo.DUMMY);

            foreach (ComponenteLexico componente in tabla)
            {
                adicionarCeldaATablaDummies(componente.obtenerNumeroLinea(), componente.obtenerPosicionInicial(), componente.obtenerPosicionFinal(), componente.obtenerCategoria(), componente.obtenerLexema());
            }

            autocompletarColumnas(dummiesDataGridView, 5);
        }

        private void adicionarCeldaATablaDummies(int numeroLinea, int posicionInicial, int posicionFinal, Categoria categoria, string lexema)
        {
            int numero = dummiesDataGridView.Rows.Add();

            dummiesDataGridView.Rows[numero].Cells[0].Value = numeroLinea.ToString();
            dummiesDataGridView.Rows[numero].Cells[1].Value = posicionInicial.ToString();
            dummiesDataGridView.Rows[numero].Cells[2].Value = posicionFinal.ToString();
            dummiesDataGridView.Rows[numero].Cells[3].Value = categoria;
            dummiesDataGridView.Rows[numero].Cells[4].Value = lexema;
        }

        private void tablaPalabrasReservadasButton_Click(object sender, EventArgs e)
        {
            tablaSimboloGroupBox.Hide();
            tablaLiteralGroupBox.Hide();
            tablaDummyGroupBox.Hide();
            tablaPalabraReservadaGroupBox.Show();

            limpiarTabla(palabrasReservadasDataGridView);
            llenarTablaPalabrasReservadas();
        }

        private void llenarTablaPalabrasReservadas()
        {
            var tabla = TablaMaestra.obtenerComponente(Tipo.PALABRA_RESERVADA);

            foreach (ComponenteLexico componente in tabla)
            {
                adicionarCeldaATablaPalabrasReservadas(componente.obtenerNumeroLinea(), componente.obtenerPosicionInicial(), componente.obtenerPosicionFinal(), componente.obtenerCategoria(), componente.obtenerLexema());
            }

            autocompletarColumnas(palabrasReservadasDataGridView, 5);
        }

        private void adicionarCeldaATablaPalabrasReservadas(int numeroLinea, int posicionInicial, int posicionFinal, Categoria categoria, string lexema)
        {
            int numero = palabrasReservadasDataGridView.Rows.Add();

            palabrasReservadasDataGridView.Rows[numero].Cells[0].Value = numeroLinea.ToString();
            palabrasReservadasDataGridView.Rows[numero].Cells[1].Value = posicionInicial.ToString();
            palabrasReservadasDataGridView.Rows[numero].Cells[2].Value = posicionFinal.ToString();
            palabrasReservadasDataGridView.Rows[numero].Cells[3].Value = categoria;
            palabrasReservadasDataGridView.Rows[numero].Cells[4].Value = lexema;
        }

        private void tablaErroresLexicosButton_Click(object sender, EventArgs e)
        {
            tablaErroresLexicosGroupBox.Show();
            tablaErroresSemanticosGroupBox.Hide();
            tablaErroresSintacticosGroupBox.Hide();

            limpiarTabla(erroresLexicosDataGridView);
            llenarTablaErroresLexicos();
        }

        private void llenarTablaErroresLexicos()
        {
            var tabla = GestorErrores.obtenerErrores(TipoError.LEXICO);

            foreach (Error error in tabla)
            {
                adicionarCeldaATablaErroresLexicos(error.getNumeroLinea(), error.getPosicionInicial(), error.getPosicionFinal(), error.getFalla(), error.getCausa(), error.getSolucion());
            }

            autocompletarColumnas(erroresLexicosDataGridView, 6);
        }

        private void adicionarCeldaATablaErroresLexicos(int numeroLinea, int posicionInicial, int posicionFinal, string falla, string causa, string solucion)
        {
            int numero = erroresLexicosDataGridView.Rows.Add();

            erroresLexicosDataGridView.Rows[numero].Cells[0].Value = numeroLinea.ToString();
            erroresLexicosDataGridView.Rows[numero].Cells[1].Value = posicionInicial.ToString();
            erroresLexicosDataGridView.Rows[numero].Cells[2].Value = posicionFinal.ToString();
            erroresLexicosDataGridView.Rows[numero].Cells[3].Value = falla as String;
            erroresLexicosDataGridView.Rows[numero].Cells[4].Value = causa as String;
            erroresLexicosDataGridView.Rows[numero].Cells[5].Value = solucion as String;
        }

        private void tablaErroresSemanticosButton_Click(object sender, EventArgs e)
        {
            tablaErroresLexicosGroupBox.Hide();
            tablaErroresSemanticosGroupBox.Show();
            tablaErroresSintacticosGroupBox.Hide();

            limpiarTabla(erroresSemanticosDataGridView);
            llenarTablaErroresSemanticos();
        }

        private void llenarTablaErroresSemanticos()
        {
            var tabla = GestorErrores.obtenerErrores(TipoError.LEXICO);

            foreach (Error error in tabla)
            {
                adicionarCeldaATablaErroresSemanticos(error.getNumeroLinea(), error.getPosicionInicial(), error.getPosicionFinal(), error.getFalla(), error.getCausa(), error.getSolucion());
            }

            autocompletarColumnas(erroresSemanticosDataGridView, 6);
        }

        private void adicionarCeldaATablaErroresSemanticos(int numeroLinea, int posicionInicial, int posicionFinal, string falla, string causa, string solucion)
        {
            int numero = erroresSemanticosDataGridView.Rows.Add();

            erroresSemanticosDataGridView.Rows[numero].Cells[0].Value = numeroLinea.ToString();
            erroresSemanticosDataGridView.Rows[numero].Cells[1].Value = posicionInicial.ToString();
            erroresSemanticosDataGridView.Rows[numero].Cells[2].Value = posicionFinal.ToString();
            erroresSemanticosDataGridView.Rows[numero].Cells[3].Value = falla as String;
            erroresSemanticosDataGridView.Rows[numero].Cells[4].Value = causa as String;
            erroresSemanticosDataGridView.Rows[numero].Cells[5].Value = solucion as String;
        }

        private void tablaErroresSintacticosButton_Click(object sender, EventArgs e)
        {
            tablaErroresLexicosGroupBox.Hide();
            tablaErroresSemanticosGroupBox.Hide();
            tablaErroresSintacticosGroupBox.Show();

            limpiarTabla(erroresSintacticosDataGridView);
            llenarTablaErroresSintacticos();
        }

        private void llenarTablaErroresSintacticos()
        {
            var tabla = GestorErrores.obtenerErrores(TipoError.LEXICO);

            foreach (Error error in tabla)
            {
                adicionarCeldaATablaErroresSintacticos(error.getNumeroLinea(), error.getPosicionInicial(), error.getPosicionFinal(), error.getFalla(), error.getCausa(), error.getSolucion());
            }

            autocompletarColumnas(erroresSintacticosDataGridView, 6);
        }


        private void adicionarCeldaATablaErroresSintacticos(int numeroLinea, int posicionInicial, int posicionFinal, string falla, string causa, string solucion)
        {
            int numero = erroresSintacticosDataGridView.Rows.Add();

            erroresSintacticosDataGridView.Rows[numero].Cells[0].Value = numeroLinea.ToString();
            erroresSintacticosDataGridView.Rows[numero].Cells[1].Value = posicionInicial.ToString();
            erroresSintacticosDataGridView.Rows[numero].Cells[2].Value = posicionFinal.ToString();
            erroresSintacticosDataGridView.Rows[numero].Cells[3].Value = falla as String;
            erroresSintacticosDataGridView.Rows[numero].Cells[4].Value = causa as String;
            erroresSintacticosDataGridView.Rows[numero].Cells[5].Value = solucion as String;
        }

        private void limpiarTabla(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        private void autocompletarColumnas(DataGridView dataGridView, int tamaño)
        {
            for (int i = 0; i < tamaño; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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