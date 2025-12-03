class Banda
{
    public Banda(string nome) 
    {
        Nome = nome;
    }

    public string Nome { get; }

    private List<Album> Albums = new List<Album>();

    public void AddAlbum(Album album) =>
        Albums.Add(album);

    public void ExibirDiscografia() =>
        Albums.ForEach(album => Console.WriteLine(album.Nome));
}