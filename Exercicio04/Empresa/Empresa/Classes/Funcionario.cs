using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Classes
{
    public class Funcionario
    {
        public string nome;
        protected int idade;
        protected double salario;

        public Funcionario(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
        }

        public virtual double Bonificacao()
        {
            return salario;
        }
    }
}
