using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();
            
            string texto;
            string texto2;
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Escreva algo e veja o que vai acontecer: ");

            Console.ForegroundColor = ConsoleColor.White;
            texto = Console.ReadLine();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Seu texto foi M0D1F1C4D0, Aperte \"ENTER\" Para ver...");
            
            Console.ForegroundColor = ConsoleColor.White;
            texto2 = Console.ReadLine();
            Console.WriteLine(texto2);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Seu texto: ");

             Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(texto
            .Replace("A", "4")
            .Replace("a", "4")
            .Replace("E", "3")
            .Replace("e", "3")
            .Replace("I", "1")
            .Replace("i", "1")
            .Replace("L", "1")
            .Replace("l", "1")
            .Replace("O", "0")
            .Replace("o", "0")
            .Replace("T", "7")
            .Replace("t", "7")
            .Replace("S", "5")
            .Replace("s", "5"));

            Console.ResetColor();
            Console.Beep();
        }
    }
}
