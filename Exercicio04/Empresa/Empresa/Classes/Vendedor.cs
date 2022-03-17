using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Classes
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override double Bonificacao()
        {
            return salario + 3000.00;
        }
    }
}
