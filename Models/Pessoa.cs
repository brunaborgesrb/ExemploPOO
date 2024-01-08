using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string Nome)
        {
            Nome = Nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Disciplina { get; set; }

        public virtual void Apresentar() //virtual: o metodo pode ser sobrescrito se a classe filha desejar 
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou uma professora de {Disciplina}, e tenho {Idade} anos.");

        }
    }
}