namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel
{
    public Banda(string nome) 
    {
        Nome = nome;
    }

    public string Nome { get; }

    private List<Avaliacao> Notas = new();

    public List<Album> Albums = new List<Album>();
    public double Media => 
        Notas.Count > 0 ? Notas.Average(a => a.Nota) : 0;

    public void AddNota(Avaliacao nota) =>
        Notas.Add(nota);

    public void AddAlbum(Album album) =>
        Albums.Add(album);

    public void ExibirDiscografia() =>
        Albums.ForEach(album => Console.WriteLine(album.Nome));
}