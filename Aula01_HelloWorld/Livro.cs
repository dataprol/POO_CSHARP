namespace Aula01_HelloWorld
{
    public class Livro
    {
        public int id{get;private set;}
        public string nome{get;private set;}
        public string descricao{get;private set;}
        public decimal valor{get;private set;}
        public string isbn{get;private set;}
        public Autor AutorDoLivro;

        public Livro(int id, string nome, decimal valor, Autor AutorPassado){
            this.id = id;
            this.nome = nome;
            this.valor = valor;
            this.AutorDoLivro = AutorPassado;
        }
    }
}