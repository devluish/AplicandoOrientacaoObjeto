// Curso C#: Aplicando a Orientação a Objeto

// Classe que contém a execução: Cria objetos( musica1, musica2) e atribui valores e chama métodos.

Musica musica1 = new Musica();
musica1.Nome = "Smile";
musica1.Artista = "Ed Motta";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1);

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 313;
musica2.Disponivel = false;   

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

