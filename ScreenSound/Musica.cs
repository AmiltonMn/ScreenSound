using System;
using System.Threading.Channels;

class Musica
{
    public Musica(Banda artista) 
    {
        Artista = artista;
    }

    public string Nome { get; set; }
    public Banda Artista { get; }
    public float Duracao { get; set; }
    public bool Disponivel { get; set; }
    public float Nota { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence à {Artista.Nome}";
  
    public void ExibirFichaTecnica() {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}s");
        Console.WriteLine($"Gênero: {Genero.Nome}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano atual");
        }
        else {
            Console.WriteLine("Adquira o plano Plus");
        }
        Console.WriteLine($"Descrição: {DescricaoResumida}\n");
    }
}
