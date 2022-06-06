using System;
using Modelos.Interfaces;

namespace Modelos.Compras
{
    /// <summary>
    /// Objeto simple de tipo Compra
    /// </summary>
    internal class Compra : IIdentity, IDateable, IActivable, IEmpleable
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }

        /// <summary>
        /// Identificador único del proveedor asociado a la compra.
        /// </summary>
        public int IdProveedor { get; set; }

        public int IdEmpleado { get; set; }
    }
}
