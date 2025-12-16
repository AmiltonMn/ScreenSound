using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
    private string[] Tonalidades = ["C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"];

    [JsonPropertyName("song")]
    public string Nome { get; set; }

    [JsonPropertyName("artist")]
    public string Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string Genero { get; set; }

    [JsonPropertyName("key")]
    public int NotaMusical { get; set; }

    public string Tonalidade { 
        get
        {
            return this.Tonalidades[NotaMusical];
        } 
    }

    public void ExibirDetalhes() 
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}"); 
        Console.WriteLine($"Gênero: {Genero}\n");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
