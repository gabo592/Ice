using System.Drawing;
using System.IO;

namespace Comun.Utilidades
{
    /// <summary>
    /// Clase encargada de manipular imágenes.
    /// </summary>
    public class ImageUtil
    {
        /// <summary>
        /// Convierte un arreglo de bytes de una imagen a un objeto de tipo Image.
        /// </summary>
        /// <param name="bytesImage">Arreglo de bytes que conforman la imagen.</param>
        /// <returns>Imagen construida a partir del arreglo de bytes.</returns>
        public static Image GetImage(byte[] bytesImage)
        {
            MemoryStream stream = new MemoryStream(bytesImage);

            return Image.FromStream(stream);
        }

        /// <summary>
        /// Convierte una imagen a su respectivo arreglo de bytes.
        /// </summary>
        /// <param name="image">Imagen a convertir.</param>
        /// <returns>Arreglo de bytes correspondientes a la imagen.</returns>
        public static byte[] GetBytesImage(Image image)
        {
            MemoryStream stream = new MemoryStream();
            image.Save(stream, image.RawFormat);

            return stream.ToArray();
        }
    }
}
