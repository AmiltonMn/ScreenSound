using ScreenSound_04.Modelos;
using System.Net.NetworkInformation;

namespace ScreenSound_04.Filtros;

internal class GetGenres
{
    public static void GetGenresList(List<Musica> musicas) 
    {
        var genres = musicas.Select(m => m.Genero).Distinct().ToList();
        foreach (var genre in genres)
        {
            Console.WriteLine($"{genre}");
        }
    }
}
