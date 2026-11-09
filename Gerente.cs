using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public class Gerente : Funcionario
    {
        public int Codigo { get; set; }

        public void Gerenciarequipe()
        {
            Console.WriteLine("O gestor está gerenciando a equipe");
        }
        public Gerente(string nome, decimal salario) : base(nome, salario)
        {
            
        }
        public void exibirSalario()
        {
            Console.WriteLine(salario);
        }
    }
}