namespace Neural_Net
{
    partial class Form1
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
            this.trainButton = new System.Windows.Forms.Button();
            this.classifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trainButton
            // 
            this.trainButton.BackColor = System.Drawing.Color.DarkGray;
            this.trainButton.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainButton.ForeColor = System.Drawing.Color.Maroon;
            this.trainButton.Location = new System.Drawing.Point(34, 108);
            this.trainButton.Name = "trainButton";
            this.trainButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trainButton.Size = new System.Drawing.Size(194, 103);
            this.trainButton.TabIndex = 1;
            this.trainButton.Text = "Train dataset";
            this.trainButton.UseVisualStyleBackColor = false;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // classifyButton
            // 
            this.classifyButton.BackColor = System.Drawing.Color.DarkGray;
            this.classifyButton.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classifyButton.ForeColor = System.Drawing.Color.Maroon;
            this.classifyButton.Location = new System.Drawing.Point(315, 108);
            this.classifyButton.Name = "classifyButton";
            this.classifyButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.classifyButton.Size = new System.Drawing.Size(194, 103);
            this.classifyButton.TabIndex = 2;
            this.classifyButton.Text = "Classify input";
            this.classifyButton.UseVisualStyleBackColor = false;
            this.classifyButton.Click += new System.EventHandler(this.classifyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 301);
            this.Controls.Add(this.classifyButton);
            this.Controls.Add(this.trainButton);
            this.Name = "Form1";
            this.Text = "Iris NN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button classifyButton;
    }
}

