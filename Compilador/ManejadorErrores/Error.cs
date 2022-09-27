using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.ManejadorErrores
{
    public class Error
    {
        private int numeroLinea;
        private int posicionInicial;
        private int posicionFinal;
        private String falla;
        private String causa;
        private String solucion;
        private TipoError tipo;

        private Error(int numeroLinea, int posicionInicial, int posicionFinal, String falla, String causa, String solucion, TipoError tipo)
        {
            this.numeroLinea = numeroLinea;
            this.posicionInicial = posicionInicial;
            this.posicionFinal = posicionFinal;
            this.falla = falla;
            this.causa = causa;
            this.solucion = solucion;
            this.tipo = tipo;
        }

        public static Error crearErrorLexico(int numeroLinea, int posicionInicial, int posicionFinal, String falla, String causa, String solucion)
        {
            return new Error(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion, TipoError.LEXICO);
        }

        public static Error crearErrorSintactico(int numeroLinea, int posicionInicial, int posicionFinal, String falla, String causa, String solucion)
        {
            return new Error(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion, TipoError.SINTACTICO);
        }

        public static Error crearErrorSemantico(int numeroLinea, int posicionInicial, int posicionFinal, String falla, String causa, String solucion)
        {
            return new Error(numeroLinea, posicionInicial, posicionFinal, falla, causa, solucion, TipoError.SEMANTICO);
        }

        public int getNumeroLinea()
        {
            if(numeroLinea <= 0)
            {
                numeroLinea = 1;
            }

            return numeroLinea;
        }

        public int getPosicionInicial()
        {
            if (posicionInicial <= 0)
            {
                posicionInicial = 1;
            }

            return posicionInicial;
        }

        public int getPosicionFinal()
        {
            if (posicionFinal <= 0)
            {
                posicionFinal = 1;
            }

            return posicionFinal;
        }

        public String getFalla()
        {
            if (falla == null)
            {
                falla = "";
            }

            return falla;
        }

        public String getCausa()
        {
            if (causa == null)
            {
                causa = "";
            }

            return causa;
        }

        public String getSolucion()
        {
            if (solucion == null)
            {
                solucion = "";
            }

            return solucion;
        }

        public TipoError getTipo()
        {
            return tipo;
        }
    }
}
