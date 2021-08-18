using System;

namespace Aula01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Digite algo: ");
            Escrever("Resultado: "+Ler());
            Livro MeuLivro = new Livro(1,"2001: Uma Odsséia No Espaço",98);
            Console.WriteLine( MeuLivro.id );
            Console.WriteLine( MeuLivro.nome );
            Console.WriteLine( MeuLivro.valor );
        }

        static void Escrever(string txt)
        {
            Console.WriteLine(txt);
        }

        static string Ler()
        {
            return Console.ReadLine();
            //teste pro git
        }
    }
}
