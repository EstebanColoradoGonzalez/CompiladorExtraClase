using Compilador.Transversal.Componente;
using System.Collections.Generic;


namespace Compilador.Transversal.TablasSimbolos
{
    public class TablaMaestra
    {
        public static void agregar(ComponenteLexico componente)
        {
            TablaPalabrasReservadas.agregar(componente);
            TablaSimbolo.agregar(componente);
            TablaLiterales.agregar(componente);
            TablaDummies.agregar(componente);
        }

        public static void reiniciar()
        {
            TablaPalabrasReservadas.reiniciar();
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
                return TablaPalabrasReservadas.ObtenerComponentes();
            }
        }
    }
}
