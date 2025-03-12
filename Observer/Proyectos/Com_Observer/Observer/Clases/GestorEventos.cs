using Observador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    /// Administra la suscripción y notificación de eventos.
    public class GestorEventos
    {
        private Dictionary<string, List<IEscuchaEvento>> suscriptores = new();

        /// Suscribe un oyente a un evento específico.
        public void Suscribir(string tipoEvento, IEscuchaEvento oyente)
        {
            if (!suscriptores.ContainsKey(tipoEvento))
                suscriptores[tipoEvento] = new List<IEscuchaEvento>();

            suscriptores[tipoEvento].Add(oyente);
        }

        /// Elimina la suscripción de un oyente a un evento.
        public void Desuscribir(string tipoEvento, IEscuchaEvento oyente)
        {
            if (suscriptores.ContainsKey(tipoEvento))
                suscriptores[tipoEvento].Remove(oyente);
        }

        /// Notifica a los oyentes cuando ocurre un evento.
        public void Notificar(string tipoEvento, string nombreArchivo)
        {
            if (suscriptores.ContainsKey(tipoEvento))
            {
                foreach (var oyente in suscriptores[tipoEvento])
                    oyente.Actualizar(nombreArchivo);
            }
        }
    }
}
