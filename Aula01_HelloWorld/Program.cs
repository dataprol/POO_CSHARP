using System;

namespace Aula01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
            Console.WriteLine("Digite algo: ");
            Escrever("Resultado: "+Ler()); */

            Autor Castro = new Autor(1,"Castro Alves");
            Autor Elis = new Autor(2,"Elisabet");
            Autor Albert = new Autor(3,"Albert Einstein");
            Livro MeuLivro = new Livro(1,"2001: Uma Odsséia No Espaço",98,Albert);
            Livro MeuLivro2 = new Livro(2,"Sábados Gerais",218,Elis);
            Livro MeuLivro3 = new Livro(3,"Descobrimento do Brasil",198,Castro);

            Console.WriteLine("Livro:");
            Console.WriteLine("------");
            Console.WriteLine( MeuLivro.id );
            Console.WriteLine( MeuLivro.nome );
            Console.WriteLine( MeuLivro.valor );
            Console.WriteLine("Autor:");
            Console.WriteLine( MeuLivro.AutorDoLivro.id);
            Console.WriteLine( MeuLivro.AutorDoLivro.nome);

            Console.WriteLine("Livro:");
            Console.WriteLine("------");
            Console.WriteLine( MeuLivro2.id );
            Console.WriteLine( MeuLivro2.nome );
            Console.WriteLine( MeuLivro2.valor );
            Console.WriteLine("Autor:");
            Console.WriteLine( MeuLivro2.AutorDoLivro.id);
            Console.WriteLine( MeuLivro2.AutorDoLivro.nome);

            Console.WriteLine("Livro:");
            Console.WriteLine("------");
            Console.WriteLine( MeuLivro3.id );
            Console.WriteLine( MeuLivro3.nome );
            Console.WriteLine( MeuLivro3.valor );
            Console.WriteLine("Autor:");
            Console.WriteLine( MeuLivro3.AutorDoLivro.id);
            Console.WriteLine( MeuLivro3.AutorDoLivro.nome);
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
