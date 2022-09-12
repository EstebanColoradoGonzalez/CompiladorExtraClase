using Compilador.Cache;
using Compilador.Transversal;
using Compilador.Transversal.Componente;
using System;

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
                    procesarEstadoUno();
                }
                else if (estadoActual == 2)
                {
                    procesarEstadoDos();
                }
                else if (estadoActual == 3)
                {
                    procesarEstadoTres();
                }
                else if (estadoActual == 4)
                {
                    procesarEstadoCuatro();
                }
                else if (estadoActual == 5)
                {
                    procesarEstadoCinco();
                }
                else if (estadoActual == 6)
                {
                    retorno = procesarEstadoSeis();
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
                else if (estadoActual == 37)
                {

                }
                else if (estadoActual == 38)
                {

                }
                else if (estadoActual == 39)
                {

                }
                else if (estadoActual == 40)
                {

                }
                else if (estadoActual == 41)
                {

                }
                else if (estadoActual == 42)
                {

                }
                else if (estadoActual == 43)
                {

                }
                else if (estadoActual == 44)
                {

                }
                else if (estadoActual == 45)
                {

                }
                else if (estadoActual == 46)
                {

                }
                else if (estadoActual == 47)
                {

                }
                else if (estadoActual == 48)
                {

                }
                else if (estadoActual == 49)
                {

                }
                else if (estadoActual == 50)
                {

                }
                else if (estadoActual == 51)
                {

                }
                else if (estadoActual == 52)
                {

                }
                else if (estadoActual == 53)
                {

                }
                else if (estadoActual == 54)
                {

                }
                else if (estadoActual == 55)
                {

                }
                else if (estadoActual == 56)
                {

                }
                else if (estadoActual == 57)
                {

                }
                else if (estadoActual == 58)
                {

                }
                else if (estadoActual == 59)
                {

                }
                else if (estadoActual == 60)
                {

                }
                else if (estadoActual == 61)
                {

                }
                else if (estadoActual == 62)
                {

                }
                else if (estadoActual == 63)
                {

                }
                else if (estadoActual == 64)
                {

                }
                else if (estadoActual == 65)
                {

                }
                else if (estadoActual == 66)
                {

                }
                else if (estadoActual == 67)
                {

                }
                else if (estadoActual == 68)
                {

                }
                else if (estadoActual == 69)
                {

                }
                else if (estadoActual == 70)
                {

                }
                else if (estadoActual == 71)
                {

                }
                else if (estadoActual == 72)
                {

                }
                else if (estadoActual == 73)
                {

                }
                else if (estadoActual == 74)
                {

                }
                else if (estadoActual == 75)
                {

                }
                else if (estadoActual == 76)
                {

                }
                else if (estadoActual == 77)
                {

                }
                else if (estadoActual == 78)
                {

                }
                else if (estadoActual == 79)
                {

                }
                else if (estadoActual == 80)
                {

                }
                else if (estadoActual == 81)
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

        private bool esLetraS()
        {
            return "S".Equals(caracterActual) || "s".Equals(caracterActual);
        }

        private bool esLetraE()
        {
            return "E".Equals(caracterActual) || "e".Equals(caracterActual);
        }

        private bool esLetraL()
        {
            return "L".Equals(caracterActual) || "l".Equals(caracterActual);
        }

        private bool esLetraC()
        {
            return "C".Equals(caracterActual) || "c".Equals(caracterActual);
        }

        private bool esLetraT()
        {
            return "T".Equals(caracterActual) || "t".Equals(caracterActual);
        }

        private bool esLetraF()
        {
            return "F".Equals(caracterActual) || "f".Equals(caracterActual);
        }


        private bool esLetraR()
        {
            return "R".Equals(caracterActual) || "r".Equals(caracterActual);
        }

        private bool esLetraO()
        {
            return "O".Equals(caracterActual) || "o".Equals(caracterActual);
        }

        private bool esLetraM()
        {
            return "M".Equals(caracterActual) || "m".Equals(caracterActual);
        }

        private bool esLetraW()
        {
            return "W".Equals(caracterActual) || "w".Equals(caracterActual);
        }

        private bool esLetraH()
        {
            return "H".Equals(caracterActual) || "h".Equals(caracterActual);
        }

        private bool esLetraD()
        {
            return "D".Equals(caracterActual) || "d".Equals(caracterActual);
        }

        private bool esLetraB()
        {
            return "B".Equals(caracterActual) || "b".Equals(caracterActual);
        }

        private bool esLetraY()
        {
            return "Y".Equals(caracterActual) || "y".Equals(caracterActual);
        }

        private bool esLetraA()
        {
            return "A".Equals(caracterActual) || "a".Equals(caracterActual);
        }

        private bool esLetraN()
        {
            return "N".Equals(caracterActual) || "n".Equals(caracterActual);
        }

        private bool esLetra()
        {
            return Char.IsLetter(caracterActual.ToCharArray()[0]);
        }

        private bool esDigito()
        {
            return Char.IsDigit(caracterActual.ToCharArray()[0]);
        }

        private bool esComillaSimple()
        {
            return "'".Equals(caracterActual);
        }

        private bool esComa()
        {
            return ",".Equals(caracterActual);
        }

        private bool esIgual()
        {
            return "=".Equals(caracterActual);
        }

        private bool esMayor()
        {
            return ">".Equals(caracterActual);
        }

        private bool esMenor()
        {
            return "<".Equals(caracterActual);
        }

        private bool esSignoAdmiracionCierra()
        {
            return "!".Equals(caracterActual);
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

        private void concatenar(String letra)
        {
            lexema = lexema + letra;
        }

        private void procesarEstadoCero()
        {
            leerSiguienteCaracter();
            devorarEspaciosEnBlancos();

            if(esLetraS())
            {
                estadoActual = 1;
                concatenar();
            }
            else if(esLetraC())
            {
                estadoActual = 15;
                concatenar();
            }
            else if(esLetraT())
            {
                estadoActual = 22;
                concatenar();
            }
            else if(esDigito())
            {
                estadoActual = 55;
                concatenar();
            }
            else if(esComillaSimple())
            {
                estadoActual = 61;
                concatenar();
            }
            else if(esLetraW())
            {
                estadoActual = 63;
                concatenar();
            }
            else if(esLetraO())
            {
                estadoActual = 70;
                concatenar();
            }
            else if (esComa())
            {
                estadoActual = 81;
            }
            else if (esLetraF())
            {
                estadoActual = 9;
                concatenar();
            }
            else if (esIgual())
            {
                estadoActual = 29;
            }
            else if (esMayor())
            {
                estadoActual = 30;
            }
            else if (esMenor())
            {
                estadoActual = 33;
            }
            else if (esSignoAdmiracionCierra())
            {
                estadoActual = 37;
            }
            else if (esLetraA())
            {
                estadoActual = 40;
            }
            else if (esLetraD())
            {
                estadoActual = 47;
            }
            else if(esFinArchivo())
            {
                estadoActual = 52;
                concatenar();
            }
            else if (esFinLinea())
            {
                estadoActual = 54;
            }
            else
            {
                estadoActual = 53;
            }
        }

        private void procesarEstadoUno()
        {
            leerSiguienteCaracter();

            if (esLetraE())
            {
                estadoActual = 2;
                concatenar();
            }
            else
            {
                estadoActual = 7;
            }
        }

        private void procesarEstadoDos()
        {
            leerSiguienteCaracter();

            if (esLetraL())
            {
                estadoActual = 3;
                concatenar();
            }
            else
            {
                estadoActual = 7;
            }
        }

        private void procesarEstadoTres()
        {
            leerSiguienteCaracter();

            if (esLetraE())
            {
                estadoActual = 4;
                concatenar();
            }
            else
            {
                estadoActual = 7;
            }
        }

        private void procesarEstadoCuatro()
        {
            leerSiguienteCaracter();

            if (esLetraC())
            {
                estadoActual = 5;
                concatenar();
            }
            else
            {
                estadoActual = 7;
            }
        }

        private void procesarEstadoCinco()
        {
            leerSiguienteCaracter();

            if (esLetraT())
            {
                estadoActual = 6;
                concatenar();
            }
            else
            {
                concatenar("T");
                estadoActual = 8;
            }
        }

        private ComponenteLexico procesarEstadoSeis()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.SELECT, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoSiete()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo no valido para el SELECT, el cual es " + caracterActual);
        }

        private ComponenteLexico procesarEstadoOcho()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearDummy(lexema, Categoria.SELECT, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoNueve()
        {
            leerSiguienteCaracter();

            if (esLetraR())
            {
                estadoActual = 10;
                concatenar();
            }
            else
            {
                estadoActual = 14;
            }
        }

        private void procesarEstadoDiez()
        {
            leerSiguienteCaracter();

            if (esLetraO())
            {
                estadoActual = 11;
                concatenar();
            }
            else
            {
                estadoActual = 14;
            }
        }

        private void procesarEstadoOnce()
        {
            leerSiguienteCaracter();

            if (esLetraM())
            {
                estadoActual = 12;
                concatenar();
            }
            else
            {
                estadoActual = 14;
            }
        }

        private ComponenteLexico procesarEstadoDoce()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.FROM, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarTrece()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearDummy(lexema, Categoria.FROM, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoCatorce()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo no valido para el FROM, el cual es " + caracterActual);
        }

        private void procesarEstadoQuince()
        {
            leerSiguienteCaracter();

            if (esLetraA())
            {
                estadoActual = 16;
                concatenar();
            }
            else
            {
                estadoActual = 21;
            }
        }

        private void procesarEstadoDieciseis()
        {
            leerSiguienteCaracter();

            if (esLetraM())
            {
                estadoActual = 17;
                concatenar();
            }
            else
            {
                estadoActual = 21;
            }
        }
        private void procesarEstadoDiecisiete()
        {
            leerSiguienteCaracter();

            if (esGuionBajo())
            {
                estadoActual = 18;
                concatenar();
            }
            else
            {
                estadoActual = 21;
            }
        }

        private void procesarEstadoDieciocho()
        {
            leerSiguienteCaracter();

            if (esGuionBajo())
            {
                estadoActual = 18;
                concatenar();
            }
            else if (esLetra() || esDigito())
            {
                estadoActual = 19;
                concatenar();
            }
            else
            {
                estadoActual = 21;
            }
        }

        private void procesarEstadoDiecinueve()
        {
            leerSiguienteCaracter();

            if (esLetra() || esDigito() || esGuionBajo())
            {
                estadoActual = 19;
                concatenar();
            }
            else
            {
                estadoActual = 20;
            }
        }

        private ComponenteLexico procesarVeinte()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.CAMPO, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoVeintiuno()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo no valido para el CAMPO, el cual es " + caracterActual);
        }

        // Aqui vamos

        private void procesarEstado()
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

            return ComponenteLexico.crearSimbolo(lexema, Categoria.SELECT, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoDiezocho()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo desconocido, el cual es " + caracterActual);
        }
    }
}
