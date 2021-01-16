using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArPog
{
    class Progression
    {
        public string arProgreesion(double start, double end)
        {
            int i = 0;
            string result = "";
            while (start < (end - 1.15))
            {
                result += ($"a{i++} = {start += 1.15}\n");
            }
            return result;
        }
    }
}
