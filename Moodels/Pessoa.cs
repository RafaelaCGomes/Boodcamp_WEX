using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_WEX.Moodels
{
    // nome de classe, propriedade e método = PascalCase
    public class Pessoa  
    {
        //característica, propriedade da classe, pessoa.
        public string Nome { get; set; }
        public int Idade { get; set; }

        //método, ação, função.
        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}