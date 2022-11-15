using Compilador.Source.AnalizadorLexico;
using Compilador.src.manejadorerrores;
using Compilador.src.transversal.componentes;
using System;
using System.Windows.Forms;

namespace Compilador.src.analizadorsintactico
{
    public class AnalizadorSintactico
    { 
        AnalizadorLexico analizadorLexico = AnalizadorLexico.crear();
        ComponenteLexico componente;

        private void pedirComponente()
        {
            this.componente = analizadorLexico.devolverComponente();
        }

        public void analizar()
        {
            pedirComponente();
            evaluarQuery();


            if (GestorErrores.hayErrores())
            {
                MessageBox.Show("Hay errores durante el proceso de compilación");
            }
            else if (Categoria.FIN_ARCHIVO.Equals(this.componente.obtenerCategoria()))
            {
                MessageBox.Show("El programa está bien escrito.");
            }
            else
            {
                MessageBox.Show("El programa está bien escrito, pero faltarón componentes por evaluar.");
            }
        }


        ///
        /// <QUERY>::=<SELECT><WHERE><ORDER_BY>
        ///

        private void evaluarQuery()
        {
            evaluarSelect();
            evaluarWhere();
            evaluarOrderBy();
        }

        ///
        /// <SELECT>::=SELECT<CAMPOS>FROM<TABLAS>
        ///

        private void evaluarSelect()
        {
            if (Categoria.SELECT.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
                evaluarCampos();

                if (Categoria.FROM.Equals(this.componente.obtenerCategoria()))
                {
                    pedirComponente();
                    evaluarTablas();
                }
                else
                {
                    string lexema = this.componente.obtenerLexema();
                    int numeroLinea = this.componente.obtenerNumeroLinea();
                    int posicionInicial = this.componente.obtenerPosicionInicial();
                    int posicionFinal = this.componente.obtenerPosicionFinal();
                    string falla = "Componente de la expresión no valido";
                    string causa = "Se esperaba un FROM o una COMA, pero se recibió \"" + lexema + "\"";
                    string solucion = "Asegurese de que la consulta tenga la consulta tenga la siguiente estructura: SELECT<CAMPOS>FROM<TABLAS>"; 

                    GestorErrores.agregar(Error.crearErrorSintactico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

                    throw new Exception("Se ha presentado un problema durante el analisis sintactico, dado que se esperaba un FROM pero se leyó " + lexema);
                }
            }
            else
            {
                string lexema = this.componente.obtenerLexema();
                int numeroLinea = this.componente.obtenerNumeroLinea();
                int posicionInicial = this.componente.obtenerPosicionInicial();
                int posicionFinal = this.componente.obtenerPosicionFinal();
                string falla = "Componente de la expresión no valido";
                string causa = "Se esperaba un SELECT, pero se recibió \"" + lexema + "\"";
                string solucion = "Asegurese de que la consulta empiece por un select";

                GestorErrores.agregar(Error.crearErrorSintactico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

                throw new Exception("Se ha presentado un problema durante el analisis sintactico, dado que se esperaba un SELECT pero se leyó " + lexema);
            }
        }

        ///
        /// <WHERE>::=WHERE<CONDICION>|EPSILON
        ///

        private void evaluarWhere()
        {
            if(Categoria.WHERE.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
                evaluarCondicion();
            }
        }

        ///
        /// <ORDER_BY>::=ORDER BY<ORDENADORES>|EPSILON
        ///

        private void evaluarOrderBy()
        {
            if (Categoria.ORDER_BY.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
                evaluarOrdenadores();
            }
        }

        ///
        /// <CONDICION>::=<OPERACION><RESTOCONDICION>
        ///

        private void evaluarCondicion()
        {
            evaluarOperacion();
            evaluarRestoCondicion();
        }

        //
        // <CONDICION>::=<OPERACION><RESTOCONDICION>
        //

        private void evaluarRestoCondicion()
        {
            if (Categoria.AND.Equals(this.componente.obtenerCategoria()) || Categoria.OR.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
                evaluarCondicion();
            }
        }


        ///
        /// <OPERACION>::=<OPERANDO><OPERADOR><OPERANDO>
        ///

        private void evaluarOperacion()
        {
            evaluarOperando();
            evaluarOperador();
            evaluarOperando();
        }

        ///
        /// <OPERANDO>::=CAMPO|LITERAL|ENTERO|DECIMAL
        ///

        private void evaluarOperando()
        {
            if(Categoria.CAMPO.Equals(this.componente.obtenerCategoria()) || Categoria.LITERAL.Equals(this.componente.obtenerCategoria()) || (Categoria.ENTERO.Equals(this.componente.obtenerCategoria()) || Categoria.DECIMAL.Equals(this.componente.obtenerCategoria())))
            {
                pedirComponente();
            }
            else
            {
                string lexema = this.componente.obtenerLexema();
                int numeroLinea = this.componente.obtenerNumeroLinea();
                int posicionInicial = this.componente.obtenerPosicionInicial();
                int posicionFinal = this.componente.obtenerPosicionFinal();
                string falla = "Componente de la expresión no valido";
                string causa = "Se esperaba un CAMPO un LITERAL o un NUMERO, pero se recibió \"" + lexema + "\"";
                string solucion = "Asegurese de que el operando contenga un CAMPO, un LITERAL o un NUMERO";

                GestorErrores.agregar(Error.crearErrorSintactico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

                throw new Exception("Se ha presentado un problema durante el analisis sintactico, dado que se esperaba un CAMPO, un LITERAL o un NUMERO, pero se leyó " + lexema);
            }
        }

        ///
        /// <OPERADOR>::=>|<|=|>=|<=|<>|!=
        ///

        private void evaluarOperador()
        {
            if (Categoria.MAYOR_QUE.Equals(this.componente.obtenerCategoria()) ||
                Categoria.MENOR_QUE.Equals(this.componente.obtenerCategoria()) ||
                Categoria.IGUAL.Equals(this.componente.obtenerCategoria()) ||
                Categoria.MAYOR_O_IGUAL_QUE.Equals(this.componente.obtenerCategoria()) ||
                Categoria.MENOR_O_IGUAL_QUE.Equals(this.componente.obtenerCategoria()) ||
                Categoria.DIFERENTE_QUE.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
            }
            else
            {
                string lexema = this.componente.obtenerLexema();
                int numeroLinea = this.componente.obtenerNumeroLinea();
                int posicionInicial = this.componente.obtenerPosicionInicial();
                int posicionFinal = this.componente.obtenerPosicionFinal();
                string falla = "Componente de la expresión no valido";
                string causa = "Se esperaba un > ó < ó >= ó <= ó = ó != ó <>, pero se recibió \"" + lexema + "\"";
                string solucion = "Asegurese de que el operador contenga un > ó < ó >= ó <= ó = ó != ó <>";

                GestorErrores.agregar(Error.crearErrorSintactico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

                throw new Exception("Se ha presentado un problema durante el analisis sintactico, dado que se esperaba un > ó < ó >= ó <= ó = ó != ó <>, pero se leyó " + lexema);
            }
        }

        ///
        /// <ORDENADORES>::=<<TIPOORDENADOR><CRITERIO>
        ///

        private void evaluarOrdenadores()
        {
            evaluarTipoOrdenador();
            evaluarCriterio();
        }

        ///
        /// <TIPOORDENADOR>::=<CAMPOS>|<INDICES>
        ///
        
        public void evaluarTipoOrdenador()
        {
            if(Categoria.CAMPO.Equals(this.componente.obtenerCategoria()))
            {
                evaluarCampos();
            }
            else if(Categoria.ENTERO.Equals(this.componente.obtenerCategoria()))
            {
                evaluarIndices();
            }
        }

        ///
        /// <CAMPOS>::=CAMPO<RESTOCAMPOS>
        ///

        private void evaluarCampos()
        {
            if (Categoria.CAMPO.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
                evaluarRestoCampos();
            }
            else
            {
                string lexema = this.componente.obtenerLexema();
                int numeroLinea = this.componente.obtenerNumeroLinea();
                int posicionInicial = this.componente.obtenerPosicionInicial();
                int posicionFinal = this.componente.obtenerPosicionFinal();
                string falla = "Componente de la expresión no valido";
                string causa = "Se esperaba un CAMPO, pero se recibió \"" + lexema + "\"";
                string solucion = "Asegurese de que sea uno o muchos campos";

                GestorErrores.agregar(Error.crearErrorSintactico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

                throw new Exception("Se ha presentado un problema durante el analisis sintactico, dado que se esperaba uno o muchos CAMPOS, pero se leyó " + lexema);
            }
        }

        ///
        /// <RESTOCAMPOS>::=,<CAMPOS>|EPSILON
        ///

        public void evaluarRestoCampos()
        {
            if (Categoria.COMA.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
                evaluarCampos();
            }
        }

        ///
        /// <TABLAS>::=TABLA<RESTOTABLAS>
        ///

        private void evaluarTablas()
        {
            if (Categoria.TABLA.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
                evaluarRestoTablas();
            }
            else
            {
                string lexema = this.componente.obtenerLexema();
                int numeroLinea = this.componente.obtenerNumeroLinea();
                int posicionInicial = this.componente.obtenerPosicionInicial();
                int posicionFinal = this.componente.obtenerPosicionFinal();
                string falla = "Componente de la expresión no valido";
                string causa = "Se esperaba un TABLA, pero se recibió \"" + lexema + "\"";
                string solucion = "Asegurese de que sea una o muchas tablas";

                GestorErrores.agregar(Error.crearErrorSintactico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

                throw new Exception("Se ha presentado un problema durante el analisis sintactico, dado que se esperaba uno o muchas TABLAS, pero se leyó " + lexema);
            }
        }

        ///
        /// <RESTOTABLAS>::=,<TABLAS>|EPSILON
        ///

        public void evaluarRestoTablas()
        {
            if (Categoria.COMA.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
                evaluarTablas();
            }
        }

        ///
        /// <INDICES>::=ENTERO<RESTOINDICES>
        ///

        private void evaluarIndices()
        {
            if (Categoria.ENTERO.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
                evaluarRestoIndices();
            }
            else
            {
                string lexema = this.componente.obtenerLexema();
                int numeroLinea = this.componente.obtenerNumeroLinea();
                int posicionInicial = this.componente.obtenerPosicionInicial();
                int posicionFinal = this.componente.obtenerPosicionFinal();
                string falla = "Componente de la expresión no valido";
                string causa = "Se esperaba un INDICE, pero se recibió \"" + lexema + "\"";
                string solucion = "Asegurese de que sea uno o muchos INDICES compuestos por numeros enteros";
                
                GestorErrores.agregar(Error.crearErrorSintactico(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion));

                throw new Exception("Se ha presentado un problema durante el analisis sintactico, dado que se esperaba uno o muchos INDICES, pero se leyó " + lexema);
            }
        }

        ///
        /// <RESTOINDICES>::=,<INDICES>|EPSILON
        ///

        public void evaluarRestoIndices()
        {
            if (Categoria.COMA.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
                evaluarIndices();
            }
        }

        ///
        /// <CRITERIO>::=ASC|DESC|EPSILON
        ///

        private void evaluarCriterio()
        {
            if(Categoria.ASC.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
            }
            else if(Categoria.DESC.Equals(this.componente.obtenerCategoria()))
            {
                pedirComponente();
            }
        }
    }
}