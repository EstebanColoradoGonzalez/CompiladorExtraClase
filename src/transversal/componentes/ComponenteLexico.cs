using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.src.transversal.componentes
{
    public class ComponenteLexico
    {
        private String lexema;
        private Categoria categoria;
        private Tipo tipo;
        private int numeroLinea;
        private int posicionInicial;
        private int posicionFinal;

        private ComponenteLexico(string lexema, Categoria categoria, Tipo tipo, int numeroLinea, int posicionInicial, int posicionFinal)
        {
            this.lexema = lexema;
            this.categoria = categoria;
            this.tipo = tipo;
            this.numeroLinea = numeroLinea;
            this.posicionInicial = posicionInicial;
            this.posicionFinal = posicionFinal;
        }

        public static ComponenteLexico crearSimbolo(string lexema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal)
        {
            return new ComponenteLexico(lexema, categoria, Tipo.SIMBOLO, numeroLinea, posicionInicial, posicionFinal);
        }

        public static ComponenteLexico crearDummy(string lexema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal)
        {
            return new ComponenteLexico(lexema, categoria, Tipo.DUMMY, numeroLinea, posicionInicial, posicionFinal);
        }

        public static ComponenteLexico crearPalabraReservada(string lexema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal)
        {
            return new ComponenteLexico(lexema, categoria, Tipo.PALABRA_RESERVADA, numeroLinea, posicionInicial, posicionFinal);
        }

        public string obtenerLexema()
        {
            if (lexema == null)
            {
                lexema = "";
            }

            return lexema;
        }

        public Categoria obtenerCategoria()
        {
            return categoria;
        }

        public Tipo obtenerTipo()
        {
            return tipo;
        }

        public int obtenerNumeroLinea()
        {
            return numeroLinea;
        }

        public int obtenerPosicionInicial()
        {
            return posicionInicial;
        }

        public int obtenerPosicionFinal()
        {
            return posicionFinal;
        }

        public override String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            String saltoLinea = "\n";

            stringBuilder.Append("Tipo Componente: ").Append(obtenerTipo()).Append(saltoLinea);
            stringBuilder.Append("Categoria: ").Append(obtenerCategoria()).Append(saltoLinea);
            stringBuilder.Append("Lexema: ").Append(obtenerLexema()).Append(saltoLinea);
            stringBuilder.Append("Numero Linea: ").Append(obtenerNumeroLinea()).Append(saltoLinea);
            stringBuilder.Append("Posicion Inicial: ").Append(obtenerPosicionInicial()).Append(saltoLinea);
            stringBuilder.Append("Posicion Final: ").Append(obtenerPosicionFinal()).Append(saltoLinea);

            return stringBuilder.ToString();
        }
    }
}
