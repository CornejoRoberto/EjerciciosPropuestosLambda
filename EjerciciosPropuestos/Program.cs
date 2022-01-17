using System;
using System.Collections.Generic;
using System.Linq;

namespace EjerciciosLambda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
                new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla los nombres de los estudiantes
            Console.WriteLine("Nombre de los Estudiantes");
            Estudiante estudent = new Estudiante();
            var nombres = details.Select(item => new { item.Nombre });
            Console.WriteLine(string.Join("", nombres));
            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            Console.WriteLine("Nombres y  Apellidos de los Estudiantes ordenados por promedio");
            var nombresyapellidos = details.OrderByDescending(item => item.Promedio).Select(ite => new { ite.Nombre, ite.Apellido });
            Console.WriteLine(string.Join("\n", nombresyapellidos));
            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            Console.WriteLine("Apellido de los Estudiantes ordenados alfabéticamente");
            var apellidosorde = details.OrderBy(item => item.Apellido).Select(ite => new { ite.Apellido });
            Console.WriteLine(string.Join("\n", apellidosorde));
            //4. Muestre por pantalla los datos del estudiante mas joven
            Console.WriteLine("Datos del estudiante mas joven");
            var masjoven = details.OrderBy(a => a.Edad).First();
            Console.WriteLine(string.Join("\n", "ID:", masjoven.Id, "Nombre:", masjoven.Nombre, "Apellido:", masjoven.Apellido, "Promedio:", masjoven.Promedio, "Edad:", masjoven.Edad, "\n"));


            //SEGUNDA PARTE DEL EJERCICIO 
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla el cuadrado de los números
            Console.WriteLine("Cuadrado de los números");
            var cuadrado = list.Select(x => x * x);
            Console.WriteLine(string.Join(" ", cuadrado));
            //2. Muestre por pantalla los números pares
            Console.WriteLine("Números pares:");
            IEnumerable<int> Pares = (from numeros in list
                                    where numeros % 2 == 0
                                    select numeros).ToList();
            string items = string.Join(Environment.NewLine, Pares);
            Console.WriteLine(items);
            //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            Console.WriteLine("Multiplicación de los números impares");
            IEnumerable<int> Pares2 = (from numeros in list
                                       where numeros % 2 > 0
                                       select numeros).Select(numeros => numeros * 5).ToList();
            string items2 = string.Join(Environment.NewLine, Pares2);
            Console.WriteLine(items2);
        }
    }
}