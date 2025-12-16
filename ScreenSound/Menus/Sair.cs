using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class Sair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) 
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
