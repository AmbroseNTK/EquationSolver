using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EquationSolver
{
    class Vector<T>:List<T>
    {
        public bool IsNull { get; set; }

        public Vector()
        {
            IsNull = false;
        }
        public override string ToString()
        {
            string result = "";
            result = "[ ";
            if (this.Count != 0)
            {
                foreach (T scale in this)
                {
                    result += scale + " ";
                }
            }
            else
            {
                result += "Any ";
            }
            if (IsNull)
            {
                result = "[ Empty ";
            }
            result += "]";
            return result;
        }

    }
}
