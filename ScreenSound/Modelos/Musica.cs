namespace ScreenSound.Modelos;

class Musica
{
    public Musica(Banda artista, string nome, string genero) 
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public float Duracao { get; set; }
    public bool Disponivel { get; set; }
    public float Nota { get; set; }
    public string Genero { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence à {Artista.Nome}";
  
    public void ExibirFichaTecnica() {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}s");
        Console.WriteLine($"Gênero: {Genero}");
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
