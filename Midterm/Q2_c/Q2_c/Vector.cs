using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_c
{
    public class Vector
    {
        public double X;
        public double Y;

        public Vector(double A = 0, double B = 0) // constructor
        {
            X = A;
            Y = B;
        }

        public static Vector operator/(Vector A, Vector B)
        {
            return new Vector(A.X / B.X, A.Y / B.Y);
        }

        public static Vector operator *(Vector A, Vector B)
        {
            return new Vector(A.X * B.X, A.Y * B.Y);
        }

        public static Vector operator +(Vector A, Vector B)
        {
            return new Vector(A.X + B.X, A.Y + B.Y);
        }

        public static Vector DivideBy(Vector A, Vector B)
        {
            return A/B;
        }

    }
}
