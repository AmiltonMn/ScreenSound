namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
    void AddNota(Avaliacao avaliacao);

    double Media { get; };
}
