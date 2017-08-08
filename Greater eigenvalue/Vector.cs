using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_eigenvalue
{
    public class Vector
    {
        public int size { get; private set; }
        public double[] vector { get; private set; }

        public Vector(double[] vector)
        {
            size = vector.Length;
            this.vector = new double[size];
            Array.Copy(vector, this.vector, size);
        }

        public double ScalarMultiply(Vector v)
        {
            double result = 0;
            if(v.size == size)
            {
                for(int i = 0; i < size; i++)
                {
                    result += v.vector[i] * vector[i];
                }
            }
            return result;
        }

        public static Vector operator *(double number,Vector vector)
        {
            Vector result;
            double[] buf = new double[vector.size];
            for (int i = 0; i < vector.size; i++)
            {
                buf[i] = vector.vector[i] * number;
            }
            result = new Vector(buf);
            return result;
        }

    }
}
