using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_02
{
    public class Class1
    {
        public int xvalue;
        public int yvalue;
        public int zvalue;
        public int sum;

        // Constructor - must inside the class
        public Class1(int x, int y, int z)
        {
            xvalue = x;
            yvalue = y;
            zvalue = z;
            sum = x + y + z;
        }

        // Constructor 2
        public Class1(int xvalue, int yvalue)
        {
            xvalue = this.xvalue;
            yvalue = this.yvalue;
        }

        public int Summation => xvalue + yvalue + zvalue;
        /*{
            get
            {
                return (xvalue + yvalue + zvalue);
            }
        } */
    }
}
