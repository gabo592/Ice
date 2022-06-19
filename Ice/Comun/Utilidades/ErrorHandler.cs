using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace Comun.Utilidades
{
    /// <summary>
    /// Clase encargada de administrar y controlar los errores dentro del programa.
    /// </summary>
    public class ErrorHandler : List<string>
    {

        /// <summary>
        /// Añade una excepción al final de la lista de errores.
        /// </summary>
        /// <param name="exception">Excepción a agregar.</param>
        public void Add(Exception exception)
        {
            if (exception is null) return;

            if (exception.InnerException != null)
            {
                Add(exception.InnerException);
                return;
            }

            Add(exception.Message);
        }

        /// <summary>
        /// Verifica si el controlador de errores posee errores almacenados.
        /// </summary>
        /// <returns>Verdadero si existen errores almacenados; de lo contrario, Falso.</returns>
        public bool HasError() => Count > 0;

        /// <summary>
        /// Obtiene el mensaje de error que contienen todos los errores almacenados por el
        /// administrador.
        /// </summary>
        /// <returns>Mensajes de errores almacenados.</returns>
        public string GetErrorMessage()
        {
            if (Count == 0) return string.Empty;

            StringBuilder builder = new StringBuilder();

            ResourceManager manager = new ResourceManager(typeof(Recursos.Mensajes));

            foreach(string codigo in this)
            {
                string mensaje = manager.GetString(codigo);

                if (mensaje is null) mensaje = $"{codigo}";

                builder.AppendLine(mensaje);
            }

            Clear();

            return builder.ToString();
        }
    }
}
