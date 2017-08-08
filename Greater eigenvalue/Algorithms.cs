using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_eigenvalue
{
    class Algorithms
    {
        public QuadMatrix matrix { get; private set; }
        public Vector vector { get; private set; }

        public Algorithms(QuadMatrix m, Vector v)
        {
            this.matrix = new QuadMatrix(m.matrix);
            vector = new Vector(v.vector);
        }

        //Доделать
        public double FirstEvent()
        {
            double result = 0;
            while (matrix.Multiply(vector)!=result*vector)
            {
                result = vector.ScalarMultiply(matrix.Multiply(vector))/ vector.ScalarMultiply(vector);
                vector = matrix.Multiply(vector);
            }
            return result;
        }
    }
}
