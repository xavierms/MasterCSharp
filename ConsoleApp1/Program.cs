using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //****ToCharArray() Agarra la cadena y obtiene cada uno de sus caracteres y lo almacena en un array
            //string nombre = "pepe come rico";
            //char[] array = nombre.ToCharArray();
            //int c = 0;

            //foreach (int item in array)
            //{
            //    if (item.Equals('e')) c++;                
            //}

            //Console.WriteLine("Se repite la letra e " + c + " veces");
            // --------------------------------------------------------------------------------------//

            //****Substring(indiceInicio, IndiceFin) Toma las letras que elija desde el inicio al final ejemplo: 

            // string passport = "12345678";
            // string nombre = "Pepe Lucho";

            //string past= passport.Substring(0, 3);
            // string nomb =nombre.Substring(0, 3);

            // Console.WriteLine("COD Passport: " + past + nomb);
            // --------------------------------------------------------------------------------------//

            //****Remove(IndiceInicio, IndiceFin) Elimina una porcion de una cadena, recibe un indice y un contador ejemplo:

            //string nuevo = "A0FWOHWR";

            //Console.WriteLine("New string: " + nuevo.Remove(0, 2)) ;

            // --------------------------------------------------------------------------------------//

            //****StartsWith(string) me devuelve el valor string que le asigne


            //string aver = "pollo";
            //if (aver.StartsWith("o"))
            //{
            //    Console.WriteLine("Inicia con P ");
            //}
            //else
            //{
            //    Console.WriteLine("No inicia con p");
            //}
            //Console.WriteLine("LEtra: " + aver.StartsWith("p"));
            //string[] nombres= { "Pepe", "Pedro", "Damian" };
            //int c = 0;
            //foreach (string item in nombres)
            //{
            //    if (item.StartsWith("D")) c++;

            //}
            //Console.WriteLine("Numero de veces " + c);

            // --------------------------------------------------------------------------------------//

            //EndsWith() lo contrario a StarWith()

            //string apellido = "Romam";

            //if (apellido.EndsWith("a"))

            //{
            //    Console.WriteLine("Termina con a");
            //}
            //else
            //{
            //    string ultimaLetra = apellido.Substring(apellido.Length -2, 1);
            //    Console.WriteLine("No termia con m , termina con " + ultimaLetra);
            //}

            // --------------------------------------------------------------------------------------//
            //****Contains()
            //****Split(devuelve un array stirng) sepra las palabras

            //string word = "CartucheraDba";

            //string[] array = word.Split('a');
            //foreach (string item in array)
            //{
            //    Console.Write("  " +item);
            //}

           
        }
    }
}
