using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Modelos_Oficina;

public class DonoDoCarro
{
    public DonoDoCarro(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string Nome { get; }
    public int Idade { get; }

}
