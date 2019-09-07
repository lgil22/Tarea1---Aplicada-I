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
            Console.Write("1.Ejercicios Capitulo #1\n" + "2.Ejercicios Capitulo #2\n" + "3.Ejercicios Capitulo #3\n" + "4.Ejercicios Capitulo #4\n" + "5.Ejercicios Capitulo #5\n" + "6.Ejercicios Capitulo #6\n" + "7.Ejercicios Capitulo #7\n" + "8.Ejercicios Capitulo #8\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
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
                    case 5:
                        Console.Clear();
                        Menu5();
                        break;
                   case 6:
                        Console.Clear();
                        Menu6();
                        break;
                    case 7:
                        Console.Clear();
                        Menu7();
                        break;
                    case 8:
                        Console.Clear();
                        Menu8();
                        break;

                }

                
            }
        }
        public static void Menu1()
        {
            Console.Clear();
            Console.Write("1.Ejercicio 1: Nombre Propio\n" + "2.Ejercicio 2: String\n\n" +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
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
        public static void Menu5()
        {
            Console.Write("1.Ejercicio 4: Factorial\n" + "2.Ejercicio 5: Cadena\n\n"  +
                "Digite la Opcion Deseada: ");

            int opc = int.Parse(Console.ReadLine());
               {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Tarea2.FactorialNumero fa = new Tarea2.FactorialNumero();
                        fa.numero();
                        break;
                    case 2:
                        Console.Clear();
                        Tarea2.Cadena caden = new Tarea2.Cadena();
                        caden.Palabras();
                        break;
                }

            }
        }
        public static void Menu6()
        {
            Console.Write("1.Ejercicio 1,2,3: Promedio y Calificaciones\n"  + "2.Ejercicio 4: Jagged Funcion\n" +
                "\nDigite la Opcion Deseada: ");
            int opc = int.Parse(Console.ReadLine());
             {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Tarea2.PromedioCalif pcal = new Tarea2.PromedioCalif();
                        pcal.promcal();
                        break;
                    case 2:
                        Console.Clear();
                        Tarea2.JaggedFuncion func = new Tarea2.JaggedFuncion();
                        func.funtion();
                        break;
                }

            }
        }

        public static void Menu7()
        {
            Console.Write("1.Ejercicio 1: ArrayList\n" + "2.Ejercicio 4: HashTable\n" + "3.Ejercicio 5: Agenda Telefonica\n\n" +
                "\nDigite la Opcion Deseada: ");
            int opc = int.Parse(Console.ReadLine());
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Tarea2.Arreglo arr = new Tarea2.Arreglo();
                        arr.list();
                        break;
                    case 2:
                        Console.Clear();
                        Tarea2.Hash has = new Tarea2.Hash();
                        has.hash();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Tarea2.AgendaTelefonica agenda = new Tarea2.AgendaTelefonica();
                        agenda.agend();
                        break;

                }

            }
        }

        public static void Menu8()
        {
            Console.Write("1.Ejercicio 3: Hora Am-Pm\n" + "2.Ejercicio 5: Cadenas\n\n" +
                "\nDigite la Opcion Deseada: ");
            int opc = int.Parse(Console.ReadLine());
            {
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Tarea2.HORAampm hor = new Tarea2.HORAampm();
                        hor.AMPM();
                        break;
                   case 2:
                        Console.Clear();
                        Tarea2.DosCadenas cad = new Tarea2.DosCadenas();
                        cad.cadens();
                        Console.ReadKey();
                        break;
                }

            }
        }






















    }

}
