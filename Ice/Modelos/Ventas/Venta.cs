using System;
using Modelos.Interfaces;

namespace Modelos.Ventas
{
    /// <summary>
    /// Objeto simple de tipo Venta.
    /// </summary>
    public class Venta : IIdentity, IDateable, IActivable, IEmpleable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="IDateable.Fecha"/>
        public DateTime Fecha { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <summary>
        /// Identificador único del cliente asociado a la venta.
        /// </summary>
        public int IdCliente { get; set; }

        /// <inheritdoc cref="IEmpleable.IdEmpleado"/>
        public int IdEmpleado { get; set; }
    }
}
