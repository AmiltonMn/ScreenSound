namespace ScreenSound.Modelos;

class Banda
{
    public Banda(string nome) 
    {
        Nome = nome;
    }

    public string Nome { get; }

    private List<int> Notas = new List<int>();

    private List<Album> Albums = new List<Album>();
    public double Media => 
        Notas.Average();

    public void AddNota(int nota) =>
        Notas.Add(nota);

    public void AddAlbum(Album album) =>
        Albums.Add(album);

    public void ExibirDiscografia() =>
        Albums.ForEach(album => Console.WriteLine(album.Nome));
}