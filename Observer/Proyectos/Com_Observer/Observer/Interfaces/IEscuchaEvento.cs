using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observador.Interfaces
{
    /// Define la estructura para los suscriptores que reaccionan a eventos.

    public interface IEscuchaEvento
    {
        /// Método que se ejecuta cuando ocurre un evento.

        /// <param name="nombreArchivo">El nombre del archivo afectado.</param>
        void Actualizar(string nombreArchivo);
    }
}
