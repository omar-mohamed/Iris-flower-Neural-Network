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
    public partial class Form1 : Form
    {
        ClassifyForm classifyForm;
        TrainForm trainForm;
        public Form1()
        {
            classifyForm = new ClassifyForm();
            InitializeComponent();
        }
      
        private void classifyButton_Click(object sender, EventArgs e)
        {
            classifyForm.Show();
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            trainForm = new TrainForm();
            trainForm.Show();
        }
    }
}
