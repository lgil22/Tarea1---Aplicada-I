using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.Tarea2
{
    public class Hash
    {
        public void hash()
        {
            Hashtable palabra = new Hashtable();
            Diccionario diccionario = new Diccionario();
            diccionario.frase = "Computadora";
            diccionario.definicion = "Máquina electrónica que, mediante determinados programas, permite almacenar y tratar información, y resolver problemas de diversa índole.";
            palabra.Add("1", diccionario);

            Diccionario diccionario1 = new Diccionario();
            diccionario1.frase = "Algoritmo";
            diccionario1.definicion = "Conjunto ordenado y finito de operaciones que permite hallar la solución de un problema.";
            palabra.Add("2", diccionario1);

            Diccionario diccionario2 = new Diccionario();
            diccionario2.frase = "Programa";
            diccionario2.definicion = "Idear y ordenar las acciones necesarias para realizar un proyecto.";
            palabra.Add("3", diccionario2);

            Diccionario diccionario3 = new Diccionario();
            diccionario3.frase = "Consola";
            diccionario3.definicion = "Dispositivo que, integrado o no en una máquina, contiene los instrumentos para su control y operación.";
            palabra.Add("4", diccionario3);

            foreach (DictionaryEntry datos in palabra) {
                Console.WriteLine("\t{0}:\t{1}", datos.Key, datos.Value);
                Console.WriteLine();
                Console.ReadKey();
            }

        }
    }
      public  class Diccionario
        {
            public string frase;
            public string definicion;

            public Diccionario()
            {
                frase = "";
                definicion = "";
              Console.ReadKey();
        }
                public override string ToString()
            {
                return " Frase: " + frase + "\n   Definicion: " + definicion;
            }
    }

}
