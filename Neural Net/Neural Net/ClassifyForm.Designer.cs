namespace Neural_Net
{
    partial class ClassifyForm
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
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.textBoxX4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxClassification = new System.Windows.Forms.TextBox();
            this.buttonClassify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(47, 30);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(54, 20);
            this.textBoxX1.TabIndex = 0;
            this.textBoxX1.Text = "0";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(151, 30);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(53, 20);
            this.textBoxX2.TabIndex = 1;
            this.textBoxX2.Text = "0";
            // 
            // textBoxX3
            // 
            this.textBoxX3.Location = new System.Drawing.Point(263, 30);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(51, 20);
            this.textBoxX3.TabIndex = 2;
            this.textBoxX3.Text = "0";
            // 
            // textBoxX4
            // 
            this.textBoxX4.Location = new System.Drawing.Point(375, 30);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(48, 20);
            this.textBoxX4.TabIndex = 3;
            this.textBoxX4.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "X4";
            // 
            // textBoxClassification
            // 
            this.textBoxClassification.Enabled = false;
            this.textBoxClassification.Location = new System.Drawing.Point(164, 215);
            this.textBoxClassification.Name = "textBoxClassification";
            this.textBoxClassification.ReadOnly = true;
            this.textBoxClassification.Size = new System.Drawing.Size(150, 20);
            this.textBoxClassification.TabIndex = 8;
            this.textBoxClassification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClassify
            // 
            this.buttonClassify.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClassify.ForeColor = System.Drawing.Color.Maroon;
            this.buttonClassify.Location = new System.Drawing.Point(164, 109);
            this.buttonClassify.Name = "buttonClassify";
            this.buttonClassify.Size = new System.Drawing.Size(150, 60);
            this.buttonClassify.TabIndex = 9;
            this.buttonClassify.Text = "Classify";
            this.buttonClassify.UseVisualStyleBackColor = true;
            this.buttonClassify.Click += new System.EventHandler(this.buttonClassify_Click);
            // 
            // ClassifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 284);
            this.Controls.Add(this.buttonClassify);
            this.Controls.Add(this.textBoxClassification);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxX4);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Name = "ClassifyForm";
            this.Text = "ClassifyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassifyForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.TextBox textBoxX4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxClassification;
        private System.Windows.Forms.Button buttonClassify;
    }
}