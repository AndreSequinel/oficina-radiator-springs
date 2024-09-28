using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Modelos_Oficina;

internal class Oficina
{
    public Oficina(string nomeDaOficina, int capacidadeDeCarros, string descricao)
    {
        NomeDaOficina = nomeDaOficina;
        CapacidadeDeCarros = capacidadeDeCarros;
        Descricao = descricao;
    }

    public string NomeDaOficina { get; set; }
    public int CapacidadeDeCarros { get; set; }
    public string Descricao { get; set; }

}
