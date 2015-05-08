using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Net
{
   static class ReadData
   {
       #region data members
        private static List<double[,]> features;
        private static string[] labels;
        public static List<double[,]> trainingSet;
        public static List<double[,]> testSet;
        public static List<string> trainingLabels;
        public static List<string> testLabels;
        public static double[] max;
        public static double[] mean;
       #endregion

        #region handle data
        public static void readData()
        {
            mean=new double[4];
            mean[0] = mean[1] = mean[2] = mean[3] = 0;

            max = new double[4];
            max[0] = max[1] = max[2] = max[3] = -1000000000;

            features=new List<double[,]>();
            labels = new string[150];
            string[] lines = System.IO.File.ReadAllLines(@"Iris Data.txt");
            char[] delimiterChars = {','};
            int row=0;
            foreach (string line in lines)
            {
                if (row > 0)
                {
                    string[] words = line.Split(delimiterChars);
                    double[,] arr=new double[5,1]; 
                    arr[0, 0] = 1;

                    arr[1, 0] = Convert.ToDouble(words[0]);
                    mean[0] += arr[1, 0];

                    arr[2, 0] = Convert.ToDouble(words[1]);
                    mean[1] += arr[2, 0];

                    arr[3, 0] = Convert.ToDouble(words[2]);
                    mean[2] += arr[3, 0];

                    arr[4, 0] = Convert.ToDouble(words[3]);
                    mean[3] += arr[4, 0];

                    features.Add(arr);
                    labels[row-1] = words[4];
                }
                row++;
            }
            row--;
            mean[0] /= row;
            mean[1] /= row;
            mean[2] /= row;
            mean[3] /= row;
            removeMean();
            normalizeData();
            divideFeatures(30);
        }

        private static void removeMean()
        {
            for (int i = 0; i < features.Count; i++)
                for (int j = 1; j <= 4; j++)
                {
                    features[i][j, 0] -= mean[j-1];
                    max[j-1] = Math.Max(max[j-1], Math.Abs(features[i][j, 0]));
                }
        }

        private static void normalizeData()
        {
            for (int i = 0; i < features.Count; i++)
                for (int j = 1; j <= 4; j++)
                    features[i][j, 0]/= max[j-1] ;
        }

        private static void divideFeatures(int numTrainingSamples)
       {
           trainingSet = new List<double[,]>();
           testSet = new List<double[,]>();
           testLabels = new List<string>();
           trainingLabels = new List<string>();
           int index = 0;
           int numTestSamples = 50 - numTrainingSamples;
           while (index < features.Count)
           {
               for (int i = 0; i < numTrainingSamples; i++)
               {
                   trainingSet.Add(features[index]);
                   trainingLabels.Add(labels[index]);
                   index++;
               }
               for (int i = 0; i < numTestSamples; i++)
               {
                   testSet.Add(features[index]);
                   testLabels.Add(labels[index]);
                   index++;
               }
           }
       }
        #endregion
   }
}
