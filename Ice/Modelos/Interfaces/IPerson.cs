namespace Modelos.Interfaces
{
    /// <summary>
    /// Indica que una clase representa un registro de una persona natural.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Primer nombre de la persona.
        /// </summary>
        string PrimerNombre { get; set; }

        /// <summary>
        /// Segundo Nombre de la persona.
        /// </summary>
        string SegundoNombre { get; set; }

        /// <summary>
        /// Primer apellido de la persona.
        /// </summary>
        string PrimerApellido { get; set; }

        /// <summary>
        /// Segundo apellido de la persona.
        /// </summary>
        string SegundoApellido { get; set; }

        /// <summary>
        /// Número de teléfono de la persona.
        /// </summary>
        string Telefono { get; set; }

        /// <summary>
        /// Dirección de residencia de la persona.
        /// </summary>
        string Direccion { get; set; }

        /// <summary>
        /// Identificador único del municipio asociado a la persona.
        /// </summary>
        int IdMunicipio { get; set; }
    }
}
