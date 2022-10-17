using Compilador.src.transversal.componentes;
using System.Collections.Generic;

namespace Compilador.src.transversal.tablas
{
    public class TablaMaestra
    {
        public static void agregar(ComponenteLexico componente)
        {
            TablaPalabraReservada.agregar(componente);
            TablaSimbolo.agregar(componente);
            TablaLiterales.agregar(componente);
            TablaDummies.agregar(componente);
        }

        public static void reiniciar()
        {
            TablaPalabraReservada.reiniciar();
            TablaSimbolo.reiniciar();
            TablaLiterales.reiniciar();
            TablaDummies.reiniciar();
        }

        public static List<ComponenteLexico> obtenerComponente(Tipo tipo)
        {
            if (Tipo.SIMBOLO.Equals(tipo))
            {
                return TablaSimbolo.obtenerComponentes();
            }
            else if (Tipo.DUMMY.Equals(tipo))
            {
                return TablaDummies.ObtenerComponentes();
            }
            else if (Tipo.LITERAL.Equals(tipo))
            {
                return TablaLiterales.ObtenerComponentes();
            }
            else
            {
                return TablaPalabraReservada.ObtenerComponentes();
            }
        }
    }
}