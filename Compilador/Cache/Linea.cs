using Compilador.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Cache
{
    internal class Linea
    {
        private int numeroLinea;
        private String contenido;

        private Linea(int numeroLinea, string contenido)
        {
            this.contenido = contenido;
            this.numeroLinea = numeroLinea;
        }

        public static Linea crear(int numeroLinea, string contenido)
        {
            return new Linea(numeroLinea, contenido);
        }
        public int obtenerNumeroLinea()
        {
            return numeroLinea;
        }

        public String obtenerContenido()
        {
            return contenido;
        }

        public bool esFinArchivo()
        {
            return CategoriaGramatical.FIN_ARCHIVO.Equals(obtenerContenido());
        }

        public bool esFinLinea()
        {
            return CategoriaGramatical.FIN_LINEA.Equals(obtenerContenido());
        }

        public void aumentarLinea()
        {
            numeroLinea = numeroLinea + 1;
        }

        public int obtenerLongitudContenido()
        {
            return obtenerContenido().Length;
        }
    }
}
