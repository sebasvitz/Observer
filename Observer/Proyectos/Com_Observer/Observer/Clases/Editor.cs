using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{

    /// Representa un editor de archivos que genera eventos al abrir o guardar archivos.
    public class Editor
    {
        public GestorEventos Eventos { get; } = new();
        private string archivo;

        /// Simula la apertura de un archivo y notifica a los suscriptores.
        public void AbrirArchivo(string ruta)
        {
            archivo = ruta;
            Eventos.Notificar("abrir", archivo);
        }

        /// Simula el guardado de un archivo y notifica a los suscriptores.
        public void GuardarArchivo()
        {
            File.WriteAllText(archivo, "Contenido actualizado...");
            Eventos.Notificar("guardar", archivo);
        }
    }
}
