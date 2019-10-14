using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApiTest
{
    public class Calculator: ICalculator
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
    }
}
