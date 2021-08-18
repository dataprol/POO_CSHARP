using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Digite algo: ");
            Escrever("Resultado: "+Ler());
        }

        static void Escrever(string txt)
        {
            Console.WriteLine(txt);
        }

        static string Ler()
        {
            return Console.ReadLine();
        }
    }
}
