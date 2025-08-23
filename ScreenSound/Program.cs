// Curso C#: Aplicando a Orientação a Objeto

// Classe que contém a execução: Cria objetos( musica1, musica2) e atribui valores e chama métodos.

Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

// Inicializadores -> Procurar na documentação "Propriedade e Listas"
Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{ 
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);
albumDoQueen.ExibirMusicasDoAlbum();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.ExibirDiscografia();

