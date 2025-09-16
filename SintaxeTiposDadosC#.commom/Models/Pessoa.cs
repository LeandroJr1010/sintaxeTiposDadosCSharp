using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeTiposDadosC.commom.Models;

    /// <summary>
    /// Representa pessoa física 
    /// </summary>
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    /// <summary>
    /// Método Function Apresentar
    /// </summary>
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é " + // \n quebra o texto em outra linha
        $"{Nome} e tenho {Idade} anos."); // permite pular a linha em textos grandes
    }
}
