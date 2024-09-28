using Oficina.Modelos_Oficina;

namespace Oficina.Modelos_Oficina.Menus;

internal class MenuVerificarListagemDeCarros : Menu
{
    public override void Executar(Dictionary<string, Carro> carrosNaOficina)
    {
        base.Executar(carrosNaOficina);
        ExibirTituloDaOperacao("Lista de carros cadastrados");
        
        if (carrosNaOficina.Count == 0)
        {
            Console.WriteLine("Nenhuma carro na oficina");
        }
        else
        {
            Console.WriteLine("Aqui está a lista de carros: ");
            Console.WriteLine("\n");
            foreach (string x in carrosNaOficina.Keys)
            {                
                Console.WriteLine($"Carro: {x}");
            }
        }

        Thread.Sleep(5000);
    }
}
