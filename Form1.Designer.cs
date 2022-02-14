namespace Part_4___Random_Assignment
{
    partial class RandomNumbers
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
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numPrecision = new System.Windows.Forms.NumericUpDown();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPrecision = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecision)).BeginInit();
            this.SuspendLayout();
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(192, 38);
            this.numMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(120, 20);
            this.numMin.TabIndex = 0;
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(192, 78);
            this.numMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(120, 20);
            this.numMax.TabIndex = 1;
            // 
            // numPrecision
            // 
            this.numPrecision.Location = new System.Drawing.Point(192, 116);
            this.numPrecision.Name = "numPrecision";
            this.numPrecision.Size = new System.Drawing.Size(120, 20);
            this.numPrecision.TabIndex = 2;
            this.numPrecision.ValueChanged += new System.EventHandler(this.numPrecision_ValueChanged);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(413, 38);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(130, 41);
            this.btnInt.TabIndex = 3;
            this.btnInt.Text = "Get Integer";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(413, 95);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(130, 41);
            this.btnDouble.TabIndex = 4;
            this.btnDouble.Text = "Get Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(12, 40);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(88, 13);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Minimum Value:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(12, 80);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(91, 13);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Maximum Value:";
            // 
            // lblPrecision
            // 
            this.lblPrecision.AutoSize = true;
            this.lblPrecision.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecision.Location = new System.Drawing.Point(12, 118);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(174, 13);
            this.lblPrecision.TabIndex = 7;
            this.lblPrecision.Text = "# of decimal places (for double):";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Romantic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblNumber.Location = new System.Drawing.Point(12, 183);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(20, 21);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "0";
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(555, 241);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblPrecision);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.numPrecision);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.numMin);
            this.Name = "RandomNumbers";
            this.Text = "Random Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.NumericUpDown numPrecision;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPrecision;
        private System.Windows.Forms.Label lblNumber;
    }
}

