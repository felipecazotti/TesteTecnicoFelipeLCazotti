using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Classes
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override double Bonificacao()
        {
            return salario + 10000.00;
        }
    }
}
