using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monedero
{
    class Program
    {
        static void Main(string[] args)
        {
            int m50 = 0, m100 = 0, m200 =0, m500 = 0, m1000 = 0, opcionMoneda, opcion, estado = 0, cantMonedas, cantDinero;

            while (estado == 0)
            {
                System.Console.WriteLine("1. Ingresar");
                System.Console.WriteLine("2. Cantidad de dinero");
                System.Console.WriteLine("3. Cantidad de monedas");
                System.Console.WriteLine("4. Cantidad de una moneda");
                System.Console.WriteLine("5. Cantidad dinero con una moneda");

                opcion = System.Convert.ToInt32(System.Console.ReadLine());

                if (opcion == 1)
                {
                    while (true)
                    {
                        System.Console.WriteLine("Ingrese la moneda que quieras ingresar: ");
                        opcionMoneda = System.Convert.ToInt32(System.Console.ReadLine());

                        switch (opcionMoneda)
                        {
                            case 50:
                                m50++;
                                break;
                            case 100:
                                m100++;
                                break;
                            case 200:
                                m200++;
                                break;
                            case 500:
                                m500++;
                                break;
                            case 1000:
                                m1000++;
                                break;
                            default:
                                System.Console.WriteLine("Ingrese una moneda valida");
                                break;
                        }

                        System.Console.WriteLine("¿Quiere ingresar otra moneda?");
                        System.Console.WriteLine("1. Si");
                        System.Console.WriteLine("2. No");
                        int rep = System.Convert.ToInt32(System.Console.ReadLine());

                        if (rep == 2)
                        {
                            break;
                        }
                    }
                }
                else if (opcion == 2)
                {
                    cantDinero = (m50 * 50) + (m100 * 100) + (m200 * 200) + (m500 * 500) + (m1000 * 1000);
                    System.Console.WriteLine("La cantidad de dinero en este momento es: $" + cantDinero + " COP");
                }
                else if (opcion == 3)
                {
                    cantMonedas = m50 + m100 + m200 + m500 + m1000;
                    System.Console.WriteLine("La cantidad de monedas en este momento es: " + cantMonedas + " monedas");
                }
                else if (opcion == 4)
                {
                    while (true)
                    {
                        System.Console.WriteLine("Digita la moneda: ");
                        opcionMoneda = System.Convert.ToInt32(System.Console.ReadLine());

                        switch (opcionMoneda)
                        {
                            case 50:
                                System.Console.WriteLine("La cantidad de monedas de 50 es: " + m50 + " monedas");
                                break;
                            case 100:
                                System.Console.WriteLine("La cantidad de monedas de 100 es: " + m100 + " monedas");
                                break;
                            case 200:
                                System.Console.WriteLine("La cantidad de monedas de 200 es: " + m200 + " monedas");
                                break;
                            case 500:
                                System.Console.WriteLine("La cantidad de monedas de 500 es: " + m500 + " monedas");
                                break;
                            case 1000:
                                System.Console.WriteLine("La cantidad de monedas de 1000 es: " + m1000 + " monedas");
                                break;
                            default:
                                System.Console.WriteLine("Ingrese una moneda valida");
                                break;
                        }

                        System.Console.WriteLine("¿Quiere buscar otra moneda?");
                        System.Console.WriteLine("1. Si");
                        System.Console.WriteLine("2. No");
                        int rep = System.Convert.ToInt32(System.Console.ReadLine());

                        if (rep == 2)
                        {
                            break;
                        }
                    }

                }
                else if (opcion == 5)
                {
                    while (true)
                    {
                        System.Console.WriteLine("Digita la moneda: ");
                        opcionMoneda = System.Convert.ToInt32(System.Console.ReadLine());

                        switch (opcionMoneda)
                        {
                            case 50:
                                System.Console.WriteLine("La cantidad de dinero en monedas 50 es: $" + (m50 * 50) + " COP");
                                break;
                            case 100:
                                System.Console.WriteLine("La cantidad de dinero en monedas 100 es: $" + (m100 * 100) + " COP");
                                break;
                            case 200:
                                System.Console.WriteLine("La cantidad de dinero en monedas 100 es: $" + (m200 * 200) + " COP");
                                break;
                            case 500:
                                System.Console.WriteLine("La cantidad de dinero en monedas 100 es: $" + (m500 * 500) + " COP");
                                break;
                            case 1000:
                                System.Console.WriteLine("La cantidad de dinero en monedas 100 es: $" + (m1000 * 1000) + " COP");
                                break;
                            default:
                                System.Console.WriteLine("Ingrese una moneda valida");
                                break;
                        }

                        System.Console.WriteLine("¿Quiere buscar otra moneda?");
                        System.Console.WriteLine("1. Si");
                        System.Console.WriteLine("2. No");
                        int rep = System.Convert.ToInt32(System.Console.ReadLine());

                        if (rep == 2)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("Opcion invalida");
                }

            }
            System.Console.Read();             
        }
    }
}
