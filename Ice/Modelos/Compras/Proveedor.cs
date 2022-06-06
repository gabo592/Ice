using Modelos.Interfaces;

namespace Modelos.Compras
{
    /// <summary>
    /// Objeto simple de tipo Proveedor.
    /// </summary>
    internal class Proveedor : IIdentity, INameable, IActivable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        /// <summary>
        /// Número de teléfono del proveedor.
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// Dirección del proveedor.
        /// </summary>
        public string Direccion { get; set; }

        public bool Estado { get; set; }
    }
}
