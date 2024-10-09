using System;

namespace Oficina.Modelos_Oficina.Menus;

internal class MenuExibirDetalhesDoCarro : Menu
{
    public override void Executar(Dictionary<string, Carro> dic)
    {
        base.Executar(dic);
        ExibirTituloDaOperacao("Detalhes do veículo");

        string carroBuscado = "";

        while (true)
        {
            Console.WriteLine("Qual carro você buscar?");
            carroBuscado = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(carroBuscado))
            {
                Console.WriteLine("É preciso digitar uma informação.\n");
            }

            var resultados = dic.Where(exp => exp.Key.Contains(carroBuscado, StringComparison.OrdinalIgnoreCase)).ToList();

            if (resultados.Count == 0)
            {
                Console.WriteLine("Carro não registrado na nossa base de dados.");
                Thread.Sleep(3000);
                break; 
            }

            else
            {
                Console.WriteLine($"Foram encontrados {resultados.Count} carros que correspondem à sua busca:\n");

                foreach (var resultado in resultados)
                {
                    resultado.Value.ExibirDetalhesDoCarro();
                    Console.WriteLine(); 
                }

                Thread.Sleep(5000);
                break; 
            }
        }
    }
}
