using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FilterArtistsByGenre(string genre, List<Musica> musicas)
    {
        var listaDeArtistasPorGenero = musicas.Where(m => m.Genero.Contains(genre)).Select(m => m.Artista).Distinct().ToList();

        Console.WriteLine($"Lista de artista que tocam músicas do gênero {genre}");
        foreach (var artista in listaDeArtistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FilterByArtist(string artista, List<Musica> musicas)
    {
        var musicasFiltradas = musicas.Where(m => m.Artista!.Equals(artista)).ToList();

        foreach (var musica in musicasFiltradas)
        {
            musica.ExibirDetalhes();
        }
    }

    public static void OrderArtistsByName(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(m => m.Artista).Select(m => m.Artista).Distinct().ToList();

        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
