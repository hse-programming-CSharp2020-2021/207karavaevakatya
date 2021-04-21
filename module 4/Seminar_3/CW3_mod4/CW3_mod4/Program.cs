using System;

namespace CW3_mod4
{
    class Matrix2
    {
        public double A11 { get; set; }
        public double A12 { get; set; }
        public double A21 { get; set; }
        public double A22 { get; set; }

        public Matrix2(double a11, double a12, double a21, double a22)
        {
            A11 = a11;
            A12 = a12;
            A21 = a21;
            A22 = a22;
        }

        public Matrix2(double a11, double a22): this (a11,0,0,a22)
        { }

        public Matrix2(Matrix2 matrix)
        {
            A11 = matrix.A11;
            A12 = matrix.A12;
            A21 = matrix.A21;
            A22 = matrix.A22;
        }

        public double Det()
        {
            return A11 * A22 - A12 * A21;
        }

        public Matrix2 Inverse()
        {
            return new Matrix2(1 / Det() * A11, 1 / Det() * A12, 1 / Det() * A21, 1 / Det() * A22);
        }

        public Matrix2 Transpose()
        {
            return new Matrix2(A11, A21,A12, A22);
        }

        public static Matrix2 operator +(Matrix2 a, Matrix2 a2)
        { 
            return new Matrix2(a.A11 + a2.A11, a.A12 + a2.A12, a.A21 + a2.A21, a.A22 + a2.A22);
        }
        public static Matrix2 operator -(Matrix2 a, Matrix2 a2)
        {
            return new Matrix2(a.A11 - a2.A11, a.A12 - a2.A12, a.A21 - a2.A21, a.A22 - a2.A22);
        }

        public static Matrix2 operator *(Matrix2 a, int num)
        {
            return new Matrix2(a.A11 * num, a.A12 * num, a.A21 * num, a.A22 * num);
        }
        public static Matrix2 operator /(Matrix2 a, int num)
        {
            return new Matrix2(a.A11 / num, a.A12 / num, a.A21 / num, a.A22 / num);
        }

        public static Matrix2 operator *(Matrix2 a, Matrix2 a2)
        {
            return new Matrix2(a.A11 * a2.A11 + a.A12 * a2.A12, a.A11 * a2.A21 + a.A12 * a2.A22, a.A21 * a2.A11 + a.A22 * a2.A12, a.A21 * a2.A21 + a.A22 * a2.A22);
        }

        public static Matrix2 operator /(Matrix2 a, Matrix2 a2)
        {
            return a * a2.Inverse();
        }

        public override string ToString()
        {
            return $"{A11} {A12}\n{A21} {A22}"; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix2 matrix1 = new Matrix2(1, 2, 3, 4);
            Matrix2 matrix2 = new Matrix2(1, 1);
            Matrix2 matrix = matrix1 + matrix2;
            Console.WriteLine(matrix);
        }
    }
}
