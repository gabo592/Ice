using System;
using Modelos.Interfaces;

namespace Modelos.Compras
{
    /// <summary>
    /// Objeto simple de tipo Compra
    /// </summary>
    public class Compra : IIdentity, IDateable, IActivable, IEmpleable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="IDateable.Fecha"/>
        public DateTime Fecha { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <summary>
        /// Identificador único del proveedor asociado a la compra.
        /// </summary>
        public int IdProveedor { get; set; }

        /// <inheritdoc cref="IEmpleable.IdEmpleado"/>
        public int IdEmpleado { get; set; }
    }
}
