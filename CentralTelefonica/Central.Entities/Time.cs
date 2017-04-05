using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Time
    {
        private DateTime _timeNow;

        public Time()
        {
            _timeNow = DateTime.Now;
        }

        protected void GetTime(out int horas, out int minutos, out int segundos)
        {
            horas = _timeNow.Hour;
            minutos = _timeNow.Minute;
            segundos = _timeNow.Second;
        }
    }
}
