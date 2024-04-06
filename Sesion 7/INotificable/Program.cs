using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Notificable.Interface1;

namespace Notificable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificable notificacionEmail = new NotificacionEmail("example@example.com");
            notificacionEmail.Notifica();

            INotificable notificacionWhatsap = new NotificacionWhatsap("123456789");
            notificacionWhatsap.Notifica();

            INotificable notificacionSMS = new NotificacionSMS("987654321");
            notificacionSMS.Notifica();
        }
    }
}
