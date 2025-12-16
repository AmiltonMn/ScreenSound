namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    public Album(string nome) 
    {
        Nome = nome;
        ContadorDeObjetos++;
    }

    public static int ContadorDeObjetos { get; set; }
    public List<Avaliacao> Avaliacoes = new();
    public string Nome { get; }

    public double Media =>
        Avaliacoes.Count > 0 ? Avaliacoes.Average(a => a.Nota) : 0;

    public float DuracaoTotal => Musicas.Sum(m => m.Duracao);

    public List<Musica> Musicas = new List<Musica>();

    public void AdicionarMusica(Musica musica) =>
        Musicas.Add(musica);

    public void AddNota(Avaliacao avaliacao) =>
        Avaliacoes.Add(avaliacao);

    public void MostrarMusicas() 
    {
        Console.WriteLine($"Nome do álbum: {Nome}\n");

        Musicas.ForEach(musica => musica.ExibirFichaTecnica());

        Console.WriteLine($"Duração total do álbum: {DuracaoTotal} minutos");
    }
}

