using Compilador.Cache;
using Compilador.Transversal;
using Compilador.Transversal.Componente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.AnalizadorLexico
{
    internal class AnalizadorLexico
    {
        private int puntero;
        private int numeroLinea;
        private Linea lineaActual;
        private String caracterActual;
        private String lexema;
        private int estadoActual;
        private bool continuarAnalisis;

        private AnalizadorLexico()
        {
            cargarNuevaLinea();
        }

        public static AnalizadorLexico crear()
        {
            return new AnalizadorLexico();
        }

        private void cargarNuevaLinea()
        {
            numeroLinea = numeroLinea + 1;
            lineaActual = ProgramaFuente.obtenerProgramaFuente().obtenerLinea(numeroLinea);
            numeroLinea = lineaActual.obtenerNumeroLinea();
            puntero = 1;
        }

        private void devolverPuntero()
        {
            if(puntero > 1)
            {
                puntero = puntero - 1;
            }
        }

        private void aumentarPuntero()
        {
            puntero = puntero + 1;
        }

        private void leerSiguienteCaracter()
        {
            if (lineaActual.esFinArchivo())
            {
                caracterActual = lineaActual.obtenerContenido();
            }
            else if(puntero > lineaActual.obtenerLongitudContenido())
            {
                caracterActual = CategoriaGramatical.FIN_LINEA;
                puntero = lineaActual.obtenerLongitudContenido() + 1;
                cargarNuevaLinea();
            }
            else
            {
                caracterActual = lineaActual.obtenerContenido().Substring(puntero - 1, 1);
                aumentarPuntero();
            }
        }

        private void reiniciar()
        {
            lexema = "";
            estadoActual = 0;
            continuarAnalisis = true;
            caracterActual = "";
        }

        public ComponenteLexico devolverComponente()
        {
            ComponenteLexico retorno = null;
            reiniciar();

            while (continuarAnalisis)
            {
                if(estadoActual == 0)
                {
                    procesarEstadoCero();
                }
                else if(estadoActual == 1)
                {

                }
                else if (estadoActual == 2)
                {

                }
                else if (estadoActual == 3)
                {

                }
                else if (estadoActual == 4)
                {
                    procesarEstadoCuatro();
                }
                else if (estadoActual == 5)
                {

                }
                else if (estadoActual == 6)
                {


                }
                else if (estadoActual == 7)
                {

                }
                else if (estadoActual == 8)
                {

                }
                else if (estadoActual == 9)
                {

                }
                else if (estadoActual == 10)
                {

                }
                else if (estadoActual == 11)
                {
                    
                }
                else if (estadoActual == 12)
                {
                    retorno = procesarEstadoDoce();
                }
                else if (estadoActual == 13)
                {
                    procesarEstadoTrece();
                }
                else if (estadoActual == 14)
                {

                }
                else if (estadoActual == 15)
                {

                }
                else if (estadoActual == 16)
                {
                    retorno = procesarEstadoDieciseis();
                }
                else if (estadoActual == 17)
                {

                }
                else if (estadoActual == 18)
                {
                    procesarEstadoDiezocho();
                }
                else if (estadoActual == 19)
                {


                }
                else if (estadoActual == 20)
                {

                }
                else if (estadoActual == 21)
                {

                }
                else if (estadoActual == 22)
                {

                }
                else if (estadoActual == 23)
                {

                }
                else if (estadoActual == 24)
                {

                }
                else if (estadoActual == 25)
                {

                }
                else if (estadoActual == 26)
                {

                }
                else if (estadoActual == 27)
                {

                }
                else if (estadoActual == 28)
                {

                }
                else if (estadoActual == 29)
                {

                }
                else if (estadoActual == 30)
                {

                }
                else if (estadoActual == 31)
                {

                }
                else if (estadoActual == 32)
                {

                }
                else if (estadoActual == 33)
                {

                }
                else if (estadoActual == 34)
                {

                }
                else if (estadoActual == 35)
                {

                }
                else if (estadoActual == 36)
                {

                }
            }

            return retorno;
        }

        private void devorarEspaciosEnBlancos()
        {
            String blanco = " ";

            while (blanco.Equals(caracterActual))
            {
                leerSiguienteCaracter();
            }
        }

        private bool esLetra()
        {
            return Char.IsLetter(caracterActual.ToCharArray()[0]);
        }

        private bool esDigito()
        {
            return Char.IsDigit(caracterActual.ToCharArray()[0]);
        }

        private bool esGuionBajo()
        {
            return "_".Equals(caracterActual);
        }

        private bool esSignoPesos()
        {
            return "$".Equals(caracterActual);
        }

        private bool esFinArchivo()
        {
            return CategoriaGramatical.FIN_ARCHIVO.Equals(caracterActual);
        }

        private bool esFinLinea()
        {
            return CategoriaGramatical.FIN_LINEA.Equals(caracterActual);
        }

        private void concatenar()
        {
            lexema = lexema + caracterActual;
        }

        private void procesarEstadoCero()
        {
            leerSiguienteCaracter();
            devorarEspaciosEnBlancos();

            if(esLetra() || esGuionBajo() || esSignoPesos())
            {
                estadoActual = 4;
                concatenar();
            }
            else if(esDigito())
            {
                estadoActual = 1;
                concatenar();
            }
            else if(esFinArchivo())
            {
                estadoActual = 12;
                concatenar();
            }
            else if (esFinLinea())
            {
                estadoActual = 13;
            }
            else
            {
                estadoActual = 18;
            }
        }

        private void procesarEstadoCuatro()
        {
            leerSiguienteCaracter();

            if (esLetra() || esDigito() || esGuionBajo() || esSignoPesos())
            {
                estadoActual = 4;
                concatenar();
            }
            else
            {
                estadoActual = 16;
            }
        }

        private ComponenteLexico procesarEstadoDoce()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearSimbolo(CategoriaGramatical.FIN_ARCHIVO, Categoria.FIN_ARCHIVO, numeroLinea, 1, 1);
        }

        private void procesarEstadoTrece()
        {
            cargarNuevaLinea();
            estadoActual = 0;
        }

        private ComponenteLexico procesarEstadoDieciseis()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.IDENTIFICADOR, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoDiezocho()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo desconocido, el cual es " + caracterActual);
        }
    }
}
