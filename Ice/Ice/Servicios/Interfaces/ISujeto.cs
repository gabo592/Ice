namespace Ice.Servicios.Interfaces
{
    /// <summary>
    /// Indica que una clase notificará a todas aquellas que implementen la interfaz
    /// IObservador que actualicen su estado dados los cambios que ésta notifique.
    /// </summary>
    public interface ISujeto
    {
        /// <summary>
        /// Agrega un Observador a la lista que administra la clase.
        /// </summary>
        /// <param name="observador">Objeto de implemente la interfaz IObservador.</param>
        void AgregarObervador(IObservador observador);

        /// <summary>
        /// Notifica a todos los Observadores que deben actualizar su estado.
        /// </summary>
        void Notificar();
    }
}
