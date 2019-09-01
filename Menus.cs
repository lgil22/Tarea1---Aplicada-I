using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2
{
    public class Menus
    {
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.Write("1.Ejercicios Capitulo #1\n" + "2.Ejercicios Capitulo #2\n" + "3.Ejercicios Capitulo #3\n" + "4.Ejercicios Capitulo #4\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
            // if (opc == 1 || opc == 2 || opc == 3 || opc == 4)
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Menu1();
                        Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        Menu2();
                        break;
                    case 3:
                        Console.Clear();
                        Menu3();
                        break;
                    case 4:
                        Console.Clear();
                        Menu4();
                        break;
                }


                /*else
                {
                    Console.WriteLine("No existe Este Ejercicio.");
                }*/

                
            }
        }
        public static void Menu1()
        {
            Console.Clear();
            Console.Write("1.Ejercicio 1: Nombre Propio\n" + "2.Ejercicio 2: String\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
            // if (opc == 1 || opc == 2 || opc == 3 || opc == 4)
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        CAp1.Nombre Nomb = new CAp1.Nombre();
                        Nomb.Nomb();
                        Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        CAp1.Nombre2 mensj = new CAp1.Nombre2();
                        mensj.Mensajes();
                        break;


                }
            }

        }

        public static void Menu2()
        {
            Console.Write("1.Ejercicio 1: Cambio Dolar a Euro\n" + "2.Ejercicio 2:Grados a Radianes\n" + "3.Ejercicio 3: Poligono Regular\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
            // if (opc == 1 || opc == 2 || opc == 3 || opc == 4)
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        CAp2.CambioDolarEuro camb = new CAp2.CambioDolarEuro();
                        camb.Cambio();
                        Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        CAp2.GradosRadianes grad = new CAp2.GradosRadianes();
                        grad.Conversion();
                        break;
                    case 3:
                        Console.Clear();
                        CAp2.PoligonoRegular pog = new CAp2.PoligonoRegular();
                        pog.PoligR();
                        break;

                }

            }
        }
        public static void Menu3()
        {
            Console.Write("1.Ejercicio 1: Area y Perimetro\n" + "2.Ejercicio 2:Numero Semana\n" + "3.Ejercicio 3:Numero Par o Impar\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
            // if (opc == 1 || opc == 2 || opc == 3 || opc == 4)
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        CAp3.AreaPer area = new CAp3.AreaPer();
                        area.Opcion();
                        Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        CAp3.NumSemana semana = new CAp3.NumSemana();
                        semana.Dias();
                        break;
                    case 3:
                        Console.Clear();
                        CAp3.ParImpar par = new CAp3.ParImpar();
                        par.parImp();
                        Console.Read();
                        break;

                }

            }
        }
        public static void Menu4()
        {
            Console.Write("1.Ejercicio 1: Edad Promedio\n" + "2.Ejercicio 2: Tabla Multiplicacion 1-10\n" + "3.Ejercicio 3:Elevacion a la Potencia\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
            // if (opc == 1 || opc == 2 || opc == 3 || opc == 4)
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        CAp4.EdadPromedio edad = new CAp4.EdadPromedio();
                        edad.Prom();
                        Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        CAp4.Mult mult = new CAp4.Mult();
                        mult.tabMult();
                        break;
                    case 3:
                        Console.Clear();
                        CAp4.Potencia pot = new CAp4.Potencia();
                        pot.Elevado();
                        break;

                }

            }
        }

    }
}
