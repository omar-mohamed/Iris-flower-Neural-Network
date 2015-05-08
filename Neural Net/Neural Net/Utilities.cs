using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Net
{
   static class Utilities
    {
      private static Random random = new Random();

        public static int isEqual(double[,] arr, double value)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != value)
                        return 0;
                }
            }
            return 1;
        }

       public static double[,] transpose(double[,] arr)
        {
            double[,] trans=new double[arr.GetLength(1),arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    trans[j,i] = arr[i,j];	
                }
            }
            return trans;
        }

        public static double normalize(double min,double max,double x,double minRange,double maxRange)
        {
            return minRange + ((x - min) * (maxRange - minRange)) / (max - min);
        }

        public static double getRandomNumber(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        public static double[,] getRandomWeights(int number_rows, int num_cols)
        {
           
            double[,] arr = new double[number_rows, num_cols];
            for (int i = 0; i < number_rows; i++)
            {
                for (int j = 0; j < num_cols; j++)
                    arr[i, j] = getRandomNumber(0,1);
            }
            return arr;
        }


        public static double[,] sigmoid(double[,] arr,bool neglectBias)
        {
            double[,] arr2 = new double[arr.GetLength(0), arr.GetLength(1)];
            if (neglectBias)
            {
                arr2[0, 0] = 1;
                for (int i = 1; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr2[i, j] = 1 / (1 + Math.Exp(-1 * arr[i, j]));
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr2[i, j] = 1 / (1 + Math.Exp(-1 * arr[i, j]));
                    }
                }
            }
            return arr2;
        }

        public static int getRandomInteger(int minimum, int maximum)
        {
            return random.Next(minimum, maximum);
        }

        public static double[,] squareElementWise(double[,] arr1)
        {
            double[,] arr = new double[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr[i, j] = arr1[i, j] * arr1[i, j];
                }
            }
            return arr;
        }

        public static double[,] sigmoid_der(double[,] arr)
        {
            double[,] arr2 = new double[arr.GetLength(0), arr.GetLength(1)];
           // arr2[0, 0] = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr2[i, j] = (1 / (1 + Math.Exp(-1 * arr[i, j]))) * (1 - (1 / (1 + Math.Exp(-1 * arr[i, j])))); 
                }
            }
            return arr2;

        }

        public static double[,] addBias(double[,] arr)
        {
            double[,] arr2 = new double[arr.GetLength(0) + 1, 1];
            arr2[0, 0] = 1;
            for (int i = 1; i <= arr.GetLength(0); i++)
                arr2[i, 0] = arr[i-1, 0];
            return arr2;
        }

        public static double[,] removeBias(double[,] arr)
        {
            double[,] arr2 = new double[arr.GetLength(0) -1, 1];
            for (int i = 1; i < arr.GetLength(0); i++)
                arr2[i-1, 0] = arr[i, 0];
            return arr2;
        }

        public static double[,] multiply(double[,] arr1, double[,] arr2)
        {
            double[,] arr = new double[arr1.GetLength(0), arr2.GetLength(1)];
            double sum = 0;
            for (int c = 0; c < arr1.GetLength(0); c++)
            {
                for (int d = 0; d < arr2.GetLength(1); d++)
                {
                    for (int k = 0; k < arr2.GetLength(0); k++)
                        sum = sum + arr1[c, k] * arr2[k, d];

                    arr[c, d] = sum;
                    sum = 0;
                }
            }
            return arr;
        }

        public static double[,] calculateErrors(int classes_num,int sample_num, double[,] arr,string label)
        {
            double[,] desired=new double[classes_num,1];
            desired[0,0]=0;
            desired[1,0]=0;
            desired[2,0]=0;
            if(label=="Iris-setosa")
            {
                desired[0,0]=1;
                return subtract(desired, arr);
            }
            else if (label== "Iris-versicolor")
            {
                desired[1, 0] = 1;
                return subtract(desired, arr);
            }
            else
            {
                desired[2, 0] = 1;
                return subtract(desired, arr);
            }
        }

      // public static int[] toNumbers(,string label)

        public static int getMaxIndex(int classes_num, double[,] arr)
        {
            double max = -100000000;
            int index = 0;
            for (int i = 0; i < classes_num; i++)
            {
                if (arr[i, 0] > max)
                {
                    max = arr[i, 0];
                    index = i;
                }
            }
            return index;
        }

        public static int LabelToNum(string label)
        {
            if (label == "Iris-setosa")
                return 0;
            else if (label == "Iris-versicolor")
                return 1;
            else
                return 2;
        }

        public static string identifyPrediction(int classes_num,double[,] arr)
        {
         
            int index = getMaxIndex(classes_num,arr);

            if (index == 0)
                return "Iris-setosa";
            else if (index == 1)
                return "Iris-versicolor";
            else
                return "Iris-virginica";
        }

        public static int countErrors(int classes_num, int sample_num, double[,] arr,string label)
        {
            int index = getMaxIndex(classes_num, arr);
            if (label =="Iris-setosa")
            {
                if (index == 0)
                    return 0;
            }
            if (label=="Iris-versicolor")
            {
                if (index == 1)
                    return 0;
            }
            if (label == "Iris-virginica")
            {
                if (index == 2)
                    return 0;
            }
            return 1;
        }

        public static double[,] multiply_ele_wise(double[,] arr1, double[,] arr2)
        {
            double[,] arr = new double[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr[i, j] = arr1[i, j] * arr2[i, j];
                }
            }
            return arr;
        }

        public static double[,] assignMatrix(double[,] arr1, double[,] arr2)
        {
           // double[,] arr = new double[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = arr2[i, j];
                }
            }
            return arr1;
        }

        public static double[,] sum_ele_wise(double[,] arr1, double[,] arr2)
        {
            double[,] arr = new double[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return arr;
        }

        public static double[,] multiply_scalar(double[,] arr1, double element)
        {
            double[,] arr = new double[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr[i, j] = arr1[i, j] * element;
                }
            }
            return arr;
        }

        public static double[,] subtract(double[,] arr1, double[,] arr2)
        {
            double[,] arr = new double[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr[i, j] = arr1[i, j] - arr2[i, j];
                }
            }
            return arr;
        }

        public static double[,] returnCopy(double[,] arr1)
        {
            double[,] ans = new double[arr1.GetLength(0),arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    ans[i,j] = arr1[i, j];
                }
            }
            return ans;
        }

        public static double summation(double[,] arr1)
        {
            double ans = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    ans+=  arr1[i, j] ;
                }
            }
            return Math.Round(ans,3);
        }
    }
}
