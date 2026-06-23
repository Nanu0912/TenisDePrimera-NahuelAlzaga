using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDP.BLL499NA
{
    public class TraductorBLL499NA
    {
        public Dictionary<string, string> CargarTraducciones(string nombreArchivo)
        {
            // Ruta física: Carpeta 'Idiomas' en el directorio de ejecución
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Idiomas", nombreArchivo);
            Dictionary<string, string> traducciones = new Dictionary<string, string>();

            if (!File.Exists(path))
            {
                // Lanza la excepción que captura el bloque 'alt' del diagrama
                throw new FileNotFoundException($"El archivo de traducción '{nombreArchivo}' no existe o está corrupto.");
            }

            foreach (string linea in File.ReadAllLines(path))
            {
                if (!string.IsNullOrWhiteSpace(linea) && linea.Contains("="))
                {
                    var partes = linea.Split(new[] { '=' }, 2);
                    traducciones[partes[0].Trim()] = partes[1].Trim();
                }
            }
            return traducciones;
        }
    }
}
