namespace Aula01_HelloWorld
{
    public class Autor
    {
        public int id{get;private set;}
        public string nome{get;private set;}

        public Autor(int id, string nome){
            this.nome = nome;
            this.id = id;
        }
    }
}