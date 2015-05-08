using System;
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
    public partial class ClassifyForm : Form
    {
        private Neural_Network pretrainedNN;
        public ClassifyForm()
        {
            ReadData.readData();
            pretrainedNN = new Neural_Network();
            int[] layers = new int[4];
            layers[0] = 4;
            layers[1] = 3;
            layers[2] = 4;
            layers[3] = 3;
            pretrainedNN.train(layers,1000,0.1);
            InitializeComponent();
        }

        private void buttonClassify_Click(object sender, EventArgs e)
        {
            double[,] input = new double[5,1];
            input[0, 0] = 1;
            input[1, 0] = Convert.ToDouble(textBoxX1.Text);
            input[2, 0] = Convert.ToDouble(textBoxX2.Text);
            input[3, 0] = Convert.ToDouble(textBoxX3.Text);
            input[4, 0] = Convert.ToDouble(textBoxX4.Text);
            for (int i = 1; i <= 4; i++)
            {
                input[i, 0] -= ReadData.mean[i - 1];
                input[i, 0] /= ReadData.max[i - 1];
            }
                textBoxClassification.Text = pretrainedNN.classify(input);
        }

        private void ClassifyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBoxX1.Text="0";
            textBoxX2.Text="0";
            textBoxX3.Text="0";
            textBoxX4.Text = "0";
            textBoxClassification.Text = "";
            this.Visible = false;
            e.Cancel = true;
        }
    }
}
