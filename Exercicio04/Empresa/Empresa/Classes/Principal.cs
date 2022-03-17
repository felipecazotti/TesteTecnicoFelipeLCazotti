using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Classes
{
    public class Principal
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public Principal()
        {
            funcionarios.Add(new Gerente("Felipe", 35, 20078.12));
            funcionarios.Add(new Supervisor("Kaique", 28, 15012.00));
            funcionarios.Add(new Vendedor("Pedro", 22, 5037.87));
        }

        public void ExibirBonificao()
        {
            foreach(Funcionario funcionario in funcionarios)
            {
                Console.WriteLine($"Funcionário {funcionario.nome}:");
                Console.WriteLine($"Bonificacão R$ {funcionario.Bonificacao().ToString("0.00")}");
                Console.WriteLine();
            }
        }
    }
}
