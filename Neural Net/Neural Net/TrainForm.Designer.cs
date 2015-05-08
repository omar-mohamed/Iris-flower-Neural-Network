namespace Neural_Net
{
    partial class TrainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTrain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLayers = new System.Windows.Forms.TextBox();
            this.textBoxNum_Iteraions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAccuracy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTrain
            // 
            this.buttonTrain.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrain.ForeColor = System.Drawing.Color.Maroon;
            this.buttonTrain.Location = new System.Drawing.Point(239, 194);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(150, 60);
            this.buttonTrain.TabIndex = 10;
            this.buttonTrain.Text = "Train";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hidden Layers";
            // 
            // textBoxLayers
            // 
            this.textBoxLayers.Location = new System.Drawing.Point(193, 37);
            this.textBoxLayers.Name = "textBoxLayers";
            this.textBoxLayers.Size = new System.Drawing.Size(331, 20);
            this.textBoxLayers.TabIndex = 12;
            this.textBoxLayers.Text = "3 4";
            // 
            // textBoxNum_Iteraions
            // 
            this.textBoxNum_Iteraions.Location = new System.Drawing.Point(193, 74);
            this.textBoxNum_Iteraions.Name = "textBoxNum_Iteraions";
            this.textBoxNum_Iteraions.Size = new System.Drawing.Size(74, 20);
            this.textBoxNum_Iteraions.TabIndex = 14;
            this.textBoxNum_Iteraions.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Number of iterations";
            // 
            // textBoxEta
            // 
            this.textBoxEta.Location = new System.Drawing.Point(193, 109);
            this.textBoxEta.Name = "textBoxEta";
            this.textBoxEta.Size = new System.Drawing.Size(74, 20);
            this.textBoxEta.TabIndex = 16;
            this.textBoxEta.Text = "0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "learning rate";
            // 
            // textBoxAccuracy
            // 
            this.textBoxAccuracy.Location = new System.Drawing.Point(279, 276);
            this.textBoxAccuracy.Name = "textBoxAccuracy";
            this.textBoxAccuracy.ReadOnly = true;
            this.textBoxAccuracy.Size = new System.Drawing.Size(74, 20);
            this.textBoxAccuracy.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Accuracy";
            // 
            // TrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 318);
            this.Controls.Add(this.textBoxAccuracy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNum_Iteraions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTrain);
            this.Name = "TrainForm";
            this.Text = "TrainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLayers;
        private System.Windows.Forms.TextBox textBoxNum_Iteraions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAccuracy;
        private System.Windows.Forms.Label label4;
    }
}