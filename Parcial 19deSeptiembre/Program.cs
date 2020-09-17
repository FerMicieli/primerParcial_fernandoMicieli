using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_16deSeptiembre
{
    class Program
    {
        static void Main(string[] args)
        {
            int opciones = 0;
            int camisas = 0;
            float precio_sin_descuento = 0;
            float precio_con_descuento = 0;
            float porcentaje = 0;
            string desea_salir;


            do
            {
                if (camisas == 0)
                {
                    precio_sin_descuento = 0;
                    precio_con_descuento = precio_sin_descuento;
                    porcentaje = 0;
                }
                else if (camisas >= 1 && camisas <= 2)
                {
                    precio_sin_descuento = 1000 + precio_sin_descuento;
                    precio_con_descuento = precio_sin_descuento;
                    porcentaje = 0;
                }
                else if (camisas >= 3 && camisas <= 5)
                {
                    precio_con_descuento = (precio_sin_descuento - (precio_sin_descuento/10));
                    porcentaje = 10;
                }
                else if (camisas >= 6)
                {
                    precio_con_descuento = (precio_sin_descuento - (precio_sin_descuento/5));
                    porcentaje = 20;
                }

                Console.WriteLine("Camisas PRADBIT – Ventas minoristas y mayoristas");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("MENÚ PRINCIPAL:");
                Console.WriteLine("1- Añadir camisa al carro de compras");
                Console.WriteLine("2- Eliminar camisa del carro de compras");
                Console.WriteLine("3- Salir");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("         - Cantidad de camisas en el carro de compras: " + camisas);
                Console.WriteLine("         - Precio unitario: $1000");
                Console.WriteLine("         - Precio total sin descuento: $" + precio_sin_descuento);
                Console.WriteLine("         - Tipo de descuento aplicado: " + porcentaje + "%");
                Console.WriteLine("         - Precio final con descuento: $" +precio_con_descuento);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Ingrese una opción del menú:");
                
                opciones = Convert.ToInt32(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                        Console.WriteLine("Se ha agregado una camisa al carrito");
                        camisas++;
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 2:
                        Console.WriteLine("Se ha eliminado una camisa del carrito de compras");
                        if (camisas >= 0)
                        {
                            camisas--;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 3:
                        Console.Clear();
                        Console.WriteLine("¿Está seguro que desea salir? S/N");
                        desea_salir = Console.ReadLine();
                        if (desea_salir == "S")
                        {
                            Console.WriteLine("Gracias, vuelva pronto");
                        }
                        else if (desea_salir == "N")
                        {
                            Console.WriteLine("Siga comprando!");
                            opciones = 0;
                        }
                        else
                        {
                            Console.WriteLine("Ha ingresado un caracter incorrecto");
                            opciones = 0;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opciones != 3);

            Console.WriteLine("Presione una tecla para salir del programa");
            Console.ReadKey();


        }
    }
}
