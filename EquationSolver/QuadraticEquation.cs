using System;
using System.Collections.Generic;
using System.Text;

namespace EquationSolver
{
    class QuadraticEquation : Equation<double>
    {
        protected override Vector<double> Solve(Vector<double> input)
        {
            Vector<double> result = new Vector<double>();
            if (input != null)
            {
                if (input.Count == 3)
                {
                    double a = input[0];
                    double b = input[1];
                    double c = input[2];
                    if (a == 0)
                    {
                        LinearEquation linearEquation = new LinearEquation();
                        linearEquation.Input = new Vector<double>() { b, c };
                        result = linearEquation.Output;
                    }
                    else
                    {
                        double delta = b * b - 4 * a * c;
                        if (delta < 0)
                        {
                            result.IsNull = true;
                        }
                        else if (delta == 0)
                        {
                            result.Add(-b / 2 * a);
                        }
                        else
                        {
                            double sqrtDelta = Math.Sqrt(delta);
                            result.Add((-b + sqrtDelta) / (2 * a));
                            result.Add((-b - sqrtDelta) / (2 * a));
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
