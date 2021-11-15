
namespace Reed_Miuller_Code_Implementation
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncodeVector = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnTunnel = new System.Windows.Forms.Button();
            this.txtEncodedVector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataFromTunnel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDecodeVector = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 119);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(318, 30);
            this.txtData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter text";
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(12, 184);
            this.txtMatrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ReadOnly = true;
            this.txtMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatrix.Size = new System.Drawing.Size(318, 198);
            this.txtMatrix.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matrix";
            // 
            // btnEncodeVector
            // 
            this.btnEncodeVector.Location = new System.Drawing.Point(11, 390);
            this.btnEncodeVector.Name = "btnEncodeVector";
            this.btnEncodeVector.Size = new System.Drawing.Size(141, 35);
            this.btnEncodeVector.TabIndex = 4;
            this.btnEncodeVector.Text = "Encode vector";
            this.btnEncodeVector.UseVisualStyleBackColor = true;
            this.btnEncodeVector.Click += new System.EventHandler(this.btnEncodeVector_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 45);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 30);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "R";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(70, 45);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(52, 30);
            this.numericUpDown2.TabIndex = 9;
            // 
            // btnTunnel
            // 
            this.btnTunnel.Location = new System.Drawing.Point(11, 431);
            this.btnTunnel.Name = "btnTunnel";
            this.btnTunnel.Size = new System.Drawing.Size(141, 58);
            this.btnTunnel.TabIndex = 11;
            this.btnTunnel.Text = "Send through tunnel";
            this.btnTunnel.UseVisualStyleBackColor = true;
            this.btnTunnel.Click += new System.EventHandler(this.btnTunnel_Click);
            // 
            // txtEncodedVector
            // 
            this.txtEncodedVector.Location = new System.Drawing.Point(415, 45);
            this.txtEncodedVector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncodedVector.Name = "txtEncodedVector";
            this.txtEncodedVector.Size = new System.Drawing.Size(248, 30);
            this.txtEncodedVector.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Encoded Vector";
            // 
            // txtDataFromTunnel
            // 
            this.txtDataFromTunnel.Location = new System.Drawing.Point(415, 119);
            this.txtDataFromTunnel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataFromTunnel.Name = "txtDataFromTunnel";
            this.txtDataFromTunnel.Size = new System.Drawing.Size(248, 30);
            this.txtDataFromTunnel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data from tunnel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 195);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 30);
            this.textBox1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Decoded vector";
            // 
            // btnDecodeVector
            // 
            this.btnDecodeVector.Location = new System.Drawing.Point(189, 390);
            this.btnDecodeVector.Name = "btnDecodeVector";
            this.btnDecodeVector.Size = new System.Drawing.Size(141, 35);
            this.btnDecodeVector.TabIndex = 18;
            this.btnDecodeVector.Text = "Decode vector";
            this.btnDecodeVector.UseVisualStyleBackColor = true;
            this.btnDecodeVector.Click += new System.EventHandler(this.btnDecodeVector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 563);
            this.Controls.Add(this.btnDecodeVector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDataFromTunnel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEncodedVector);
            this.Controls.Add(this.btnTunnel);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnEncodeVector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncodeVector;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnTunnel;
        private System.Windows.Forms.TextBox txtEncodedVector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataFromTunnel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDecodeVector;
    }
}

