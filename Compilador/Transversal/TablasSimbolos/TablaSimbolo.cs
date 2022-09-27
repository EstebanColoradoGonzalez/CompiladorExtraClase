using Compilador.Transversal.Componente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal.TablasSimbolos
{
    public class TablaSimbolo
    {
        private static Dictionary<String, List<ComponenteLexico>> TABLA = new Dictionary<string, List<ComponenteLexico>>();
        
        public static void reiniciar()
        {
            TABLA.Clear();
        }

        public static List<ComponenteLexico> obtenerComponentes(String lexema)
        {
            if(!TABLA.ContainsKey(lexema))
            {
                TABLA.Add(lexema, new List<ComponenteLexico>());
            }

            return TABLA[lexema];
        }

        public static void agregar(ComponenteLexico componenteLexico)
        {
            if (componenteLexico != null && Tipo.SIMBOLO.Equals(componenteLexico.obtenerTipo()))
            {
                obtenerComponentes(componenteLexico.obtenerLexema()).Add(componenteLexico);

            }
        }

        public static List<ComponenteLexico> obtenerComponentes()
        {
            var componentes = new List<ComponenteLexico>();

            foreach(List<ComponenteLexico> lista in TABLA.Values)
            {
                componentes.AddRange(lista);
            }

            return componentes;
        }
    }
}
