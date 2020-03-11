using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatronDiseno
{
    class CaidoServerState : ServerState
    {
        public override void Respuesta()
        {
            Console.WriteLine("Respuesta 503");
        }
    }
}
