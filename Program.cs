using System;

namespace CalculoPromedio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string categoria1 = "35%";
            string categoria2 = "25%";
            string categoria3 = "10%";
            double valorCategoria1;
            double valorCategoria2;
            double valorCategoria3;
            double precio = 1000;
            double valorTotal;
            double totalDescuento;
            int edad;
            int totalCliente;

            //Fase de Inicializacion
            valorCategoria1 = 0.35;
            valorCategoria2 = 0.25;
            valorCategoria3 = 0.10;
            totalDescuento = 0;
            totalCliente = 0;
            valorTotal = 0;
            edad = 0;

            Console.WriteLine("============================================Sistemas Avanzados HJ2k de P.E.============================================");

            Console.WriteLine("*************************Bienvenido al Sistema de Tickets del Teatro Silencio del Desierto*****************************");

            Console.WriteLine("=======================================Costo Ticket Entrada Regular RD$ 1.000,00=======================================");

            Console.WriteLine("");

            Console.WriteLine("--------------------------------Aproveche esta noche descuento especial por categorías---------------------------------");

            Console.WriteLine("-----------------------------------------CATEGORIA I EDAD ENTRE    5 Y 14 35%------------------------------------------");

            Console.WriteLine("-----------------------------------------CATEGORIA II EDAD ENTRE  15 Y 19 25%------------------------------------------");

            Console.WriteLine("-----------------------------------------CATEGORIA III EDAD ENTRE 20 Y 45 10%------------------------------------------");

            Console.WriteLine("-----------------------------------------CATEGORIA 4 EDAD ENTRE   46 Y 65 25%------------------------------------------");

            Console.WriteLine("-----------------------------------------CATEGORIA 5 EDAD         66+     35%------------------------------------------");

            Console.WriteLine("*****************************************CATEGORIA INFANTE -5    NO PERMITIDOS*****************************************");

            Console.WriteLine("");

            Console.WriteLine("*****TODO EL PUBLICO EN GENERAL RECUERDEN QUE LA NOTA DE 16-SIIN-1-016 DE LA EXPOSICION DE GMAPS NO LE FUE PUBLICADA***");

	    Console.WriteLine("");

            Console.WriteLine("");

            Console.WriteLine("-----------------------Buenas Noches Por Favor Indique la edad del cliente Para Pedido de Tickets---------------------");



            // Instrucción en la que se pide la edad del Cliente
            Console.WriteLine("Escriba la Edad del cliente o -1 para salir: ");
            edad = Convert.ToInt32(Console.ReadLine());


            while (edad != -1)
            {
                totalCliente = totalCliente + 1;
                valorTotal = precio - totalDescuento;


                if (edad > 65)
                {
                    totalDescuento = precio * valorCategoria1;
                    valorTotal = precio - totalDescuento;

                    Console.WriteLine("El valor del Descuento para esta edad es: {0}\n y el monto a descontar es: {1}", categoria1, totalDescuento);
                    Console.WriteLine("El valor a pagar es: {0}", valorTotal);

                    Console.WriteLine("Escriba la Edad del cliente o -1 para salir: ");
                    precio = Convert.ToInt32(Console.ReadLine());

                }
                else if (edad >= 46 && edad <= 65)
                {
                    totalDescuento = precio * valorCategoria2;
                    valorTotal = precio - totalDescuento;

                    Console.WriteLine("El valor del Descuento para esta edad es: {0}\n y el monto a descontar es: {1}", categoria2, totalDescuento);
                    Console.WriteLine("El valor a pagar es: {0}", valorTotal);

                    Console.WriteLine("Escriba la Edad del cliente o -1 para salir: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                }
                else if (edad >= 20 && edad <= 45)
                {
                    totalDescuento = precio * valorCategoria3;
                    valorTotal = precio - totalDescuento;

                    Console.WriteLine("El valor del Descuento para esta edad es: {0}\n y el monto a descontar es: {1}", categoria3, totalDescuento);
                    Console.WriteLine("El valor a pagar es: {0}", valorTotal);

                    Console.WriteLine("Escriba la Edad del cliente o -1 para salir: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                }
                else if (edad >= 15 && edad <= 19)
                {
                    totalDescuento = precio * valorCategoria2;
                    valorTotal = precio - totalDescuento;

                    Console.WriteLine("El valor del Descuento para esta edad es: {0}\n y el monto a descontar es: {1}", categoria2, totalDescuento);
                    Console.WriteLine("El valor a pagar es: {0}", valorTotal);

                    Console.WriteLine("Escriba la Edad del cliente o -1 para salir: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                }
                else if (edad >= 5 && edad <= 14)
                {
                    totalDescuento = precio * valorCategoria1;
                    valorTotal = precio - totalDescuento;

                    Console.WriteLine("El valor del Descuento para esta edad es: {0}\n y el monto a descontar es: {1}", categoria1, totalDescuento);
                    Console.WriteLine("El valor a pagar es: {0}", valorTotal);

                    Console.WriteLine("Escriba la Edad del cliente o -1 para salir: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                }
                else if (edad < 5)
                {

                    Console.WriteLine("El cliente no es permitido lleva ese muchacho a dormir por favor, mira digita una edad permitida si");

                    Console.WriteLine("Escriba la Edad del cliente o -1 para salir: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
