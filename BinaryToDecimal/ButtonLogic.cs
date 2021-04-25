using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class ButtonLogic
    {
        public int Factorial(int num=0)
        {
            if (num == 0)
                return 0;
            else
                return (num % 10 + 2 * (Factorial(num / 10)));
        }
    }
}
