using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_eigenvalue
{
    public class QuadMatrix
    {
        public int size { get; private set; }
        public double[,] matrix { get; private set; }

        public QuadMatrix(double[,] matrix)
        {
            if (matrix.GetLength(0) == matrix.GetLength(1))
            {
                this.matrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
                size = matrix.GetLength(0);
                Array.Copy(matrix, this.matrix, size * size);
            }
        }

        public Vector Multiply(Vector v)
        {
            Vector result;
            double[] buf = new double[v.size];
            if (size == v.size)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        buf[i] += matrix[i, j] * v.vector[j];
                    }
                }
            }
            result = new Vector(buf);
            return result;
        }

    }
}
