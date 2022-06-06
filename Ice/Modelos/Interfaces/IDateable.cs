using System;

namespace Modelos.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un atributo de fecha completamente funcional.
    /// </summary>
    internal interface IDateable
    {
        /// <summary>
        /// Fecha a utilizar por el objeto.
        /// </summary>
        DateTime Fecha { get; set; }
    }
}
