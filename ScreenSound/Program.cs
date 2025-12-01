Album album = new Album();
album.Nome = "Wiped Out!";

Banda theNeighbourhood = new Banda();

Genero indie = new Genero();

indie.Nome = "Indie";

Musica musica1 = new Musica();

musica1.Nome = "Iris";
musica1.Artista = "The Goo Goo Dolls";
musica1.Nota = 5.0f;

Musica musica2 = new Musica();

musica2.Nome = "The Beach";
musica2.Artista = "The Neighbourhood";
musica2.Genero = indie;
musica2.Disponivel = true;
musica2.Duracao = 214;
musica2.Nota = 5.0f;

Musica musica3 = new Musica();

musica3.Nome = "Wiped Out!";
musica3.Artista = "The Neighbourhood";
musica3.Genero = indie;
musica3.Disponivel = true;
musica3.Duracao = 341;
musica3.Nota = 1.0f;

album.AdicionarMusica(musica2);
album.AdicionarMusica(musica3);

theNeighbourhood.AddAlbum(album);

theNeighbourhood.ExibirDiscografia();