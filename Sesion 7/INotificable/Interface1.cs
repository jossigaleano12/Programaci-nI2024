using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificable
{
    //Interfaz
    internal interface Interface1
    {
            void Notifica();
   

        // Implementación NotificacionEmail
        public class NotificacionEmail:INotificable
        {
            public string DireccionCorreo { get; set; }

            public NotificacionEmail(string direccionCorreo)
            {
                DireccionCorreo = direccionCorreo;
            }

            public void Notifica()
            {
                Console.WriteLine($"Enviando notificación al correo {DireccionCorreo}");
            }
        }

        // Implementación NotificacionWhatsap
        public class NotificacionWhatsap : INotificable
        {
            public string NumeroTelefono { get; set; }

            public NotificacionWhatsap(string numeroTelefono)
            {
                NumeroTelefono = numeroTelefono;
            }

            public void Notifica()
            {
                Console.WriteLine($"Enviando notificación a WhatsApp al número {NumeroTelefono}");
            }
        }

        // Implementación NotificacionSMS
        public class NotificacionSMS : INotificable
        {
            public string NumeroTelefono { get; set; }

            public NotificacionSMS(string numeroTelefono)
            {
                NumeroTelefono = numeroTelefono;
            }

            public void Notifica()
            {
                Console.WriteLine($"Enviando notificación por SMS al número {NumeroTelefono}");
            }
        }

    }
}
