using Compilador.src.cache;
using Compilador.src.manejadorerrores;
using Compilador.src.transversal.componentes;
using Compilador.src.transversal.tablas;
using System;

namespace Compilador.Source.AnalizadorLexico
{
    public class AnalizadorLexico
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
                else if (estadoActual == 80)
                {
                    retorno = procesarEstadoOchenta();
                }
            }

            TablaMaestra.agregar(retorno);

            return retorno;
        }

        private void devorarEspaciosEnBlancos()
        {
            String blanco = " ";

            while (blanco.Equals(caracterActual) || esTabulacion())
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

        private bool esTabulacion()
        {
            return "\t".Equals(caracterActual);
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
                estadoActual = 7;
            }
        }

        private ComponenteLexico procesarEstadoSeis()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearPalabraReservada(lexema, Categoria.SELECT, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoSiete()
        {
            continuarAnalisis = false;

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "caracter del SELECT no valido";
            string causa = "Se esperaba un caracter valido para la palabra reservada SELECT, pero se recibió \"" + lexema + "\"";
            string solucion = "La palabra resevada correcta es SELECT";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

            completarSelect();

            return ComponenteLexico.crearDummy(lexema, Categoria.SELECT, numeroLinea, posicionInicial, posicionFinal);
        }

        private void completarSelect()
        {
            if (lexema.Length == 1)
            {
                concatenar("ELECT");
            }
            else if (lexema.Length == 2)
            {
                concatenar("LECT");
            }
            else if (lexema.Length == 3)
            {
                concatenar("ECT");
            }
            else if (lexema.Length == 4)
            {
                concatenar("CT");
            }
            else if (lexema.Length == 5)
            {
                concatenar("T");
            }
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
                estadoActual = 12;
            }
        }

        private ComponenteLexico procesarEstadoOnce()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearPalabraReservada(lexema, Categoria.FROM, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoDoce()
        {
            continuarAnalisis = false;

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "caracter del FROM no valido";
            string causa = "Se esperaba un caracter valido para la palabra reservada FROM, pero se recibió \"" + lexema + "\"";
            string solucion = "La palabra resevada correcta es FROM";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

            completarFROM();

            return ComponenteLexico.crearDummy(lexema, Categoria.FROM, numeroLinea, posicionInicial, posicionFinal);
        }

        private void completarFROM()
        {
            if (lexema.Length == 1)
            {
                concatenar("ROM");
            }
            else if (lexema.Length == 2)
            {
                concatenar("OM");
            }
            else if (lexema.Length == 3)
            {
                concatenar("M");
            }
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

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.CAMPO, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoDiecinueve()
        {
            continuarAnalisis = false;

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "caracter del CAMPO no valido";
            string causa = "Se esperaba un caracter valido para el CAMPO, pero se recibió \"" + lexema + "\"";
            string solucion = "La palabra resevada para el campo CAM_";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionFinal, posicionFinal, falla, causa, solucion));

            completarCampo();

            return ComponenteLexico.crearDummy(lexema, Categoria.CAMPO, numeroLinea, posicionFinal, posicionFinal);
        }

        private void completarCampo()
        {
            if (lexema.Length == 1)
            {
                concatenar("AM_NOMBRE");
            }
            else if (lexema.Length == 2)
            {
                concatenar("M_NOMBRE");
            }
            else if (lexema.Length == 3)
            {
                concatenar("_NOMBRE");
            }
            else if (lexema.Length == 4)
            {
                concatenar("NOMBRE");
            }
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
                estadoActual = 26;
            }
        }

        private void procesarEstadoVeintiCuatro()
        {
            leerSiguienteCaracter();

            if (esGuionBajo() || esLetra() || esDigito())
            {
                estadoActual = 24;
                concatenar();
            }
            else
            {
                estadoActual = 25;
            }
        }

        private ComponenteLexico procesarEstadoVeintiCinco()
        {
            continuarAnalisis = false;

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.TABLA, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoVeintiSeis()
        {
            continuarAnalisis = false;

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "caracter de la TABLA no valido";
            string causa = "Se esperaba un caracter valido para la TABLA, pero se recibió \"" + lexema + "\"";
            string solucion = "La palabra resevada para la TABLA TAB_";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

            completarTabla();

            return ComponenteLexico.crearDummy(lexema, Categoria.TABLA, numeroLinea, posicionInicial, posicionFinal);
        }

        private void completarTabla()
        {
            if (lexema.Length == 1)
            {
                concatenar("AB_NOMBRE");
            }
            else if (lexema.Length == 2)
            {
                concatenar("B_NOMBRE");
            }
            else if (lexema.Length == 3)
            {
                concatenar("_NOMBRE");
            }
            else if (lexema.Length == 4)
            {
                concatenar("NOMBRE");
            }
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
            devolverPuntero();

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
            devolverPuntero();

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

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "Simbolo del diferente que no valido";
            string causa = "Se esperaba un caracter valido para el operador diferente que, pero se recibió \"" + lexema + "\"";
            string solucion = "El operador diferente que puede ser != o <>";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

            completarDiferenteQue();

            return ComponenteLexico.crearDummy(lexema, Categoria.DIFERENTE_QUE, numeroLinea, posicionInicial, posicionFinal);
        }

        private void completarDiferenteQue()
        {
            concatenar("=");
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
                estadoActual = 41;
            }
        }

        private ComponenteLexico procesarEstadoCuarenta()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearPalabraReservada(lexema, Categoria.AND, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoCuarentaYUno()
        {
            continuarAnalisis = false;

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "Caracter del AND no valido";
            string causa = "Se esperaba un caracter valido para el operador AND, pero se recibió \"" + lexema + "\"";
            string solucion = "El operador AND puede ser AND o and";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

            completarAND();

            return ComponenteLexico.crearDummy(lexema, Categoria.AND, numeroLinea, posicionInicial, posicionFinal);
        }

        private void completarAND()
        {
            concatenar("D");
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

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "Caracter del ASC no valido";
            string causa = "Se esperaba un caracter valido para el operador ASC, pero se recibió \"" + lexema + "\"";
            string solucion = "El operador ASC puede ser ASC o asc";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

            completarASC();

            return ComponenteLexico.crearDummy(lexema, Categoria.ASC, numeroLinea, posicionInicial, posicionFinal);
        }

        private void completarASC()
        {
            concatenar("C");
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
                estadoActual = 50;
            }
        }

        private ComponenteLexico procesarEstadoCuarentaYNueve()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearPalabraReservada(lexema, Categoria.DESC, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoCincuenta()
        {
            continuarAnalisis = false;

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "Caracter del DESC no valido";
            string causa = "Se esperaba un caracter valido para el operador DESC pero se recibió \"" + lexema + "\"";
            string solucion = "El operador DESC puede ser DESC o desc";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

            completarDESC();

            return ComponenteLexico.crearDummy(lexema, Categoria.DESC, numeroLinea, posicionInicial, posicionFinal);
        }

        private void completarDESC()
        {
            if (lexema.Length == 1)
            {
                concatenar("ESC");
            }
            else if (lexema.Length == 2)
            {
                concatenar("SC");
            }
            else if(lexema.Length == 3)
            {
                concatenar("C");
            }
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
            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "Simbolo no reconocido por el lenguaje";
            string causa = "Recibí \"" + caracterActual + "\"";
            string solucion = "Asegurese de que el programa de entrada solo contenga simbolos validos";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

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

            if (!esFinLinea())
            {
                devolverPuntero();
            }

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

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "Numero o decimal no valido";
            string causa = "Luego del separador decimal, se debe recibir un digito y se recibio \"" + lexema + "\"";
            string solucion = "luego del separador decimal se debe recibir un digito";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

            completarDecimal();

            return ComponenteLexico.crearDummy(lexema, Categoria.DECIMAL, numeroLinea, posicionInicial, posicionFinal);
        }

        private void completarDecimal()
        {
            concatenar("0");
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

            if (!esFinLinea())
            {
                devolverPuntero();
            }

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
            else if (esFinLinea())
            {
                concatenar("\n");
                cargarNuevaLinea();
                estadoActual = 60;
            }
            else if (esFinArchivo())
            {
                estadoActual = 80;
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

            return ComponenteLexico.crearLiteral(lexema, Categoria.LITERAL, numeroLinea, posicionInicial, posicionFinal);
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

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "Caracter del WHERE no valido";
            string causa = "Se esperaba un caracter valido la palabra reservada WHERE pero se recibió \"" + lexema + "\"";
            string solucion = "El operador WHERE puede ser WHERE o where";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

            completarWhere();

            return ComponenteLexico.crearDummy(lexema, Categoria.WHERE, numeroLinea, posicionInicial, posicionFinal);
        }

        private void completarWhere()
        {
            if(lexema.Length == 1)
            {
                concatenar("HERE");
            }
            else if(lexema.Length == 2)
            {
                concatenar("ERE");
            }
            else if (lexema.Length == 3)
            {
                concatenar("RE");
            }
            else if (lexema.Length == 4)
            {
                concatenar("E");
            }
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
            else if (esTabulacion())
            {
                estadoActual = 75;
                concatenar(" ");
            }
            else
            {
                estadoActual = 78;
            }
        }

        private void procesarEstadoSetentaYCinco()
        {
            leerSiguienteCaracter();

            if (esEspacio() || esTabulacion())
            {
                estadoActual = 75;
            }
            else if(esFinLinea())
            {
                cargarNuevaLinea();
                estadoActual = 75;
            }
            else if (esLetraB())
            {
                estadoActual = 76;
                concatenar();
            }
            else
            {
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
                estadoActual = 78;
            }
        }

        private ComponenteLexico procesarEstadoSetentaYSiete()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearPalabraReservada(lexema, Categoria.ORDER_BY, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoSetentaYOcho()
        {
            continuarAnalisis = false;

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "Caracter del ORDER BY no valido";
            string causa = "Se esperaba un caracter valido para la palabra reservada ORDER BY pero se recibió \"" + lexema + "\"";
            string solucion = "La palabra reservada ORDER BY puede ser ORDER BY o order by";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

            completarOrderBy();

            return ComponenteLexico.crearDummy(lexema, Categoria.ORDER_BY, numeroLinea, posicionInicial, posicionFinal);
        }

        private void completarOrderBy()
        {
            if (lexema.Length == 2)
            {
                concatenar("DER BY");
            }
            else if (lexema.Length == 3)
            {
                concatenar("ER BY");
            }
            else if (lexema.Length == 4)
            {
                concatenar("R BY");
            }
            else if (lexema.Length == 5)
            {
                concatenar(" BY");
            }
            else if (lexema.Length == 6)
            {
                concatenar("BY");
            }
            else if (lexema.Length == 7)
            {
                concatenar("Y");
            }
        }

        private ComponenteLexico procesarEstadoSetentaYNueve()
        {
            continuarAnalisis = false;

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;

            return ComponenteLexico.crearSimbolo(lexema, Categoria.COMA, numeroLinea, posicionInicial, posicionFinal);
        }

        private ComponenteLexico procesarEstadoOchenta()
        {
            continuarAnalisis = false;

            if (!esFinLinea())
            {
                devolverPuntero();
            }

            int posicionInicial = puntero - lexema.Length;
            int posicionFinal = puntero - 1;
            string falla = "Caracter del LITERAL no valido";
            string causa = "Se esperaba un caracter valido para el LITERAL pero se recibió \"" + lexema + "\"";
            string solucion = "El literal debe terminar en comilla simple";

            GestorErrores.agregar(Error.crearErrorLexico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

            completarLiteral();

            return ComponenteLexico.crearDummy(lexema, Categoria.LITERAL, numeroLinea, posicionInicial, posicionFinal);
        }

        private void completarLiteral()
        {
            concatenar("'");
        }
    }
}