using System;
using System.Collections.Generic;
using System.Text;

namespace EquationSolver
{
    class FileUtils
    {
        public static List<Vector<double>> ReadFile(string fileName)
        {
            List<Vector<double>> result = new List<Vector<double>>();
            string text = System.IO.File.ReadAllText(fileName);
            string[] lines = text.Split("\n");
            foreach(string line in lines)
            {
                string[] tokens = line.Split(";");
                Vector<double> vector = new Vector<double>();
                double value = 0;
                foreach (string token in tokens)
                {
                    if(double.TryParse(token,out value))
                    {
                        vector.Add(value);
                    }
                    else
                    {
                        throw new Exception("Parse error: " + line);
                    }
                }
                result.Add(vector);
            }
            return result;
        }

        public static void WriteFile(string fileName, List<Vector<double>> result)
        {
            string text = "";
            foreach(Vector<double> res in result)
            {
                text += res + "\n";
            }
            System.IO.File.WriteAllText(fileName,text);
        }
    }
}
