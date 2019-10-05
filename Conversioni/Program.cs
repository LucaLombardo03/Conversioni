using System;

namespace Conversioni
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimale = 0;
            Console.Write("Inserisci un numero decimale: ");
            decimale = int.Parse(Console.ReadLine());
            string binary = (Convert.ToString(decimale, 2));
            Console.Write($"Il numero decimale in binario è {binary}");
            Console.ReadLine();
        }
    }
}
