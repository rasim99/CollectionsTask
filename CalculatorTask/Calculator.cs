using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    internal class Calculator<T>  where T : INumber<T>
    {
         
        public T Sum(T num1,T num2)
        {
            return num1+num2;
        }

        public T Subtract(T num1,T num2)
        {
            return num1 - num2;
        }
        public T Multiply(T num1,T num2)
        { 
            return num1 * num2;
        }
        public T Divide(T num1,T num2)
        {
            return num1 / num2;
        }
        
    }
}
