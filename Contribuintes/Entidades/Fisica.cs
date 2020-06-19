using System;
using System.Collections.Generic;
using System.Text;

namespace Contribuintes.Entidades
{
    class Fisica : Contribuinte
    {
        public double GastoSaude { get; set; }

        public Fisica(string nome, double renda, double gastoSaude) : base(nome, renda)
        {
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            if (Renda < 20000)
            {
                if (GastoSaude > 0)
                {
                    return (Renda * 0.15) - (GastoSaude * 0.5);
                }
                else
                {
                    return Renda * 0.15;
                }
            }
            else
            {
                if (GastoSaude > 0)
                {
                    return (Renda * 0.25) - (GastoSaude * 0.5);
                }
                else
                {
                    return Renda * 0.25;
                }

            }
        }
    }

}

