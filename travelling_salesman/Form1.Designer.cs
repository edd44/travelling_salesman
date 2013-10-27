namespace travelling_salesman
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonShowDist = new System.Windows.Forms.Button();
            this.groupBoxSequence = new System.Windows.Forms.GroupBox();
            this.textBoxSequence = new System.Windows.Forms.TextBox();
            this.labelSequenceIntr = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxSequence.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(9, 17);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(122, 31);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Otwórz plik";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonShowDist
            // 
            this.buttonShowDist.Enabled = false;
            this.buttonShowDist.Location = new System.Drawing.Point(9, 54);
            this.buttonShowDist.Name = "buttonShowDist";
            this.buttonShowDist.Size = new System.Drawing.Size(122, 31);
            this.buttonShowDist.TabIndex = 1;
            this.buttonShowDist.Text = "Pokaż odległości";
            this.buttonShowDist.UseVisualStyleBackColor = true;
            this.buttonShowDist.Click += new System.EventHandler(this.buttonShowDist_Click);
            // 
            // groupBoxSequence
            // 
            this.groupBoxSequence.Controls.Add(this.labelSequenceIntr);
            this.groupBoxSequence.Controls.Add(this.textBoxSequence);
            this.groupBoxSequence.Enabled = false;
            this.groupBoxSequence.Location = new System.Drawing.Point(9, 103);
            this.groupBoxSequence.Name = "groupBoxSequence";
            this.groupBoxSequence.Size = new System.Drawing.Size(248, 89);
            this.groupBoxSequence.TabIndex = 2;
            this.groupBoxSequence.TabStop = false;
            this.groupBoxSequence.Text = "Sekwencja przejazdu";
            // 
            // textBoxSequence
            // 
            this.textBoxSequence.Location = new System.Drawing.Point(6, 27);
            this.textBoxSequence.Name = "textBoxSequence";
            this.textBoxSequence.Size = new System.Drawing.Size(236, 20);
            this.textBoxSequence.TabIndex = 0;
            // 
            // labelSequenceIntr
            // 
            this.labelSequenceIntr.AutoSize = true;
            this.labelSequenceIntr.Location = new System.Drawing.Point(6, 50);
            this.labelSequenceIntr.Name = "labelSequenceIntr";
            this.labelSequenceIntr.Size = new System.Drawing.Size(0, 13);
            this.labelSequenceIntr.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Enabled = false;
            this.buttonCalculate.Location = new System.Drawing.Point(6, 18);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(122, 31);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Oblicz drogę";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wynik:";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(52, 59);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.ReadOnly = true;
            this.textBoxDistance.Size = new System.Drawing.Size(129, 20);
            this.textBoxDistance.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCalculate);
            this.groupBox1.Controls.Add(this.textBoxDistance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obliczenia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSequence);
            this.Controls.Add(this.buttonShowDist);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "Komiwojażer";
            this.groupBoxSequence.ResumeLayout(false);
            this.groupBoxSequence.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonShowDist;
        private System.Windows.Forms.GroupBox groupBoxSequence;
        private System.Windows.Forms.Label labelSequenceIntr;
        private System.Windows.Forms.TextBox textBoxSequence;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

