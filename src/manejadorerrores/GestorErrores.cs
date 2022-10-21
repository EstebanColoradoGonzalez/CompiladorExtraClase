using Compilador.src.transversal.componentes;
using System.Collections.Generic;

namespace Compilador.src.manejadorerrores
{
    public class GestorErrores
    {
        private static Dictionary<TipoError, List<Error>> TABLA_ERRORES = new Dictionary<TipoError, List<Error>>();
        private static bool estaInicializada = false;

        private static void inicializar()
        {
            if (!estaInicializada)
            {
                TABLA_ERRORES.Add(TipoError.LEXICO, new List<Error>());
                TABLA_ERRORES.Add(TipoError.SINTACTICO, new List<Error>());
                TABLA_ERRORES.Add(TipoError.SEMANTICO, new List<Error>());

                estaInicializada = true;
            }
        }

        public static List<Error> obtenerErrores(TipoError error)
        {
            if(!hayErrores(error))
            {
                return new List<Error>();
            }
            else if (TipoError.LEXICO.Equals(error))
            {
                return TABLA_ERRORES[error];
            }
            else if (TipoError.SEMANTICO.Equals(error))
            {
                return TABLA_ERRORES[error];
            }
            else if (TipoError.SINTACTICO.Equals(error))
            {
                return TABLA_ERRORES[error];
            }
            else
            {
                return new List<Error>();
            }
        }

        public static void agregar(Error error)
        {
            inicializar();

            if (error != null)
            {
                TABLA_ERRORES[error.getTipo()].Add(error);
            }
        }

        public static bool hayErrores(TipoError tipo)
        {
            return TABLA_ERRORES[tipo].Count > 0;
        }

        public static bool hayErrores()
        {
            return hayErrores(TipoError.LEXICO) || hayErrores(TipoError.SINTACTICO) || hayErrores(TipoError.SEMANTICO);
        }

        public static void reiniciar()
        {
            estaInicializada = false;
            TABLA_ERRORES.Clear();
            inicializar();
        }
    }
}