using Observador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    /// Suscriptor que registra eventos en un archivo de log.
    public class RegistroEventos : IEscuchaEvento
    {
        private string archivoLog;
        private string mensaje;

        public RegistroEventos(string archivoLog, string mensaje)
        {
            this.archivoLog = archivoLog;
            this.mensaje = mensaje;
        }
        /// Escribe en el archivo de log cuando ocurre un evento.
        public void Actualizar(string nombreArchivo)
        {
            string logMensaje = mensaje.Replace("%s", nombreArchivo);
            File.AppendAllText(archivoLog, logMensaje + Environment.NewLine);
        }
    }
}
