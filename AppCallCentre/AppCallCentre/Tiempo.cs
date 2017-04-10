using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCallCentre
{
    public class Tiempo
    {
        public DateTime _timeNow;

        public Tiempo()
        {
            _timeNow = DateTime.Now;
        }
         
        public void GetTiempo(out int hora, out int minutos, out int segundos)
        {
            hora = _timeNow.Hour;
            minutos = _timeNow.Minute;
            segundos = _timeNow.Second;

        }

    }
}
