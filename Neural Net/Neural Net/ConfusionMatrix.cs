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
    public partial class ConfusionMatrix : Form
    {
        public ConfusionMatrix()
        {
            InitializeComponent();
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Iris-setosa";
            dataGridView1.Columns[1].Name = "Iris-versicolor";
            dataGridView1.Columns[2].Name = "Iris-virginica";
            dataGridView1.RowCount = 3;
            dataGridView1.Rows[0].HeaderCell.Value = "Iris-setosa";
            dataGridView1.Rows[1].HeaderCell.Value = "Iris-versicolor";
            dataGridView1.Rows[2].HeaderCell.Value = "Iris-virginica";
        }


        public void fillMatrix(double[,] arr)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
        }


    }
}
