using System;
using System.Collections.Generic;
using System.Text;

namespace EquationSolver
{
    abstract class Equation<T>
    {
        public Vector<T> Input { get; set; }
        public Vector<T> Output
        {
            get
            {
                return Solve(Input);
            }
        }
        protected abstract Vector<T> Solve(Vector<T> input);
        
    }
}
