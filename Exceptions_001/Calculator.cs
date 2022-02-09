using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_001
{
    class Calculator
    {
        public double FirstNum { get; set; }
        public double SecondNum { get; set; }
        public void Sum() => Console.WriteLine(FirstNum + SecondNum);
        public void Sub() => Console.WriteLine(FirstNum - SecondNum);
        public void Mult() => Console.WriteLine(FirstNum * SecondNum);
        public void Div()
        {
            if (SecondNum == 0)
            {
                throw new DivideByZeroException();
            }
            else
                Console.WriteLine(FirstNum / SecondNum);
        }
    }
}
