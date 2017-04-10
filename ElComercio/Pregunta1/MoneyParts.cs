using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    public class MoneyParts
    {
        private double[] Denominations = { 0.05, 0.1, 0.2, 0.5, 1, 2, 5, 10, 20, 50, 100, 200 };

        public string[] build(string amount)
        {
            string[] outCombinations = new string[250];
            double amountD = double.MinValue;
            int contCombinations = 0;
            if (double.TryParse(amount, out amountD))
            {
                String combination = String.Empty;

                //Una sola denominación
                foreach (double den in Denominations)
                {
                    if (amountD % den != 0  && (amountD - den*(amountD%den) == 0))
                    {
                        combination = String.Empty;
                        for (int i = 0; i < (amountD % den); i++)
                        {
                            combination += den.ToString();
                        }
                        outCombinations[contCombinations] = combination;
                        contCombinations++;
                    }

                }

                //Más de una denominación
                combination = String.Empty;
                foreach (double den in Denominations)
                {
                    if (amountD % den != 0)
                    {
                       
                        for (int i = 0; i < (amountD % den); i++)
                        {
                            combination += den.ToString();

                        }
                        amountD = -den * (amountD % den);
                       
                    }

                }

                outCombinations[contCombinations] = combination;
                contCombinations++;
            }
            else
            {
                outCombinations[0] = "Ingresar un monto correcto";
            }

            return outCombinations;
        }
    }
}
