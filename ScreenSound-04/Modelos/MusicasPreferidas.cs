using System.Text.Json;

namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasPreferidas { get; }

    public MusicasPreferidas(string nome) 
    {
        Nome = nome;
        ListaDeMusicasPreferidas = new();
    }

    public void AdicionarMusicaFavorita(Musica musica) 
    {
        ListaDeMusicasPreferidas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine("Lista de músicas favoritas:\n");

        foreach (Musica musica in ListaDeMusicasPreferidas) 
        {
            musica.ExibirDetalhes();
        }
    }

    public void GerarArquivoJSON() 
    {
        string musicasPreferidasJSON = JsonSerializer.Serialize(new 
        {
            nome = Nome,
            musicas = ListaDeMusicasPreferidas
        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, musicasPreferidasJSON);
        Console.WriteLine($"O arquivo JSON foi criado com sucesso!\nCaminho para o arquivo: {Path.GetFullPath(nomeDoArquivo)}");
    }
}
