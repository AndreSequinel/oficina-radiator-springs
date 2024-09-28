using System;

namespace Oficina.Modelos_Oficina.Menus;

internal class Menu
{
    public void ExibirTituloDaOperacao(string tituloDaOperacao)
    {
        int caracteres = tituloDaOperacao.Length;
        string simbolos = string.Empty.PadLeft(caracteres, '*');

        Console.WriteLine(simbolos);
        Console.WriteLine(tituloDaOperacao);
        Console.WriteLine(simbolos + "\n");
    }

    public virtual void Executar(Dictionary<string, Carro> carrosNaOficina)
    {
        Console.Clear();
    }
}
