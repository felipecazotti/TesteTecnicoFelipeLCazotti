using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Classes
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override double Bonificacao()
        {
            return salario + 5000.00;
        }
    }
}
