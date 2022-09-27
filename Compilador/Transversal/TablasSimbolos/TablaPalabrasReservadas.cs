using Compilador.Transversal.Componente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal.TablasSimbolos
{
    public class TablaPalabrasReservadas
    {
        private static Dictionary<String, List<ComponenteLexico>> TABLA = new Dictionary<string, List<ComponenteLexico>>();
        private static Dictionary<String, Categoria> PALABRAS_RESERVADAS = new Dictionary<String, Categoria>();

        static TablaPalabrasReservadas()
        {
            PALABRAS_RESERVADAS.Add(CategoriaGramatical.SELECT, Categoria.SELECT);
            PALABRAS_RESERVADAS.Add(CategoriaGramatical.FROM, Categoria.FROM);
            PALABRAS_RESERVADAS.Add(CategoriaGramatical.WHERE, Categoria.WHERE);
            PALABRAS_RESERVADAS.Add(CategoriaGramatical.ASC, Categoria.ASC);
            PALABRAS_RESERVADAS.Add(CategoriaGramatical.DESC, Categoria.DESC);
            PALABRAS_RESERVADAS.Add(CategoriaGramatical.ORDER_BY, Categoria.ORDER_BY);
            PALABRAS_RESERVADAS.Add(CategoriaGramatical.AND, Categoria.AND);
            PALABRAS_RESERVADAS.Add(CategoriaGramatical.OR, Categoria.OR);
        }

        public static void reiniciar()
        {
            TABLA.Clear();
        }

        public static List<ComponenteLexico> obtenerComponentes(String lexema)
        {
            if (!TABLA.ContainsKey(lexema))
            {
                TABLA.Add(lexema, new List<ComponenteLexico>());
            }

            return TABLA[lexema];
        }

        public static void agregar(ComponenteLexico componenteLexico)
        {
            if (componenteLexico != null && esPalabraReservada(componenteLexico.obtenerLexema()))
            {
                componenteLexico = ComponenteLexico.crearPalabraReservada(componenteLexico.obtenerLexema(), PALABRAS_RESERVADAS[componenteLexico.obtenerLexema()], componenteLexico.obtenerNumeroLinea(), componenteLexico.obtenerPosicionInicial(), componenteLexico.obtenerPosicionFinal());
                
                obtenerComponentes(componenteLexico.obtenerLexema()).Add(componenteLexico);
            }
        }

        private static bool esPalabraReservada(String lexema)
        {
            return PALABRAS_RESERVADAS.ContainsKey(lexema);
        }

        public static List<ComponenteLexico> ObtenerComponentes()
        {
            var componentes = new List<ComponenteLexico>();

            foreach (List<ComponenteLexico> lista in TABLA.Values)
            {
                componentes.AddRange(lista);
            }

            return componentes;
        }
    }
}
