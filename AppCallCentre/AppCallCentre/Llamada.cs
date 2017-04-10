using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCallCentre
{
    public class Llamada
    {
        private Reloj _reloj;
        private Telefono _telefono;

        public Llamada(Telefono fono)
        {
            _telefono = fono;
            _reloj = new Reloj();

        }

        public double Tarifa ()
        {
            return _telefono.Tarifa(DateTime.Now.Hour);
        }

        public Telefono Telefono { get { return _telefono; } }

        public Reloj Reloj { get { return _reloj; } }



    }
}
