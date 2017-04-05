using System;

namespace CentralTelefonica.Entities
{
    public class Celular : Telefono
    {
        string _numero;

        public Celular(string numero)
        {
            _numero = numero;
        }

        public string Numero { get { return _numero; } }

        public double Tarifa(int hora)
        {
            int Hour = DateTime.Now.Hour;

            if (Hour >= 8 && Hour <= 20)
                return 0.03;
            else
                return 0.01;
        }
    }
}
