Album album = new Album("Wiped Out!");

Banda theNeighbourhood = new Banda("The Neighbourhood");
Genero indie = new Genero("Indie");
Musica musica2 = new Musica(theNeighbourhood, "The Beach", indie)
{
    Disponivel = true,
    Duracao = 214,
    Nota = 5.0f
}; 

Musica musica3 = new Musica(theNeighbourhood, "Wiped Out!", indie)
{ 
    Disponivel = true,
    Duracao = 341,
    Nota = 1.0f
};

album.AdicionarMusica(musica2);
album.AdicionarMusica(musica3);

theNeighbourhood.AddAlbum(album);

album.MostrarMusicas();
theNeighbourhood.ExibirDiscografia();