using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa //herança - herda de outra classe
    {
        public Professor()
        {

        }
        public Professor(string nome) : base(nome)
        {

        }
        public decimal Salario { get; set; }
    }
}