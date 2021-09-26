using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1222.Helpers
{
    public class Matrix
    {
        private double[,] data;

        private int m;
        public int M { get => this.m; }

        private int n;
        public int N { get => this.n; }

        public Matrix(int m, int n)
        {
            this.m = m;
            this.n = n;
            this.data = new double[m, n];
        }

        public Matrix(Matrix other)
        {
            this.m = other.M;
            this.n = other.N;
            this.data = new double[this.m, this.n];

            for (var i = 0; i < this.M; i++)
            {
                for (var j = 0; j < this.N; j++)
                {
                    this.data[i, j] = other[i, j];
                }
            }
        }

        public void ProcessFunctionOverData(Action<int, int> func)
        {
            for (var i = 0; i < this.M; i++)
            {
                for (var j = 0; j < this.N; j++)
                {
                    func(i, j);
                }
            }
        }

        public double this[int x, int y]
        {
            get
            {
                return this.data[x, y];
            }
            set
            {
                this.data[x, y] = value;
            }
        }

        public static Matrix CreateIdentityMatrix(int n)
        {
            var result = new Matrix(n, n);
            for (var i = 0; i < n; i++)
            {
                result[i, i] = 1;
            }
            return result;
        }

        public static Matrix operator +(Matrix matrix, Matrix matrix2)
        {
            if (matrix.M != matrix2.M || matrix.N != matrix2.N)
            {
                throw new ArgumentException(
                    "matrixes dimensions should be equal");
            }
            var result = new Matrix(matrix.M, matrix.N);
            result.ProcessFunctionOverData((i, j) =>
                result[i, j] = matrix[i, j] + matrix2[i, j]);
            return result;
        }

        public static Matrix operator *(Matrix matrix, double value)
        {
            var result = new Matrix(matrix.M, matrix.N);
            result.ProcessFunctionOverData((i, j) =>
                result[i, j] = matrix[i, j] * value);
            return result;
        }

        public static Matrix operator *(Matrix matrix, Matrix matrix2)
        {
            if (matrix.N != matrix2.M)
            {
                throw new ArgumentException("matrixes can not be multiplied");
            }
            var result = new Matrix(matrix.M, matrix2.N);
            result.ProcessFunctionOverData((i, j) =>
            {
                for (var k = 0; k < matrix.N; k++)
                {
                    result[i, j] += matrix[i, k] * matrix2[k, j];
                }
            });
            return result;
        }

        public static Matrix operator -(Matrix matrix, Matrix matrix2)
        {
            return matrix + (matrix2 * -1);
        }

        public Matrix CreateTransposeMatrix()
        {
            var result = new Matrix(this.N, this.M);
            result.ProcessFunctionOverData((i, j) => result[i, j] = this[j, i]);
            return result;
        }

        public double Determinant
        {
            get
            {
                if (this.M != this.N)
                    throw new ArgumentException("matrix can not have determinant");
                if (this.M == 1)
                    return this[0, 0];
                if (this.M == 2)
                    return (this[0, 0] * this[1, 1] - this[0, 1] * this[1, 0]);

                double result = 0.0;

                for (int col = 0; col < this.N; col++)
                {
                    double pos = 1.0;
                    double neg = -1.0;
                    for (int row = 0; row < this.M; row++)
                    {
                        pos *= this[row, (row + col) % this.N];
                        neg *= this[row, (2 * this.N - 1 - row - col) % this.N];
                    }
                    result += pos + neg;
                }

                return result;
            }
        }

        public static double[] MethodGausa(Matrix matrix, double[] result)
        {
            //задаем количество столбцов и строк матрицы
            int n = matrix.N;
            int m = matrix.M;

            //приводим матрицу к треугольному виду
            for (int k = 0; k < m; k++)
            {
                double DiagonalCoefficient = matrix[k, k];
                for (int i = k; i < m; i++)                  
                {
                    double CurrentCoefficient = matrix[i, k];
                    for (int j = k; j < n; j++)
                    {
                        if (i == k)
                        {
                            matrix[k, j] = matrix[k, j] / DiagonalCoefficient;
                        }
                        else
                        {
                            matrix[i, j] = -CurrentCoefficient * matrix[k, j] + matrix[i, j];
                        }
                    }
                }
            }

            //рассчитываем коэффициенты
            result[m-1] = matrix[m - 1, n - 1];
            for (int i = m - 2; i >= 0; i--)
            {
                double Sum = 0;
                for (int j = n - 2; j > i; j--)
                {
                    Sum += matrix[i, j] * result[j];
                }
                result[i] = matrix[i, n - 1] - Sum;
            }
                        
            return result;
        }
    }
}
