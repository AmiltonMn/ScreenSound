using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class AvaliarAlbum : Menu
{

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Álbum");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine("Agora digite o nome do álbum: ");
            string tituloAlbum = Console.ReadLine()!;

            if (banda.Albums.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albums.First(a => a.Nome.Equals(tituloAlbum));

                Console.WriteLine($"Qual a nota que o álbum {tituloAlbum} merece: ");
                Avaliacao notaAlbum = Avaliacao.Parse(Console.ReadLine()!);

                album.AddNota(notaAlbum);

                Console.WriteLine($"A nota {notaAlbum.Nota} foi adicionada ao álbum {tituloAlbum}");

                Thread.Sleep(2000);
                Console.Clear();
            }
            else 
            {
                Console.WriteLine($"O álbum {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite alguma tecla para voltar à tela inicial");
                Console.ReadKey();
                Console.Clear();
            }

                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);

            banda.AddNota(nota);

            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
