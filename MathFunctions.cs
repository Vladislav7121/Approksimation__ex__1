using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1222.Helpers;

namespace WindowsFormsApp1222
{
    class MathFunctions
    {
        public static SortedList<double, double> Piecewise(SortedList<double, double> data)
        {
            if (data.Count < 2)
                return new SortedList<double, double>();
            double[] arrX = data.Keys.ToArray();
            double[] arrY = data.Values.ToArray();
            SortedList<double, double> result = new SortedList<double, double>();

            for (int i = 0; i < arrX.Length - 1; i++)
            {
                double x = arrX[i];
                double y = arrY[i];
                result.Add(x, y);

                x += (arrX[i + 1] - arrX[i]) / 100;
                y = arrY[i + 1];
                result.Add(x, y);

            }

            if (!result.Keys.Contains(arrX[arrX.Length - 1]))
                result.Add(arrX[arrX.Length - 1], arrY[arrX.Length - 1]);

            return result;
        }

        public static SortedList<double, double> Linear(SortedList<double, double> data)
        {
            if (data.Count < 2)
                return new SortedList<double, double>();

            double[] arrX = data.Keys.ToArray();
            double[] arrY = data.Values.ToArray();
            
            SortedList<double, double> result = new SortedList<double, double>();
            double a, b, HalfX, y;

            result.Add(arrX[0], arrY[0]);

            for (int i = 1; i < arrX.Length; i++)
            {
                a = (arrY[i] - arrY[i - 1]) / (arrX[i] - arrX[i - 1]);
                b = (arrY[i] - a * arrX[i]);
                HalfX = (arrX[i] + arrX[i - 1]) / 2;
                y = a * HalfX + b;
                result.Add(HalfX, y);

                result.Add(arrX[i], arrY[i]);
            }

            return result;
        }

       
        public static SortedList<double, double> ApproximateUniversal(SortedList<double, double> data, int degree)
        {
            //получаем массивы с исходными Х и Y
            double[] ArrX = data.Keys.ToArray<double>();
            double[] ArrY = data.Values.ToArray<double>();    

            //получаем количество точек
            int n = data.Count;
            //получаем количество степеней для х
            int CountXDegree = degree * 2;                

            //задаем массив для расчета сумм степеней х
            double[] ArrXDegree = new double[CountXDegree];
            //задаем массив для расчета сумм произведений у на степень х
            double[] ArrYXDegree = new double[degree + 1];

            //задаем переменную для промежуточного хранения степени х
            double XDegree;
            
            //задаем количество столбцов и строк в основной матрице
            int CountColumns = degree + 2;
            int CountRows = degree + 1;
           
            //задаем точку отсчета для формирования основной матрицы
            int ArrXDegreeBegin = degree - 1;           

            //задаем счетчик для массива расчета степеней 
            for (int i = 0; i < CountXDegree; i++)
            {
                ArrXDegree[i] = 0;                
            }

            //рассчитываем степени х и y*x
            for (int j = 0; j < n; j++) //5,1
                {                
                XDegree = ArrX[j];
                ArrXDegree[0] += XDegree;
                ArrYXDegree[0] += ArrY[j];
                ArrYXDegree[1] += ArrY[j] * XDegree;
                for (int i = 1; i < CountXDegree; i++) //5,2
                {                         
                    XDegree *= ArrX[j];                    
                    ArrXDegree[i] += XDegree;                    
                    if (i + 1 <= degree) //5,3
                    {
                        ArrYXDegree[i + 1] += XDegree * ArrY[j];
                    }
                }
            }

            //создаем основную матрицу
            Matrix mx = new Matrix(CountRows, CountColumns);

            //формируем основную матрицу
            for (int i = 0; i < CountRows; i++)//6,1
            {

                int j, ArrXDegreeCurrent;
                //6,2
                for (j = 0, ArrXDegreeCurrent = ArrXDegreeBegin + i; j < CountRows && ArrXDegreeCurrent >= 0; j++, ArrXDegreeCurrent--)
                {
                    mx[i, j] = ArrXDegree[ArrXDegreeCurrent];                    
                }
                mx[i, CountColumns - 1] = ArrYXDegree[i];
            }

            mx[0, degree] = n;
                       
            //создаем массив для хранения коэффициентов 
            double[] coefficients = new double[CountRows];

            //решаем основную матрицу методом Гаусса
            Matrix.MethodGausa(mx, coefficients);

            //добавление точек на диаграмму
            double min = ArrX.Min();
            double max = ArrX.Max();
            int pointCount = data.Count * 10;
            double step = (max - min) / pointCount;
            SortedList<double, double> result = new SortedList<double, double>();

            for (double x = min; x <= max; x += step)
            {
                double y = 0.0;
                for (int j = 0, d = degree; j < coefficients.Length; j++, d--)
                {
                    y += coefficients[j] * Math.Pow(x, d);
                }
                result.Add(x, y);
            }

            return result;
        }
    }
}

