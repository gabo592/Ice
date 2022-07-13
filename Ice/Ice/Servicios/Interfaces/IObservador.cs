namespace Ice.Servicios.Interfaces
{
    /// <summary>
    /// Indica que una clase está pendiente de los cambios que notifica otra clase que implemente
    /// la interfaz ISujeto y actualiza su estado.
    /// </summary>
    internal interface IObservador
    {
        /// <summary>
        /// Actualiza el estado de la clase en base a los cambios realizados por el Sujeto.
        /// </summary>
        void Actualizar();
    }
}
