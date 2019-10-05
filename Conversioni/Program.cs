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
            string risposta;
            Console.WriteLine("Come vuoi convertire il numero decimale? (binary/hexadecimal/octal/esci)");
            risposta = Console.ReadLine();
            string binarynumber;
            string hexadecimalnumber;
            string octalnumber;
            try
            {
                if (risposta == "binary")
                {
                    binarynumber = LibreriaConversioni.LibreriaConversioni.ToBinary(decimale);
                    Console.Write($"Il numero decimale in binario è {binarynumber}");
                }
                else if (risposta == "hexadecimal")
                {
                    hexadecimalnumber = LibreriaConversioni.LibreriaConversioni.ToHexadecimal(decimale);
                    Console.Write($"Il numero decimale in esadecimale è {hexadecimalnumber}");
                }
                else if (risposta == "octal")
                {
                    octalnumber = LibreriaConversioni.LibreriaConversioni.ToOctal(decimale);
                    Console.Write($"Il numero decimale in ottale è {octalnumber}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (risposta == "esci")
            {
                Console.WriteLine("Ciao");
            }
            Console.ReadLine();
        }
        
    }
}
