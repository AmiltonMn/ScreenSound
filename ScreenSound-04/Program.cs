using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;

using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.WriteLine(musicas!.Count);

        MusicasPreferidas musicasFavoritas = new("Amilton");

        foreach (var musica in musicas)
        {
            switch (musica.NotaMusical) 
            {
                case "0":
                    musica.NotaMusical = "C";
                    break;

                case "1":
                    musica.NotaMusical = "C#";
                    break;

                case "2":
                    musica.NotaMusical = "D";
                    break;

                case "3":
                    musica.NotaMusical = "D#";
                    break;

                case "4":
                    musica.NotaMusical = "E";
                    break;

                case "5":
                    musica.NotaMusical = "F";
                    break;

                default:
                    musica.NotaMusical = "";
                    break;
            }
        }

        musicasFavoritas.AdicionarMusicaFavorita(musicas[0]);
        musicasFavoritas.AdicionarMusicaFavorita(musicas[1]);
        musicasFavoritas.AdicionarMusicaFavorita(musicas[2]);
        musicasFavoritas.AdicionarMusicaFavorita(musicas[3]);
        musicasFavoritas.AdicionarMusicaFavorita(musicas[4]);
        musicasFavoritas.AdicionarMusicaFavorita(musicas[5]);
        musicasFavoritas.AdicionarMusicaFavorita(musicas[6]);

        musicasFavoritas.ExibirMusicasFavoritas();
    }
    catch
    (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro ao tentar pegar os dados: " + ex.Message);
    }
}