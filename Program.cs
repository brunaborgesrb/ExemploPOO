using ExemploPOO.Models;
using ExemploPOO.Interfaces;

Pessoa p1 = new Pessoa("Bruna");
Aluno a1 = new Aluno("Emily");
a1.Apresentar();
Professor prof = new Professor();

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 8));

