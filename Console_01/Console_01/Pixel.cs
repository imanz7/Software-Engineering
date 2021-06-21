using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_01
{
    class Pixel
    {
        protected string brand;
        protected int speed;
        
        public Pixel (string setX, int setY)       // constructor
        {
            brand = setX;
            speed = setY;

            Console.WriteLine("Brand of air conditioning: " + brand);
            Console.WriteLine("Current speed: " + speed);
        }

        
    }
}
