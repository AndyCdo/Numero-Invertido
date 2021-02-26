using System;

namespace Numero_Invertido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero de tres digitos: ");
            string numero= Console.ReadLine();
            string numeroInvertido= "";
            foreach(char letra in numero){
                numeroInvertido=letra + numeroInvertido;

            }
            Console.WriteLine("El Numero Invertido es " + numeroInvertido);

        }
    }
}
