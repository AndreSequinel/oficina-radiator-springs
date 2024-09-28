namespace Oficina.Modelos_Oficina.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Carro> dic)
    {
        Console.Clear();
        Console.WriteLine("Tchau tchau");
    }
}
