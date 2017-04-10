using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCallCentre
{
    public class Fijo : Telefono
    {

        private string _numero;
        public Fijo(string numero)
        {
            _numero = numero;
        }

        public string Numero
        {
            get { return _numero; }

        }

        public double Tarifa(int hora)
        {
            return 0.02;
        }



    }
}
