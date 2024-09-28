using Oficina.Modelos_Oficina;

namespace Oficina.Modelos_Oficina.Menus;

internal class MenuCadastrarCarro: Menu
{
    public override void Executar(Dictionary<string, Carro> carrosNaOficina)
    {
        base.Executar(carrosNaOficina);
        ExibirTituloDaOperacao("Cadastro de carros");

        Console.WriteLine("\nQual seu nome completo?");
        string nomeDono = Console.ReadLine()!;

        Console.WriteLine("\nQual sua idade");
        int idadeDono = int.Parse(Console.ReadLine()!);

        Console.Write("\nQual marca + modelo do seu carro: ");
        string nomeCarro = Console.ReadLine()!;

        Console.Write("\nQual a placa do carro: ");
        string placa = Console.ReadLine()!.ToUpper();

        DonoDoCarro dono = new(nomeDono, idadeDono);              
        Carro carro = new(dono, nomeCarro, placa);

        carrosNaOficina.Add(nomeCarro, carro);
        Console.WriteLine($"\nCarro: {carro.MarcaModelo} - {carro.Placa} cadastrado com sucesso (Proprietário: {dono.Nome})");

        Thread.Sleep(5000);
        Console.Clear();
    }
}
