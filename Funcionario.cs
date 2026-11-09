using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public abstract class Funcionario
    {
        public string? Nome { get; set; }

        public void Trabalhar()
        {
            Console.WriteLine("Funcionario está executando atividades");
        }
        public Funcionario(string nome, decimal, salario)
        {
            Nome = nome;
            salario = salario;
        }
    }
}