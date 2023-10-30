using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class Matrix3x3
    {
        private double[,] matrix;

        public Matrix3x3(double m11, double m12, double m13, double m21, double m22, double m23, double m31, double m32, double m33)
        {
            matrix = new double[3, 3];
            matrix[0, 0] = m11;
            matrix[0, 1] = m12;
            matrix[0, 2] = m13;
            matrix[1, 0] = m21;
            matrix[1, 1] = m22;
            matrix[1, 2] = m23;
            matrix[2, 0] = m31;
            matrix[2, 1] = m32;
            matrix[2, 2] = m33;
        }

        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public double Trace()
        {
            return matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
        }
    }
}
