using CentralTelefonica.Entities;
using System.Threading;

namespace CentralTelefonica.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fono1 = "4563245";
            var fono2 = "4703688";

            var fono3 = "952365447";
            var fono4 = "988742522";
            var fono5 = "956403978";


            var central = new Central();

            central.Agregar(fono1);
            central.Agregar(fono2);

            central.Agregar(fono3);
            central.Agregar(fono4);
            central.Agregar(fono5);


            central.IniciarLlamada(fono1);
            Thread.Sleep(5500); //duracion de llamada en milisegundos
            central.FinalizarLlamada(fono1);

            central.IniciarLlamada(fono5);
            Thread.Sleep(3000); //duracion de llamada en milisegundos
            central.FinalizarLlamada(fono5);

            central.IniciarLlamada(fono2);
            Thread.Sleep(2500); //duracion de llamada en milisegundos
            central.FinalizarLlamada(fono2);

            central.IniciarLlamada(fono3);
            Thread.Sleep(4000); //duracion de llamada en milisegundos
            central.FinalizarLlamada(fono3);

            central.IniciarLlamada(fono4);
            Thread.Sleep(3500); //duracion de llamada en milisegundos
            central.FinalizarLlamada(fono4);
        }
    }
}
