using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace gymsy.utilities
{
    public class Verify
    {
        public static bool IsConnectedToNetwork()
        {
            try
            {
                // Intenta enviar una solicitud de ping a un servidor conocido de Google
                Ping ping = new Ping();
                PingReply respuesta = ping.Send("www.google.com", 3000); // 3000 representa el tiempo de espera en milisegundos

                // Verifica si la respuesta es exitosa
                return respuesta.Status == IPStatus.Success;
            }
            catch (Exception)
            {
                // Si hay una excepción, asumimos que no hay conexión a Internet
                return false;
            }
        }
    }
}
