using System;
using System.Collections.Generic;
using System.Text;

namespace Contribuintes.Entidades
{
    class Juridica : Contribuinte
    {
        public int NumEmpregado { get; set; }

        public Juridica (string nome, double renda, int numEmpregado) : base(nome, renda)
        {
            NumEmpregado = numEmpregado;
        }

        public override double Imposto()
        {
            if (NumEmpregado > 10)
            {
                return Renda * 0.14; 
            }
            else
            {
                return Renda * 0.16;
            }
        }
    }
}
