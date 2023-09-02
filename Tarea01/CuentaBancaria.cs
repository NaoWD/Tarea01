using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01
{
    class CuentaBancaria
    {
        public string NumeroCuenta { get; private set; }
        public string TitularCuenta { get; private set; }
        private double Saldo { get; set; }
        private int PinSeguridad { get; set; }

        public CuentaBancaria(string numeroCuenta, string titularCuenta, double saldo, int pinSeguridad)
        {
            NumeroCuenta = numeroCuenta;
            TitularCuenta = titularCuenta;
            Saldo = saldo;
            PinSeguridad = pinSeguridad;
        }

        public double ConsultarSaldo()
        {
            return Saldo;
        }

        public bool ValidarPIN(int pin)
        {
            return pin == PinSeguridad;
        }

        public void Depositar(double cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
                Console.WriteLine("Depósito exitoso. Nuevo saldo: " + Saldo);
            }
            else
            {
                Console.WriteLine("Cantidad de depósito inválida.");
            }
        }

        public void Retirar(double cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("Cantidad de retiro inválida.");
                return;
            }

            if (cantidad > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para el retiro.");
                return;
            }

            Saldo -= cantidad;
            Console.WriteLine("Retiro exitoso. Nuevo saldo: " + Saldo);
        }

        public void CambiarPIN(int nuevoPIN)
        {
            if (nuevoPIN == PinSeguridad)
            {
                Console.WriteLine("El nuevo PIN no puede ser igual al PIN actual.");
                return;
            }

            PinSeguridad = nuevoPIN;
            Console.WriteLine("PIN actualizado con éxito.");
        }
    }
}