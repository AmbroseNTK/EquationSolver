using System;
using System.Collections.Generic;

namespace EquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vector<double>> inputs;
            List<Vector<double>> result = new List<Vector<double>>();
            Equation<double> equation;
            LinearEquation linearEquation = new LinearEquation();
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            try
            {
                inputs = FileUtils.ReadFile("testcases.txt");
                Vector<double> res = new Vector<double>();
                foreach(Vector<double> input in inputs)
                {

                    if (input.Count < 3)
                    {
                        equation = linearEquation;
                        equation.Input = input;
                    }
                    else
                    {
                        equation = quadraticEquation;
                        equation.Input = input;
                    }
                    res = equation.Output;
                    Console.WriteLine("Input: {0,-15} -> Result: {1,-15}",input,res);
                    result.Add(res);
                }
                FileUtils.WriteFile("result.txt", result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
            
        }
    }
}
