class Banda
{
    private List<Album> albums = new List<Album>();


    public Banda(string nome)
    {
        Nome = nome;
    }

    // Quando coloca somente opção de leitura você precisa inicializar o valor no construturo ou fornecer um valor.
    public string Nome {  get; }
    

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}