using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCallCentre
{
    public class Reloj : Tiempo
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public Reloj() : base()
        {

        }

        public int GetTiempo()
        {
            base.GetTiempo(out _hours, out _minutes, out _seconds);
            return 3600 * _hours + 60 * _minutes + _seconds;
        }


    }
}
