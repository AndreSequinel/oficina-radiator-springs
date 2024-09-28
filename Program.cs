using Oficina.Modelos_Oficina.Menus;
using Oficina.Modelos_Oficina;

Dictionary<string, Carro> carrosNaOficina = new Dictionary<string, Carro>();

Dictionary<int, Menu> menuOpcoes = new Dictionary<int, Menu>();
menuOpcoes.Add(1, new MenuCadastrarCarro());
menuOpcoes.Add(2, new MenuVerificarListagemDeCarros());
menuOpcoes.Add(3, new MenuExibirDetalhesDoCarro());
menuOpcoes.Add(-1, new MenuSair());

void ExibirOpcoesDoMenu()
{
    Console.Clear();
    Console.WriteLine("BEM-VINDO A OFICINA RADIATOR SPRINGS\n");
    Console.WriteLine("1. Realizar o cadastro do meu carro");
    Console.WriteLine("2. Verificar os carros na oficina");
    Console.WriteLine("3. Exibir detalhes de um veiculo");
    Console.WriteLine("-1. Sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (menuOpcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu classe = menuOpcoes[opcaoEscolhidaNumerica];
        classe.Executar(carrosNaOficina);
        if (opcaoEscolhidaNumerica>0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Digite um valor válido");
    }
}

ExibirOpcoesDoMenu();