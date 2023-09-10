using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar una variable int para opciones

            int opciones;
            do
            {
                Console.WriteLine("\n-------------------MENÚ-----------------");
                Console.WriteLine("1. Sumar pares hasta 75 ");
                Console.WriteLine("2. Recorrer una lista de 9 numeros");
                Console.WriteLine("3. Tabla de multiplicar del 1 al 12 ");
                Console.WriteLine("4. Salir ");
                Console.WriteLine("Seleccione una opción (1-4)");
                Console.WriteLine("-------------------------------------------");

                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {
                        case 1:
                            int suma = 0;

                            for (int i = 2; i <= 75; i += 2)
                            {
                                suma += i;
                            }
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nLa suma de los números pares hasta 75 es: " + suma);
                            Console.ResetColor();
                            break;

                        case 2:
                            //Declaraar una lista

                            List<int> numeros = new List<int> { 13, 20, 75, 29, 19, 7 };

                            int mayor = numeros[0]; //Inicializar con valor del indice 0

                            foreach (int numero1 in numeros)
                            {
                                if (numero1 > mayor)
                                {
                                    mayor = numero1; //Actualizar el valor minimo
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nEl número mas grande en la lista es > " + mayor);
                            Console.ResetColor();
                            break;

                        case 3:
                            Console.WriteLine("\nInrese un número para elborar su tabla de multiplicar: ");
                            int numero = Convert.ToInt32(Console.ReadLine());

                            for (int i = 1; i <= 12; i++)
                            {
                                int resultado = numero * i + 2;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"\n{numero} x {i} + 2 = {resultado}");
                                Console.ResetColor();
                            }

                            break;

                        case 4:

                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOpción no válida. Por favor, selecione una opción válida");
                            Console.ResetColor();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada no válida. Debe ingresar un número (1-4)\n");
                }

            } while (opciones != 4);
        }
    }
}
