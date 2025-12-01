class Album
{
    public string Nome { get; set; }

    public List<Musica> Musicas = new List<Musica>();
    public float DuracaoTotal => Musicas.Sum(m => m.Duracao) / 60;

    public void AdicionarMusica(Musica musica) =>
        Musicas.Add(musica);

    public void MostrarMusicas() 
    {
        Console.WriteLine($"Nome do álbum: {Nome}\n");

        Musicas.ForEach(musica => musica.ExibirFichaTecnica());

        Console.WriteLine($"Duração total do álbum: {DuracaoTotal} minutos");
    }
}

