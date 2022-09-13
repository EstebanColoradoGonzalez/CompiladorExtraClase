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
                    procesarEstadoSiete();
                }
                else if (estadoActual == 8)
                {
                    retorno = procesarEstadoOcho();
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
                    procesarEstadoOnce();
                }
                else if (estadoActual == 12)
                {
                    retorno = procesarEstadoDoce();
                }
                else if (estadoActual == 13)
                {
                    retorno = procesarEstadoTrece();
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
                    procesarEstadoDieciocho();
                }
                else if (estadoActual == 19)
                {
                    procesarEstadoDiecinueve();
                }
                else if (estadoActual == 20)
                {
                    retorno = procesarEstadoVeinte();
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
                    procesarEstadoVeintiCinco();
                }
                else if (estadoActual == 26)
                {
                    procesarEstadoVeintiSeis();
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
                    procesarEstadoTreinta();
                }
                else if (estadoActual == 31)
                {
                    retorno = procesarEstadoTreintaYUno();
                }
                else if (estadoActual == 32)
                {
                    retorno = procesarEstadoTreintaYDos();
                }
                else if (estadoActual == 33)
                {
                    procesarEstadoTreintaYTres();
                }
                else if (estadoActual == 34)
                {
                    retorno = procesarEstadoTreintaYCuatro();
                }
                else if (estadoActual == 35)
                {
                    retorno = procesarEstadoTreintaYCinco();
                }
                else if (estadoActual == 36)
                {
                    retorno = procesarEstadoTreintaYSeis();
                }
                else if (estadoActual == 37)
                {
                    procesarEstadoTreintaYSiete();
                }
                else if (estadoActual == 38)
                {
                    retorno = procesarEstadoTreintaYOcho();
                }
                else if (estadoActual == 39)
                {
                    retorno = procesarEstadoTreintaYNueve();
                }
                else if (estadoActual == 40)
                {
                    procesarEstadoCuarenta();
                }
                else if (estadoActual == 41)
                {
                    procesarEstadoCuarentaYUno();
                }
                else if (estadoActual == 42)
                {
                    retorno = procesarEstadoCuarentaYDos();
                }
                else if (estadoActual == 43)
                {
                    retorno = procesarEstadoCuarentaYTres();
                }
                else if (estadoActual == 44)
                {
                    procesarEstadoCuarentaYCuatro();
                }
                else if (estadoActual == 45)
                {
                    retorno = procesarEstadoCuarentaYCinco();
                }
                else if (estadoActual == 46)
                {
                    retorno = procesarEstadoCuarentaYSeis();
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
                    procesarEstadoCuarentaYNueve();
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
                    retorno = procesarEstadoCincuentaYDos();
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
                    procesarEstadoCincuentaYCinco();
                }
                else if (estadoActual == 56)
                {
                    retorno = procesarEstadoCincuentaYSeis();
                }
                else if (estadoActual == 57)
                {
                    procesarEstadoCincuentaYSiete();
                }
                else if (estadoActual == 58)
                {
                    retorno = procesarEstadoCincuentaYOcho();
                }
                else if (estadoActual == 59)
                {
                    procesarEstadoCincuentaYNueve();
                }
                else if (estadoActual == 60)
                {
                    retorno = procesarEstadoSesenta();
                }
                else if (estadoActual == 61)
                {
                    procesarEstadoSesentaYUno();
                }
                else if (estadoActual == 62)
                {
                    retorno = procesarEstadoSesentaYDos();
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
                    procesarEstadoSesentaYSeis();
                }
                else if (estadoActual == 67)
                {
                    retorno = procesarEstadoSesentaYSiete();
                }
                else if (estadoActual == 68)
                {
                    retorno = procesarEstadoSesentaYOcho();
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
                    procesarEstadoSetentaYDos();
                }
                else if (estadoActual == 73)
                {
                    retorno = procesarEstadoSetentaYTres();
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
                    procesarEstadoSetentaYSiete();
                }
                else if (estadoActual == 78)
                {
                    retorno = procesarEstadoSetentaYOcho();
                }
                else if (estadoActual == 79)
                {
                    retorno = procesarEstadoSetentaYNueve();
                }
                else if (estadoActual == 80)
                {
                    procesarEstadoOchenta();
                }
                else if (estadoActual == 81)
                {
                    retorno = procesarEstadoOchentaYUno();
                }
                else if (estadoActual == 82)
                {
                    procesarEstadoOchentaYDos();
                }
                else if (estadoActual == 83)
                {
                    procesarEstadoOchentaYTres();
                }
                else if (estadoActual == 84)
                {
                    retorno = procesarEstadoOchentaYCuatro();
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
                concatenar();
            }
            else if (esLetraF())
            {
                estadoActual = 9;
                concatenar();
            }
            else if (esIgual())
            {
                estadoActual = 29;
                concatenar();
            }
            else if (esMayor())
            {
                estadoActual = 30;
                concatenar();
            }
            else if (esMenor())
            {
                estadoActual = 33;
                concatenar();
            }
            else if (esSignoAdmiracionCierra())
            {
                estadoActual = 37;
                concatenar();
            }
            else if (esLetraA())
            {
                estadoActual = 40;
                concatenar();
            }
            else if (esLetraD())
            {
                estadoActual = 47;
                concatenar();
            }
            else if(esFinArchivo())
            {
                estadoActual = 52;
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
                concatenar("M");
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

        private ComponenteLexico procesarEstadoTrece()
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

        private ComponenteLexico procesarEstadoVeinte()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.CAMPO, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoVeintiUno()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo no valido para el CAMPO, el cual es " + caracterActual);
        }

        private void procesarEstadoVeintiDos()
        {
            leerSiguienteCaracter();

            if (esLetraA())
            {
                estadoActual = 23;
                concatenar();
            }
            else
            {
                estadoActual = 28;
            }
        }

        private void procesarEstadoVeintiTres()
        {
            leerSiguienteCaracter();

            if (esLetraB())
            {
                estadoActual = 24;
                concatenar();
            }
            else
            {
                estadoActual = 28;
            }
        }

        private void procesarEstadoVeintiCuatro()
        {
            leerSiguienteCaracter();

            if (esGuionBajo())
            {
                estadoActual = 25;
                concatenar();
            }
            else
            {
                estadoActual = 28;
            }
        }

        private void procesarEstadoVeintiCinco()
        {
            leerSiguienteCaracter();

            if (esGuionBajo())
            {
                estadoActual = 25;
                concatenar();
            }
            else if(esLetra() || esDigito())
            {
                estadoActual = 26;
                concatenar();
            }
            else
            {
                estadoActual = 28;
            }
        }

        private void procesarEstadoVeintiSeis()
        {
            leerSiguienteCaracter();

            if (esGuionBajo() || esLetra() || esDigito())
            {
                estadoActual = 26;
                concatenar();
            }
            else
            {
                estadoActual = 27;
            }
        }

        private ComponenteLexico procesarEstadoVeintiSiete()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.TABLA, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoVeintiOcho()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo no valido para la TABLA, el cual es " + caracterActual);
        }

        private ComponenteLexico procesarEstadoVeintiNueve()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.IGUAL, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoTreinta()
        {
            leerSiguienteCaracter();

            if (esIgual())
            {
                estadoActual = 31;
                concatenar();
            }
            else
            {
                estadoActual = 32;
            }
        }

        private ComponenteLexico procesarEstadoTreintaYUno()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.MAYOR_O_IGUAL_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoTreintaYDos()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.MAYOR_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoTreintaYTres()
        {
            leerSiguienteCaracter();

            if (esMayor())
            {
                estadoActual = 34;
                concatenar();
            }
            else if(esIgual())
            {
                estadoActual = 35;
                concatenar();
            }
            else
            {
                estadoActual = 36;
            }
        }

        private ComponenteLexico procesarEstadoTreintaYCuatro()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.DIFERENTE_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoTreintaYCinco()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.MENOR_O_IGUAL_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoTreintaYSeis()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.MENOR_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoTreintaYSiete()
        {
            leerSiguienteCaracter();

            if (esIgual())
            {
                estadoActual = 38;
                concatenar();
            }
            else
            {
                concatenar("=");
                estadoActual = 39;
            }
        }

        private ComponenteLexico procesarEstadoTreintaYOcho()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.DIFERENTE_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoTreintaYNueve()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearDummy(lexema, Categoria.DIFERENTE_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoCuarenta()
        {
            leerSiguienteCaracter();

            if (esLetraN())
            {
                estadoActual = 41;
                concatenar();
            }
            else if (esLetraS())
            {
                estadoActual = 44;
                concatenar();
            }
            else
            {
                estadoActual = 82;
            }
        }

        private void procesarEstadoCuarentaYUno()
        {
            leerSiguienteCaracter();

            if (esLetraD())
            {
                estadoActual = 42;
                concatenar();
            }
            else
            {
                concatenar("D");
                estadoActual = 43;
            }
        }

        private ComponenteLexico procesarEstadoCuarentaYDos()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.AND, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoCuarentaYTres()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearDummy(lexema, Categoria.AND, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoCuarentaYCuatro()
        {
            leerSiguienteCaracter();

            if (esLetraC())
            {
                estadoActual = 45;
                concatenar();
            }
            else
            {
                concatenar("C");
                estadoActual = 46;
            }
        }

        private ComponenteLexico procesarEstadoCuarentaYCinco()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.ASC, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoCuarentaYSeis()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearDummy(lexema, Categoria.ASC, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoCuarentaYSiete()
        {
            leerSiguienteCaracter();

            if (esLetraE())
            {
                estadoActual = 48;
                concatenar();
            }
            else
            {
                estadoActual = 83;
            }
        }

        private void procesarEstadoCuarentaYOcho()
        {
            leerSiguienteCaracter();

            if (esLetraS())
            {
                estadoActual = 49;
                concatenar();
            }
            else
            {
                estadoActual = 83;
            }
        }

        private void procesarEstadoCuarentaYNueve()
        {
            leerSiguienteCaracter();

            if (esLetraC())
            {
                estadoActual = 50;
                concatenar();
            }
            else
            {
                concatenar("C");
                estadoActual = 51;
            }
        }

        private ComponenteLexico procesarEstadoCincuenta()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.DESC, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoCincuentaYUno()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearDummy(lexema, Categoria.DESC, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoCincuentaYDos()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(CategoriaGramatical.FIN_ARCHIVO, Categoria.FIN_ARCHIVO, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoCincuentaYTres()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo desconocido, el cual es " + caracterActual);
        }

        private void procesarEstadoCincuentaYCuatro()
        {
            cargarNuevaLinea();
            estadoActual = 0;
        }

        private void procesarEstadoCincuentaYCinco()
        {
            leerSiguienteCaracter();

            if (esDigito())
            {
                estadoActual = 55;
                concatenar();
            }
            else if (esPunto())
            {
                estadoActual = 57;
                concatenar();
            }
            else
            {
                estadoActual = 56;
            }
        }

        private ComponenteLexico procesarEstadoCincuentaYSeis()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.ENTERO, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoCincuentaYSiete()
        {
            leerSiguienteCaracter();

            if (esDigito())
            {
                estadoActual = 59;
                concatenar();
            }
            else
            {
                concatenar("0");
                estadoActual = 58;
            }
        }

        private ComponenteLexico procesarEstadoCincuentaYOcho()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearDummy(lexema, Categoria.DECIMAL, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoCincuentaYNueve()
        {
            leerSiguienteCaracter();

            if (esDigito())
            {
                estadoActual = 59;
                concatenar();
            }
            else
            {
                estadoActual = 60;
            }
        }

        private ComponenteLexico procesarEstadoSesenta()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.DECIMAL, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoSesentaYUno()
        {
            leerSiguienteCaracter();

            if (esComillaSimple())
            {
                estadoActual = 62;
                concatenar();
            }
            else
            {
                estadoActual = 61;
                concatenar();
            }
        }

        private ComponenteLexico procesarEstadoSesentaYDos()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.LITERAL, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoSesentaYTres()
        {
            leerSiguienteCaracter();

            if (esLetraH())
            {
                estadoActual = 64;
                concatenar();
            }
            else
            {
                estadoActual = 69;
            }
        }

        private void procesarEstadoSesentaYCuatro()
        {
            leerSiguienteCaracter();

            if (esLetraE())
            {
                estadoActual = 65;
                concatenar();
            }
            else
            {
                estadoActual = 69;
            }
        }

        private void procesarEstadoSesentaYCinco()
        {
            leerSiguienteCaracter();

            if (esLetraR())
            {
                estadoActual = 66;
                concatenar();
            }
            else
            {
                estadoActual = 69;
            }
        }

        private void procesarEstadoSesentaYSeis()
        {
            leerSiguienteCaracter();

            if (esLetraE())
            {
                estadoActual = 67;
                concatenar();
            }
            else
            {
                concatenar("E");
                estadoActual = 68;
            }
        }

        private ComponenteLexico procesarEstadoSesentaYSiete()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.WHERE, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoSesentaYOcho()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearDummy(lexema, Categoria.WHERE, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoSesentaYNueve()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo no valido para el WHERE, el cual es " + caracterActual);
        }

        private void procesarEstadoSetenta()
        {
            leerSiguienteCaracter();

            if (esLetraR())
            {
                estadoActual = 71;
                concatenar();
            }
            else
            {
                concatenar("R");
                estadoActual = 84;
            }
        }

        private void procesarEstadoSetentaYUno()
        {
            leerSiguienteCaracter();

            if (esLetraD())
            {
                estadoActual = 72;
                concatenar();
            }
            else
            {
                estadoActual = 73;
            }
        }

        private void procesarEstadoSetentaYDos()
        {
            leerSiguienteCaracter();

            if (esLetraE())
            {
                estadoActual = 74;
                concatenar();
            }
            else
            {
                estadoActual = 80;
            }
        }

        private ComponenteLexico procesarEstadoSetentaYTres()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.OR, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoSetentaYCuatro()
        {
            leerSiguienteCaracter();

            if (esLetraR())
            {
                estadoActual = 75;
                concatenar();
            }
            else
            {
                estadoActual = 80;
            }
        }

        private void procesarEstadoSetentaYCinco()
        {
            leerSiguienteCaracter();

            if (esEspacio())
            {
                estadoActual = 76;
                concatenar();
            }
            else
            {
                estadoActual = 80;
            }
        }

        private void procesarEstadoSetentaYSeis()
        {
            leerSiguienteCaracter();

            if (esLetraB())
            {
                estadoActual = 77;
                concatenar();
            }
            else
            {
                estadoActual = 80;
            }
        }

        private void procesarEstadoSetentaYSiete()
        {
            leerSiguienteCaracter();

            if (esLetraY())
            {
                estadoActual = 78;
                concatenar();
            }
            else
            {
                concatenar("Y");
                estadoActual = 79;
            }
        }

        private ComponenteLexico procesarEstadoSetentaYOcho()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.ORDER_BY, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoSetentaYNueve()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearDummy(lexema, Categoria.ORDER_BY, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoOchenta()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo no valido para el ORDER BY, el cual es " + caracterActual);
        }

        private ComponenteLexico procesarEstadoOchentaYUno()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.COMA, numeroLinea, posicionInicial, posicionFinal);
        }

        private void procesarEstadoOchentaYDos()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo no valido para el AND, el cual es " + caracterActual);
        }

        private void procesarEstadoOchentaYTres()
        {
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo no valido para el DESC, el cual es " + caracterActual);
        }

        private ComponenteLexico procesarEstadoOchentaYCuatro()
        {
            continuarAnalisis = false;
            devolverPuntero();

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearDummy(lexema, Categoria.OR, numeroLinea, posicionInicial, posicionFinal);
        }
    }
}
