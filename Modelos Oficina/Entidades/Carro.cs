using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Modelos_Oficina;

public class Carro
{
    public Carro(DonoDoCarro donoDoCarro, string marcaModelo, string placa)
    {
        DonoDoCarro = donoDoCarro;
        MarcaModelo = marcaModelo;
        Placa = placa;
    }

    public DonoDoCarro DonoDoCarro { get; set; }
    public string Placa { get; set; }
    public string MarcaModelo { get; set; }

    public void ExibirDetalhesDoCarro()
    {
        Console.WriteLine($"Dono do carro: {DonoDoCarro.Nome}");
        Console.WriteLine($"Modelo do carro {MarcaModelo}");
        Console.WriteLine($"Placa: {Placa}");
    }
}
