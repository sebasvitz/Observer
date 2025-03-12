using Observador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    /// Suscriptor que envía una notificación por correo cuando ocurre un evento.
    public class NotificacionCorreo : IEscuchaEvento
    {
        private string correo;
        private string mensaje;

        public NotificacionCorreo(string correo, string mensaje)
        {
            this.correo = correo;
            this.mensaje = mensaje;
        }

        /// Simula el envío de un correo electrónico cuando ocurre un evento.
        public void Actualizar(string nombreArchivo)
        {
            Console.WriteLine($"Enviando correo a {correo}: {mensaje.Replace("%s", nombreArchivo)}");
        }
    }
}
