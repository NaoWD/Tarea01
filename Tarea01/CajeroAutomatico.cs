using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01
{
    class CajeroAutomatico : CuentaBancaria
    {
        private double LimiteDiarioRetiro = 1000;

        public CajeroAutomatico(string numeroCuenta, string titularCuenta, double saldo, int pinSeguridad)
            : base(numeroCuenta, titularCuenta, saldo, pinSeguridad)
        {
        }

        // Agregar métodos de la clase CajeroAutomatico aquí...

        public void MostrarInformacion()
        {
            Console.WriteLine("Información de la cuenta:");
            Console.WriteLine("Número de cuenta: " + NumeroCuenta);
            Console.WriteLine("Titular de la cuenta: " + TitularCuenta);
            Console.WriteLine("Saldo: " + ConsultarSaldo());
        }
    }
}