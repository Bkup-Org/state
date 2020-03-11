using System;

namespace StatePatronDiseno
{
    class Program
    {
        static void Main(string[] args)
        {
            ServidorContext oServidor = new ServidorContext();
            oServidor.State = new DisponibleServerState();
            oServidor.AtenderSolicitud();
        }
    }
}
