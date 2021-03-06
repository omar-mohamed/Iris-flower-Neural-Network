﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Net
{
    public partial class TrainForm : Form
    {
        public TrainForm()
        {
            InitializeComponent();
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = {' '};
            string[] words =  textBoxLayers.Text.Split(delimiterChars);
            List<int> layersList=new List<int>();
            layersList.Add(4);
            for(int i=0;i<words.Length;i++)
            {
                if(words[i]!="")
                  layersList.Add(Convert.ToInt32(words[i]));
            }
            layersList.Add(3);
            int[] layers = layersList.ToArray();
            Neural_Network NN = new Neural_Network();
            Tuple<double, double[,]> t = NN.train(layers, Convert.ToInt32(textBoxNum_Iteraions.Text), Convert.ToDouble(textBoxEta.Text));
            ConfusionMatrix CM = new ConfusionMatrix();
            CM.fillMatrix(t.Item2);
            textBoxAccuracy.Text = t.Item1.ToString()+'%';
            CM.Show();
        }
    }
}
