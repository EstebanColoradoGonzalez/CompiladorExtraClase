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
            if (puntero > 1)
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
            else if (puntero > lineaActual.obtenerLongitudContenido())
            {
                caracterActual = CategoriaGramatical.FIN_LINEA;
                puntero = lineaActual.obtenerLongitudContenido() + 1;
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
                if (estadoActual == 0)
                {
                    procesarEstadoCero();
                }
                else if (estadoActual == 1)
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
                    retorno = procesarEstadoSiete();
                }
                else if (estadoActual == 8)
                {
                    procesarEstadoOcho();
                }
                else if (estadoActual == 9)
                {
                    procesarEstadoNueve();
                }
                else if (estadoActual == 10)
                {
                    procesarEstadoDiez();
                }
                else if (estadoActual == 11)
                {
                    retorno = procesarEstadoOnce();
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
                    procesarEstadoCatorce();
                }
                else if (estadoActual == 15)
                {
                    procesarEstadoQuince();
                }
                else if (estadoActual == 16)
                {
                    procesarEstadoDieciseis();
                }
                else if (estadoActual == 17)
                {
                    procesarEstadoDiecisiete();
                }
                else if (estadoActual == 18)
                {
                    retorno = procesarEstadoDieciocho();
                }
                else if (estadoActual == 19)
                {
                    retorno = procesarEstadoDiecinueve();
                }
                else if (estadoActual == 20)
                {
                    procesarEstadoVeinte();
                }
                else if (estadoActual == 21)
                {
                    procesarEstadoVeintiUno();
                }
                else if (estadoActual == 22)
                {
                    procesarEstadoVeintiDos();
                }
                else if (estadoActual == 23)
                {
                    procesarEstadoVeintiTres();
                }
                else if (estadoActual == 24)
                {
                    procesarEstadoVeintiCuatro();
                }
                else if (estadoActual == 25)
                {
                    retorno = procesarEstadoVeintiCinco();
                }
                else if (estadoActual == 26)
                {
                    retorno = procesarEstadoVeintiSeis();
                }
                else if (estadoActual == 27)
                {
                    retorno = procesarEstadoVeintiSiete();
                }
                else if (estadoActual == 28)
                {
                    procesarEstadoVeintiOcho();
                }
                else if (estadoActual == 29)
                {
                    retorno = procesarEstadoVeintiNueve();
                }
                else if (estadoActual == 30)
                {
                    retorno = procesarEstadoTreinta();
                }
                else if (estadoActual == 31)
                {
                    procesarEstadoTreintaYUno();
                }
                else if (estadoActual == 32)
                {
                    retorno = procesarEstadoTreintaYDos();
                }
                else if (estadoActual == 33)
                {
                    retorno = procesarEstadoTreintaYTres();
                }
                else if (estadoActual == 34)
                {
                    retorno = procesarEstadoTreintaYCuatro();
                }
                else if (estadoActual == 35)
                {
                    procesarEstadoTreintaYCinco();
                }
                else if (estadoActual == 36)
                {
                    retorno = procesarEstadoTreintaYSeis();
                }
                else if (estadoActual == 37)
                {
                    retorno = procesarEstadoTreintaYSiete();
                }
                else if (estadoActual == 38)
                {
                    procesarEstadoTreintaYOcho();
                }
                else if (estadoActual == 39)
                {
                    procesarEstadoTreintaYNueve();
                }
                else if (estadoActual == 40)
                {
                    retorno = procesarEstadoCuarenta();
                }
                else if (estadoActual == 41)
                {
                    retorno = procesarEstadoCuarentaYUno();
                }
                else if (estadoActual == 42)
                {
                    procesarEstadoCuarentaYDos();
                }
                else if (estadoActual == 43)
                {
                    procesarEstadoCuarentaYTres();
                }
                else if (estadoActual == 44)
                {
                    retorno = procesarEstadoCuarentaYCuatro();
                }
                else if (estadoActual == 45)
                {
                    retorno = procesarEstadoCuarentaYCinco();
                }
                else if (estadoActual == 46)
                {
                    procesarEstadoCuarentaYSeis();
                }
                else if (estadoActual == 47)
                {
                    procesarEstadoCuarentaYSiete();
                }
                else if (estadoActual == 48)
                {
                    procesarEstadoCuarentaYOcho();
                }
                else if (estadoActual == 49)
                {
                    retorno = procesarEstadoCuarentaYNueve();
                }
                else if (estadoActual == 50)
                {
                    retorno = procesarEstadoCincuenta();
                }
                else if (estadoActual == 51)
                {
                    retorno = procesarEstadoCincuentaYUno();
                }
                else if (estadoActual == 52)
                {
                    procesarEstadoCincuentaYDos();
                }
                else if (estadoActual == 53)
                {
                    procesarEstadoCincuentaYTres();
                }
                else if (estadoActual == 54)
                {
                    procesarEstadoCincuentaYCuatro();
                }
                else if (estadoActual == 55)
                {
                    retorno = procesarEstadoCincuentaYCinco();
                }
                else if (estadoActual == 56)
                {
                    procesarEstadoCincuentaYSeis();
                }
                else if (estadoActual == 57)
                {
                    retorno = procesarEstadoCincuentaYSiete();
                }
                else if (estadoActual == 58)
                {
                    procesarEstadoCincuentaYOcho();
                }
                else if (estadoActual == 59)
                {
                    retorno = procesarEstadoCincuentaYNueve();
                }
                else if (estadoActual == 60)
                {
                    procesarEstadoSesenta();
                }
                else if (estadoActual == 61)
                {
                    retorno = procesarEstadoSesentaYUno();
                }
                else if (estadoActual == 62)
                {
                    procesarEstadoSesentaYDos();
                }
                else if (estadoActual == 63)
                {
                    procesarEstadoSesentaYTres();
                }
                else if (estadoActual == 64)
                {
                    procesarEstadoSesentaYCuatro();
                }
                else if (estadoActual == 65)
                {
                    procesarEstadoSesentaYCinco();
                }
                else if (estadoActual == 66)
                {
                    retorno = procesarEstadoSesentaYSeis();
                }
                else if (estadoActual == 67)
                {
                    retorno = procesarEstadoSesentaYSiete();
                }
                else if (estadoActual == 68)
                {
                    procesarEstadoSesentaYOcho();
                }
                else if (estadoActual == 69)
                {
                    procesarEstadoSesentaYNueve();
                }
                else if (estadoActual == 70)
                {
                    procesarEstadoSetenta();
                }
                else if (estadoActual == 71)
                {
                    procesarEstadoSetentaYUno();
                }
                else if (estadoActual == 72)
                {
                    retorno = procesarEstadoSetentaYDos();
                }
                else if (estadoActual == 73)
                {
                    procesarEstadoSetentaYTres();
                }
                else if (estadoActual == 74)
                {
                    procesarEstadoSetentaYCuatro();
                }
                else if (estadoActual == 75)
                {
                    procesarEstadoSetentaYCinco();
                }
                else if (estadoActual == 76)
                {
                    procesarEstadoSetentaYSeis();
                }
                else if (estadoActual == 77)
                {
                    retorno = procesarEstadoSetentaYSiete();
                }
                else if (estadoActual == 78)
                {
                    retorno = procesarEstadoSetentaYOcho();
                }
                else if (estadoActual == 79)
                {
                    retorno = procesarEstadoSetentaYNueve();
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

        private bool esEspacio()
        {
            return " ".Equals(caracterActual);
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

        private bool esPunto()
        {
            return ".".Equals(caracterActual);
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

            if (esLetraS())
            {
                estadoActual = 1;
                concatenar();
            }
            else if (esLetraC())
            {
                estadoActual = 13;
                concatenar();
            }
            else if (esLetraT())
            {
                estadoActual = 20;
                concatenar();
            }
            else if (esDigito())
            {
                estadoActual = 54;
                concatenar();
            }
            else if (esComillaSimple())
            {
                estadoActual = 60;
                concatenar();
            }
            else if (esLetraW())
            {
                estadoActual = 62;
                concatenar();
            }
            else if (esLetraO())
            {
                estadoActual = 68;
                concatenar();
            }
            else if (esComa())
            {
                estadoActual = 79;
                concatenar();
            }
            else if (esLetraF())
            {
                estadoActual = 8;
                concatenar();
            }
            else if (esIgual())
            {
                estadoActual = 27;
                concatenar();
            }
            else if (esMayor())
            {
                estadoActual = 28;
                concatenar();
            }
            else if (esMenor())
            {
                estadoActual = 31;
                concatenar();
            }
            else if (esSignoAdmiracionCierra())
            {
                estadoActual = 35;
                concatenar();
            }
            else if (esLetraA())
            {
                estadoActual = 38;
                concatenar();
            }
            else if (esLetraD())
            {
                estadoActual = 46;
                concatenar();
            }
            else if (esFinArchivo())
            {
                estadoActual = 51;
            }
            else if (esFinLinea())
            {
                estadoActual = 53;
            }
            else
            {
                estadoActual = 52;
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
                concatenar("ELECT");
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
                concatenar("LECT");
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
                concatenar("ECT");
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
                concatenar("CT");
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
                estadoActual = 7;
            }
        }

        private ComponenteLexico procesarEstadoSeis()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.SELECT, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoSiete()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearDummy(lexema, Categoria.SELECT, numeroLinea, 1, 1);
        }

        private void procesarEstadoOcho()
        {
            leerSiguienteCaracter();

            if (esLetraR())
            {
                estadoActual = 9;
                concatenar();
            }
            else
            {
                estadoActual = 12;
            }
        }

        private void procesarEstadoNueve()
        {
            leerSiguienteCaracter();

            if (esLetraO())
            {
                estadoActual = 10;
                concatenar();
            }
            else
            {
                estadoActual = 12;
            }
        }

        private void procesarEstadoDiez()
        {
            leerSiguienteCaracter();

            if (esLetraM())
            {
                estadoActual = 11;
                concatenar();
            }
            else
            {
                concatenar("M");
                estadoActual = 12;
            }
        }

        private ComponenteLexico procesarEstadoOnce()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.FROM, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoDoce()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearDummy(lexema, Categoria.FROM, numeroLinea, 1, 1);
        }

        private void procesarEstadoTrece()
        {
            leerSiguienteCaracter();

            if (esLetraA())
            {
                estadoActual = 14;
                concatenar();
            }
            else
            {
                concatenar("AM_NOMBRE");
                estadoActual = 19;
            }
        }

        private void procesarEstadoCatorce()
        {
            leerSiguienteCaracter();

            if (esLetraM())
            {
                estadoActual = 15;
                concatenar();
            }
            else
            {
                concatenar("M_NOMBRE");
                estadoActual = 19;
            }
        }
        private void procesarEstadoQuince()
        {
            leerSiguienteCaracter();

            if (esGuionBajo())
            {
                estadoActual = 16;
                concatenar();
            }
            else
            {
                concatenar("_NOMBRE");
                estadoActual = 19;
            }
        }

        private void procesarEstadoDieciseis()
        {
            leerSiguienteCaracter();

            if (esGuionBajo())
            {
                estadoActual = 16;
                concatenar();
            }
            else if (esLetra() || esDigito())
            {
                estadoActual = 17;
                concatenar();
            }
            else
            {
                concatenar("NOMBRE");
                estadoActual = 19;
            }
        }

        private void procesarEstadoDiecisiete()
        {
            leerSiguienteCaracter();

            if (esLetra() || esDigito() || esGuionBajo())
            {
                estadoActual = 17;
                concatenar();
            }
            else
            {
                estadoActual = 18;
            }
        }

        private ComponenteLexico procesarEstadoDieciocho()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.CAMPO, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoDiecinueve()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearDummy(lexema, Categoria.CAMPO, numeroLinea, 1, 1);
        }

        private void procesarEstadoVeinte()
        {
            leerSiguienteCaracter();

            if (esLetraA())
            {
                estadoActual = 21;
                concatenar();
            }
            else
            {
                concatenar("AB_NOMBRE");
                estadoActual = 26;
            }
        }

        private void procesarEstadoVeintiUno()
        {
            leerSiguienteCaracter();

            if (esLetraB())
            {
                estadoActual = 22;
                concatenar();
            }
            else
            {
                concatenar("B_NOMBRE");
                estadoActual = 26;
            }
        }

        private void procesarEstadoVeintiDos()
        {
            leerSiguienteCaracter();

            if (esGuionBajo())
            {
                estadoActual = 23;
                concatenar();
            }
            else
            {
                concatenar("_NOMBRE");
                estadoActual = 26;
            }
        }

        private void procesarEstadoVeintiTres()
        {
            leerSiguienteCaracter();

            if (esGuionBajo())
            {
                estadoActual = 23;
                concatenar();
            }
            else if (esLetra() || esDigito())
            {
                estadoActual = 24;
                concatenar();
            }
            else
            {
                concatenar("NOMBRE");
                estadoActual = 26;
            }
        }

        private void procesarEstadoVeintiCuatro()
        {
            leerSiguienteCaracter();

            if (esGuionBajo() || esLetra() || esDigito())
            {
                estadoActual = 25;
                concatenar();
            }
            else
            {
                estadoActual = 26;
            }
        }

        private ComponenteLexico procesarEstadoVeintiCinco()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.TABLA, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoVeintiSeis()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearDummy(lexema, Categoria.TABLA, numeroLinea, 1, 1);
        }

        private ComponenteLexico procesarEstadoVeintiSiete()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.IGUAL, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoVeintiOcho()
        {
            leerSiguienteCaracter();

            if (esIgual())
            {
                estadoActual = 29;
                concatenar();
            }
            else
            {
                estadoActual = 30;
            }
        }

        private ComponenteLexico procesarEstadoVeintiNueve()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.MAYOR_O_IGUAL_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoTreinta()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.MAYOR_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoTreintaYUno()
        {
            leerSiguienteCaracter();

            if (esMayor())
            {
                estadoActual = 32;
                concatenar();
            }
            else if (esIgual())
            {
                estadoActual = 33;
                concatenar();
            }
            else
            {
                estadoActual = 34;
            }
        }

        private ComponenteLexico procesarEstadoTreintaYDos()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.DIFERENTE_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoTreintaYTres()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.MENOR_O_IGUAL_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoTreintaYCuatro()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.MENOR_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoTreintaYCinco()
        {
            leerSiguienteCaracter();

            if (esIgual())
            {
                estadoActual = 36;
                concatenar();
            }
            else
            {
                concatenar("=");
                estadoActual = 37;
            }
        }

        private ComponenteLexico procesarEstadoTreintaYSeis()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.DIFERENTE_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoTreintaYSiete()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearDummy(lexema, Categoria.DIFERENTE_QUE, numeroLinea, 1, 1);
        }

        private void procesarEstadoTreintaYOcho()
        {
            leerSiguienteCaracter();

            if (esLetraN())
            {
                estadoActual = 39;
                concatenar();
            }
            else if (esLetraS())
            {
                estadoActual = 43;
                concatenar();
            }
            else
            {
                estadoActual = 42;
            }
        }

        private void procesarEstadoTreintaYNueve()
        {
            leerSiguienteCaracter();

            if (esLetraD())
            {
                estadoActual = 40;
                concatenar();
            }
            else
            {
                concatenar("D");
                estadoActual = 41;
            }
        }

        private ComponenteLexico procesarEstadoCuarenta()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.AND, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoCuarentaYUno()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearDummy(lexema, Categoria.AND, numeroLinea, 1, 1);
        }

        private void procesarEstadoCuarentaYDos()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo no valido para el AND o ASC, el cual es " + caracterActual);
        }

        private void procesarEstadoCuarentaYTres()
        {
            leerSiguienteCaracter();

            if (esLetraC())
            {
                estadoActual = 44;
                concatenar();
            }
            else
            {
                concatenar("C");
                estadoActual = 45;
            }
        }

        private ComponenteLexico procesarEstadoCuarentaYCuatro()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.ASC, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoCuarentaYCinco()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearDummy(lexema, Categoria.ASC, numeroLinea, 1, 1);
        }

        private void procesarEstadoCuarentaYSeis()
        {
            leerSiguienteCaracter();

            if (esLetraE())
            {
                estadoActual = 47;
                concatenar();
            }
            else
            {
                concatenar("E");
                estadoActual = 50;
            }
        }

        private void procesarEstadoCuarentaYSiete()
        {
            leerSiguienteCaracter();

            if (esLetraS())
            {
                estadoActual = 48;
                concatenar();
            }
            else
            {
                concatenar("S");
                estadoActual = 50;
            }
        }

        private void procesarEstadoCuarentaYOcho()
        {
            leerSiguienteCaracter();

            if (esLetraC())
            {
                estadoActual = 49;
                concatenar();
            }
            else
            {
                concatenar("C");
                estadoActual = 50;
            }
        }

        private ComponenteLexico procesarEstadoCuarentaYNueve()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.DESC, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoCincuenta()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearDummy(lexema, Categoria.DESC, numeroLinea, 1, 1);
        }

        private ComponenteLexico procesarEstadoCincuentaYUno()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(CategoriaGramatical.FIN_ARCHIVO, Categoria.FIN_ARCHIVO, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoCincuentaYDos()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo desconocido, el cual es " + caracterActual);
        }

        private void procesarEstadoCincuentaYTres()
        {
            cargarNuevaLinea();
            estadoActual = 0;
        }

        private void procesarEstadoCincuentaYCuatro()
        {
            leerSiguienteCaracter();

            if (esDigito())
            {
                estadoActual = 54;
                concatenar();
            }
            else if (esPunto())
            {
                estadoActual = 56;
                concatenar();
            }
            else
            {
                estadoActual = 55;
            }
        }

        private ComponenteLexico procesarEstadoCincuentaYCinco()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.ENTERO, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoCincuentaYSeis()
        {
            leerSiguienteCaracter();

            if (esDigito())
            {
                estadoActual = 58;
                concatenar();
            }
            else
            {
                concatenar("0");
                estadoActual = 57;
            }
        }

        private ComponenteLexico procesarEstadoCincuentaYSiete()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearDummy(lexema, Categoria.DECIMAL, numeroLinea, 1, 1);
        }

        private void procesarEstadoCincuentaYOcho()
        {
            leerSiguienteCaracter();

            if (esDigito())
            {
                estadoActual = 58;
                concatenar();
            }
            else
            {
                estadoActual = 59;
            }
        }

        private ComponenteLexico procesarEstadoCincuentaYNueve()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.DECIMAL, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoSesenta()
        {
            leerSiguienteCaracter();

            if (esComillaSimple())
            {
                estadoActual = 61;
                concatenar();
            }
            else
            {
                estadoActual = 60;
                concatenar();
            }
        }

        private ComponenteLexico procesarEstadoSesentaYUno()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.LITERAL, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoSesentaYDos()
        {
            leerSiguienteCaracter();

            if (esLetraH())
            {
                estadoActual = 63;
                concatenar();
            }
            else
            {
                concatenar("HERE");
                estadoActual = 67;
            }
        }

        private void procesarEstadoSesentaYTres()
        {
            leerSiguienteCaracter();

            if (esLetraE())
            {
                estadoActual = 64;
                concatenar();
            }
            else
            {
                concatenar("ERE");
                estadoActual = 67;
            }
        }

        private void procesarEstadoSesentaYCuatro()
        {
            leerSiguienteCaracter();

            if (esLetraR())
            {
                estadoActual = 65;
                concatenar();
            }
            else
            {
                concatenar("RE");
                estadoActual = 67;
            }
        }

        private void procesarEstadoSesentaYCinco()
        {
            leerSiguienteCaracter();

            if (esLetraE())
            {
                estadoActual = 66;
                concatenar();
            }
            else
            {
                concatenar("E");
                estadoActual = 67;
            }
        }

        private ComponenteLexico procesarEstadoSesentaYSeis()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.WHERE, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoSesentaYSiete()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearDummy(lexema, Categoria.WHERE, numeroLinea, 1, 1);
        }

        private void procesarEstadoSesentaYOcho()
        {
            leerSiguienteCaracter();

            if (esLetraR())
            {
                estadoActual = 70;
                concatenar();
            }
            else
            {
                estadoActual = 69;
            }
        }

        private void procesarEstadoSesentaYNueve()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo no valido para el ORDER BY o OR, el cual es " + caracterActual);
        }

        private void procesarEstadoSetenta()
        {
            leerSiguienteCaracter();

            if (esLetraD())
            {
                estadoActual = 71;
                concatenar();
            }
            else
            {
                estadoActual = 72;
            }
        }

        private void procesarEstadoSetentaYUno()
        {
            leerSiguienteCaracter();

            if (esLetraE())
            {
                estadoActual = 73;
                concatenar();
            }
            else
            {
                concatenar("ER BY");
                estadoActual = 78;
            }
        }

        private ComponenteLexico procesarEstadoSetentaYDos()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.OR, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoSetentaYTres()
        {
            leerSiguienteCaracter();

            if (esLetraR())
            {
                estadoActual = 74;
                concatenar();
            }
            else
            {
                concatenar("R BY");
                estadoActual = 78;
            }
        }

        private void procesarEstadoSetentaYCuatro()
        {
            leerSiguienteCaracter();

            if (esEspacio())
            {
                estadoActual = 75;
                concatenar();
            }
            else
            {
                concatenar(" BY");
                estadoActual = 78;
            }
        }

        private void procesarEstadoSetentaYCinco()
        {
            leerSiguienteCaracter();

            if (esLetraB())
            {
                estadoActual = 76;
                concatenar();
            }
            else
            {
                concatenar("BY");
                estadoActual = 78;
            }
        }

        private void procesarEstadoSetentaYSeis()
        {
            leerSiguienteCaracter();

            if (esLetraY())
            {
                estadoActual = 77;
                concatenar();
            }
            else
            {
                concatenar("Y");
                estadoActual = 78;
            }
        }

        private ComponenteLexico procesarEstadoSetentaYSiete()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.ORDER_BY, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoSetentaYOcho()
        {
            continuarAnalisis = false;

            return ComponenteLexico.crearDummy(lexema, Categoria.ORDER_BY, numeroLinea, 1, 1);
        }

        private ComponenteLexico procesarEstadoSetentaYNueve()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.COMA, numeroLinea, posicionInicial, posicionFinal);
        }
    }
}
