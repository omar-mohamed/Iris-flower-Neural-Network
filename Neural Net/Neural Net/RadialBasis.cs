using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Net
{
    class RadialBasis
    {
        double[,] weights;
        double[,] g;
        double[,] errors;
        double[,] spreads;
        double[,] centers;
        double[,] output;
        void gaussianFunction(double[,] sample, int numhidden)
        {
            g = new double[numhidden, 1];
            for (int i = 0; i < numhidden; i++)
            {
                double sum = 0;
                for (int j = 0; j < ReadData.trainingSet[0].GetLength(0); j++)
                {
                    sum += (sample[j, 0] - centers[j, 0]) * (sample[j, 0] - centers[j, 0]);
                }
                g[i, 0] = Math.Exp(-(sum / spreads[i, 0]));
            }
            g = Utilities.addBias(g);
        }

        void feedforward()
        {
            output = Utilities.multiply(weights, g);
        }

        void updateWeights(double learningRate)
        {
            weights = Utilities.sum_ele_wise(weights, Utilities.multiply_scalar(Utilities.multiply(errors, Utilities.transpose(g)), learningRate));
        }

        public void train(int numHiddenNeurons, int numIterations, double learningRate)
        {
            k_meansPlus kMeans = new k_meansPlus();
            double[,] confusionMatrix = new double[3, 3];
            weights = Utilities.getRandomWeights(3, numHiddenNeurons + 1);
            Tuple<double[,], double[,]> t = kMeans.cluster(numHiddenNeurons);
            spreads = Utilities.multiply_scalar(Utilities.squareElementWise(t.Item1), 2);
            centers = Utilities.transpose(t.Item2);
            for (int l = 0; l < numIterations; l++)
            {
                for (int i = 0; i < ReadData.trainingSet.Count; i++)
                {
                    gaussianFunction(ReadData.trainingSet[i], numHiddenNeurons);
                    feedforward();
                    output = Utilities.sigmoid(output, false);
                    errors = Utilities.calculateErrors(3, i, output, ReadData.trainingLabels[i]);
                    updateWeights(learningRate);
                }
            }

            int testErrors = 0;
            double accuracy = 0;
            for (int i = 0; i < ReadData.testSet.Count; i++)
            {
                gaussianFunction(ReadData.testSet[i], numHiddenNeurons);
                feedforward();
                output = Utilities.sigmoid(output, false);
                confusionMatrix[Utilities.LabelToNum(ReadData.testLabels[i]), Utilities.getMaxIndex(3, output)]++;
                testErrors += Utilities.countErrors(3, i, output, ReadData.testLabels[i]);
            }
            accuracy = (((double)ReadData.testSet.Count - (double)testErrors) / (double)ReadData.testSet.Count) * 100.0f;
            accuracy = Math.Round(accuracy, 2);
        }

    }
}
