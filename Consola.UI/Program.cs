using System;
using Calculadora.Negocio;

namespace Consola.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Calculadora-----");
            Console.WriteLine("Favor ingresar solo numeros enteros.");
            Console.WriteLine("Ingrese el primer valor: ");
            int elPrimerValor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            int elSegundoValor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seleccione que desea realizar: ");
            Console.WriteLine("     1 -> Sumar: ");
            Console.WriteLine("     2 -> Restar: ");
            Console.WriteLine("     3 -> Multiplicar: ");
            Console.WriteLine("     4 -> Dividir: ");
            String Opcion = Console.ReadLine();
            RealiceElCalculo(elPrimerValor,elSegundoValor,Opcion);
            Console.WriteLine("Muchas gracias por utilizar nuestra calculadora ");
            Console.ReadKey();

        }

        static void RealiceElCalculo(int PrimerValor, int SegundoValor, String opcion)
        {
            Metodo metodo = new Metodo();
            float elResultado;
            switch (opcion) {
                case "1":
                    elResultado = metodo.Sumar(PrimerValor, SegundoValor);
                    Console.WriteLine("El resultado de la suma es: "+ elResultado.ToString());
                    break;
                case "2":
                    elResultado = metodo.Reste(PrimerValor, SegundoValor);
                    Console.WriteLine("El resultado de la resta es: " + elResultado.ToString());
                    break;
                case "3":
                    elResultado = metodo.Multiplique(PrimerValor, SegundoValor);
                    Console.WriteLine("El resultado de la multiplica es: " + elResultado.ToString());
                    break;
                case "4":
                    elResultado = metodo.Divida(PrimerValor, SegundoValor);
                    Console.WriteLine("El resultado de la division  es: " + elResultado.ToString());
                    break;
                default:
                    Console.WriteLine("La opción seleccionada no es valida " );
                    break;
            }
        }
    }
}
