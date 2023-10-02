using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public struct Vector
    {
        public double X {  get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector operator +(Vector a, Vector b) 
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector operator *(Vector a, Vector b)
        {
            return new Vector(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }

        public static Vector operator *(Vector a, double numb)
        {
            return new Vector(a.X * numb, a.Y * numb, a.Z * numb);
        }

        public static bool operator ==(Vector a, Vector b) 
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z) == Math.Sqrt(b.X * b.X + b.Y * b.Y + b.Z * b.Z);
        }

        public static bool operator !=(Vector a, Vector b)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z) != Math.Sqrt(b.X * b.X + b.Y * b.Y + b.Z * b.Z);
        }


        public override int GetHashCode()
        {
            return this.X.GetHashCode() ^ this.Y.GetHashCode() ^ this.Z.GetHashCode();
        }
    }
}
