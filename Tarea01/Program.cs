using System;
using Tarea01;

namespace Tarea01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de CajeroAutomatico
            CajeroAutomatico cajero = new CajeroAutomatico("987654321", "Ana Garcia", 2000.0, 4321);

            while (true)
            {
                Console.WriteLine("Menú de Cajero Automático");
                Console.WriteLine("1. Consultar Saldo");
                Console.WriteLine("2. Depositar Fondos");
                Console.WriteLine("3. Retirar Efectivo");
                Console.WriteLine("4. Cambiar PIN");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Saldo actual: " + cajero.ConsultarSaldo());
                            break;
                        case 2:
                            Console.Write("Ingrese la cantidad a depositar: ");
                            double cantidadDeposito = double.Parse(Console.ReadLine());
                            cajero.Depositar(cantidadDeposito);
                            break;
                        case 3:
                            Console.Write("Ingrese su PIN: ");
                            int pinIngresado = int.Parse(Console.ReadLine());

                            if (cajero.ValidarPIN(pinIngresado))
                            {
                                Console.Write("Ingrese la cantidad a retirar: ");
                                double cantidadRetiro = double.Parse(Console.ReadLine());
                                cajero.Retirar(cantidadRetiro);
                            }
                            else
                            {
                                Console.WriteLine("PIN incorrecto. Transacción cancelada.");
                            }
                            break;
                        case 4:
                            Console.Write("Ingrese el nuevo PIN: ");
                            int nuevoPIN = int.Parse(Console.ReadLine());
                            cajero.CambiarPIN(nuevoPIN);
                            break;
                        case 5:
                            Console.WriteLine("Gracias por usar el Cajero Automático. ¡Hasta luego!");
                            return;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                }

                Console.WriteLine();
            }
        }
    }
}