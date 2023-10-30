using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class Quaternion
    {
        public double W { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Quaternion(double w, double x, double y, double z)
        {
            W = w;
            X = x;
            Y = y;
            Z = z;
        }

        public double Norm()
        {
            return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
        }

        public Quaternion Conjugate()
        {
            return new Quaternion(W, -X, -Y, -Z);
        }

        public Quaternion Inverse()
        {
            double norm = Norm();
            if (norm == 0)
            {
                throw new DivideByZeroException("Quaternion has zero norm and cannot be inverted.");
            }
            double normSquared = norm * norm;
            return new Quaternion(W / normSquared, -X / normSquared, -Y / normSquared, -Z / normSquared);
        }

        public static Quaternion operator +(Quaternion a, Quaternion b)
        {
            return new Quaternion(a.W + b.W, a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Quaternion operator -(Quaternion a, Quaternion b)
        {
            return new Quaternion(a.W - b.W, a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Quaternion operator *(Quaternion a, Quaternion b)
        {
            double w = a.W * b.W - a.X * b.X - a.Y * b.Y - a.Z * b.Z;
            double x = a.W * b.X + a.X * b.W + a.Y * b.Z - a.Z * b.Y;
            double y = a.W * b.Y - a.X * b.Z + a.Y * b.W + a.Z * b.X;
            double z = a.W * b.Z + a.X * b.Y - a.Y * b.X + a.Z * b.W;
            return new Quaternion(w, x, y, z);
        }

        public static bool operator ==(Quaternion a, Quaternion b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            {
                return true;
            }
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }
            return a.W == b.W && a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Quaternion a, Quaternion b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Quaternion other = (Quaternion)obj;
            return W == other.W && X == other.X && Y == other.Y && Z == other.Z;
        }

        public override int GetHashCode()
        {
            return W.GetHashCode() ^ X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }
    }
}
