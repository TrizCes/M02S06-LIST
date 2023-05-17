using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1
{
    public class Soma
    {
        public static int SumList(List<int> values)
        {
            int result = 0;
            foreach (var value in values)
            {
                result += value;
            }
            return result;
        }
    }
}