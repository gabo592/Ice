using System;
using Comun.Utilidades;

namespace Ice.Servicios.Base
{
    /// <summary>
    /// Clase encargada de proveer funcionalidad básica para los servicios.
    /// </summary>
    internal abstract class ServicioBase : IDisposable
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        protected readonly ErrorHandler Handler;

        public ServicioBase()
        {
            Handler = new ErrorHandler();
        }

        /// <inheritdoc cref="IDisposable.Dispose"/>
        public abstract void Dispose();

        /// <summary>
        /// Busca dentro del administrador de errores los mensajes que éste almacena.
        /// </summary>
        /// <returns>Mensaje de error que contenga el administrador.</returns>
        public abstract string GetErrorMessage();

        /// <summary>
        /// Verifica si el administrador de errores contiene errores almacenados.
        /// </summary>
        /// <returns>Verdadero si existen errores; de lo contrario, Falso.</returns>
        public abstract bool HasError();
    }
}