Album album = new Album("Wiped Out!");

Banda theNeighbourhood = new Banda("The Neighbourhood");
Genero indie = new Genero("Indie");
Musica musica2 = new Musica(theNeighbourhood);

musica2.Nome = "The Beach";
musica2.Genero = indie;
musica2.Disponivel = true;
musica2.Duracao = 214;
musica2.Nota = 5.0f;

Musica musica3 = new Musica(theNeighbourhood);

musica3.Nome = "Wiped Out!";
musica3.Genero = indie;
musica3.Disponivel = true;
musica3.Duracao = 341;
musica3.Nota = 1.0f;

album.AdicionarMusica(musica2);
album.AdicionarMusica(musica3);

theNeighbourhood.AddAlbum(album);

album.MostrarMusicas();
theNeighbourhood.ExibirDiscografia();