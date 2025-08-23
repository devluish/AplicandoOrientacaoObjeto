using System.Collections.Concurrent;

// Classe que contém a definição (Atributos + Métodos)
class Musica
{
    // Construtor -> Caracteristica: Não tem retorno (O nome dele é o tipo) 
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }


    // Quando faz a utilização do get e set precisa padronizar a nomenclatura para Pascal
    public string Nome {  get; }
    public Banda Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    // Estudar esse formato onde pegou o Genero da classe genero
  
    public Genero Genero { get; set; }
    // Lambda utilizando arrow function - Pertence somente ao GET "MODO LEITURA"
    public string DescricaoResumida => 
        $"A música {Nome} pertence à banda {Artista}";
    //{
    //    get
    //    {
    //        return $"A música {Nome} pertence à banda {Artista}";
    //    }
    //} // Atalho prop

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano plus+");
        }
    }
}


