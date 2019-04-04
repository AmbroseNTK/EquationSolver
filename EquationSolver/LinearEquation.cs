using System;
using System.Collections.Generic;
using System.Text;

namespace EquationSolver
{
    class LinearEquation : Equation<double>
    {
        protected override Vector<double> Solve(Vector<double> input)
        {
            Vector<double> result = new Vector<double>();
            if(input != null)
            {
                if (input.Count == 2)
                {
                    double a = input[0];
                    double b = input[1];
                    if (a != 0)
                    {
                        if (b == 0)
                        {
                            result.Add(0);
                        }
                        else
                        {
                            result.Add(-b / a);
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid input vector: " + input);
                }
            }
            else
            {
                throw new Exception("Input must not null");
            }
            return result;
        }
    }
}
