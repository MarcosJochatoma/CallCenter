using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCallCentre
{
    public class Central
    {
        List<Telefono> _Telefonos;
        List<Llamada> _Llamadas;

        public Central()
        {
            _Telefonos = new List<Telefono>();
            _Llamadas = new List<Llamada>();
        }

        public void Agregar(String numero)
        {
            if (_Telefonos.Count == 100)
                return;


            if (numero[0] == '9')
                _Telefonos.Add(new Celular(numero));
            else
                _Telefonos.Add(new Fijo(numero));
        }

        public void Eliminar(String numero)
        {
            if (numero[0] == 9)
                _Telefonos.Remove(new Celular(numero));
            else
                _Telefonos.Remove(new Fijo(numero));
 
        }


        public void IniciarLlamada(String numero)
        {
            if (_Llamadas.Count == 50)
                return;

            Telefono _fonoDestino = _Telefonos.Find(t => t.Numero == numero);

            Llamada _llamada = new Llamada(_fonoDestino);

            _Llamadas.Add(_llamada);

            Console.WriteLine("Llamada Iniciada [{0}]", numero);
        }

        public double FinalizarLlamada(string numero)
        {
            Telefono _fonoDestino = _Telefonos.Find(t => t.Numero == numero);

            if (_fonoDestino == null)
                return 0;

            Llamada _llamada = _Llamadas.Find(ll => ll.Telefono.Numero == _fonoDestino.Numero);

            if (_llamada == null)
                return 0;

            var duracion = new Reloj().GetTiempo() - _llamada.Reloj.GetTiempo();

            double _costoLlamada = duracion * _llamada.Tarifa();

            _Llamadas.Remove(_llamada);

            Console.WriteLine("Llamada Finalizada [{0}]", numero);
            Console.WriteLine("Costo de Llamada[S/{0}]", _costoLlamada.ToString());
            Console.WriteLine();

            return _costoLlamada;
        }


    }
}
