using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft_Exercise
{
    class Vector
    {
        private double X;
        public double Y;
        public double Z;
        double mag;

        public double setX
        {
            set
            {
                X = value;
            }

            get
            {
                return X;
            }
        }
        
        public Vector(double A = 0, double B = 0, double C = 0) // constructor
        {
            X = A;
            Y = B;
            Z = C;
        }

        public double magnitude()
        {
            mag = Math.Sqrt(X * X + Y * Y + Z * Z);
            return mag;
        }
    }
}
