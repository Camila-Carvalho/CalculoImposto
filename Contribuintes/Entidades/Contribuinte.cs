using System;
using System.Collections.Generic;
using System.Text;

namespace Contribuintes.Entidades
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double Renda { get; set; }

        protected Contribuinte(string nome, double renda)
        {
            Nome = nome;
            Renda = renda;
        }

        public abstract double Imposto();
    }


}
