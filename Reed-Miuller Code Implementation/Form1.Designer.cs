
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
            this.components = new System.ComponentModel.Container();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncodeVector = new System.Windows.Forms.Button();
            this.numericM = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericR = new System.Windows.Forms.NumericUpDown();
            this.btnTunnel = new System.Windows.Forms.Button();
            this.txtEncodedVector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataFromTunnel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDecodedVector = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDecodeVector = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.numericProbability = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTunnelString = new System.Windows.Forms.Button();
            this.txtTunneledString = new System.Windows.Forms.TextBox();
            this.txtEncodedDecodedText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProbability)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter binary vector";
            // 
            // txtMatrix
            // 
            this.txtMatrix.Location = new System.Drawing.Point(12, 184);
            this.txtMatrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ReadOnly = true;
            this.txtMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatrix.Size = new System.Drawing.Size(318, 211);
            this.txtMatrix.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matrix";
            // 
            // btnEncodeVector
            // 
            this.btnEncodeVector.Enabled = false;
            this.btnEncodeVector.Location = new System.Drawing.Point(11, 469);
            this.btnEncodeVector.Name = "btnEncodeVector";
            this.btnEncodeVector.Size = new System.Drawing.Size(319, 35);
            this.btnEncodeVector.TabIndex = 4;
            this.btnEncodeVector.Text = "Encode vector";
            this.btnEncodeVector.UseVisualStyleBackColor = true;
            this.btnEncodeVector.Click += new System.EventHandler(this.btnEncodeVector_Click);
            // 
            // numericM
            // 
            this.numericM.Location = new System.Drawing.Point(12, 45);
            this.numericM.Name = "numericM";
            this.numericM.Size = new System.Drawing.Size(52, 30);
            this.numericM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "R";
            // 
            // numericR
            // 
            this.numericR.Location = new System.Drawing.Point(82, 45);
            this.numericR.Name = "numericR";
            this.numericR.Size = new System.Drawing.Size(52, 30);
            this.numericR.TabIndex = 9;
            // 
            // btnTunnel
            // 
            this.btnTunnel.Enabled = false;
            this.btnTunnel.Location = new System.Drawing.Point(11, 510);
            this.btnTunnel.Name = "btnTunnel";
            this.btnTunnel.Size = new System.Drawing.Size(319, 38);
            this.btnTunnel.TabIndex = 11;
            this.btnTunnel.Text = "Send through tunnel";
            this.btnTunnel.UseVisualStyleBackColor = true;
            this.btnTunnel.Click += new System.EventHandler(this.btnTunnel_Click);
            // 
            // txtEncodedVector
            // 
            this.txtEncodedVector.Location = new System.Drawing.Point(534, 45);
            this.txtEncodedVector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncodedVector.Name = "txtEncodedVector";
            this.txtEncodedVector.Size = new System.Drawing.Size(316, 30);
            this.txtEncodedVector.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Encoded Vector";
            // 
            // txtDataFromTunnel
            // 
            this.txtDataFromTunnel.Location = new System.Drawing.Point(535, 120);
            this.txtDataFromTunnel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataFromTunnel.Name = "txtDataFromTunnel";
            this.txtDataFromTunnel.Size = new System.Drawing.Size(315, 30);
            this.txtDataFromTunnel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data from tunnel";
            // 
            // txtDecodedVector
            // 
            this.txtDecodedVector.Location = new System.Drawing.Point(533, 194);
            this.txtDecodedVector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDecodedVector.Name = "txtDecodedVector";
            this.txtDecodedVector.Size = new System.Drawing.Size(316, 30);
            this.txtDecodedVector.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Decoded vector";
            // 
            // btnDecodeVector
            // 
            this.btnDecodeVector.Enabled = false;
            this.btnDecodeVector.Location = new System.Drawing.Point(12, 554);
            this.btnDecodeVector.Name = "btnDecodeVector";
            this.btnDecodeVector.Size = new System.Drawing.Size(318, 35);
            this.btnDecodeVector.TabIndex = 18;
            this.btnDecodeVector.Text = "Decode vector";
            this.btnDecodeVector.UseVisualStyleBackColor = true;
            this.btnDecodeVector.Click += new System.EventHandler(this.btnDecodeVector_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(537, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Encode and decode text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(197, 41);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(133, 34);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(536, 243);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(313, 70);
            this.textbox1.TabIndex = 22;
            this.textbox1.Text = "Enter text to encode";
            // 
            // numericProbability
            // 
            this.numericProbability.Location = new System.Drawing.Point(12, 433);
            this.numericProbability.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericProbability.Name = "numericProbability";
            this.numericProbability.Size = new System.Drawing.Size(131, 30);
            this.numericProbability.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Error probability";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTunnelString
            // 
            this.btnTunnelString.Enabled = false;
            this.btnTunnelString.Location = new System.Drawing.Point(533, 320);
            this.btnTunnelString.Name = "btnTunnelString";
            this.btnTunnelString.Size = new System.Drawing.Size(314, 41);
            this.btnTunnelString.TabIndex = 25;
            this.btnTunnelString.Text = "Send text through tunnel";
            this.btnTunnelString.UseVisualStyleBackColor = true;
            this.btnTunnelString.Click += new System.EventHandler(this.btnTunnelString_Click);
            // 
            // txtTunneledString
            // 
            this.txtTunneledString.Location = new System.Drawing.Point(537, 369);
            this.txtTunneledString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTunneledString.Multiline = true;
            this.txtTunneledString.Name = "txtTunneledString";
            this.txtTunneledString.Size = new System.Drawing.Size(313, 80);
            this.txtTunneledString.TabIndex = 26;
            this.txtTunneledString.Text = "Text from tunnel";
            this.txtTunneledString.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEncodedDecodedText
            // 
            this.txtEncodedDecodedText.Location = new System.Drawing.Point(539, 502);
            this.txtEncodedDecodedText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncodedDecodedText.Multiline = true;
            this.txtEncodedDecodedText.Name = "txtEncodedDecodedText";
            this.txtEncodedDecodedText.ReadOnly = true;
            this.txtEncodedDecodedText.Size = new System.Drawing.Size(313, 80);
            this.txtEncodedDecodedText.TabIndex = 27;
            this.txtEncodedDecodedText.Text = "Encoding > Sending through tunnel > Decoding";
            this.txtEncodedDecodedText.TextChanged += new System.EventHandler(this.txtEncodedDecodedText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 600);
            this.Controls.Add(this.txtEncodedDecodedText);
            this.Controls.Add(this.txtTunneledString);
            this.Controls.Add(this.btnTunnelString);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericProbability);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDecodeVector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDecodedVector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDataFromTunnel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEncodedVector);
            this.Controls.Add(this.btnTunnel);
            this.Controls.Add(this.numericR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericM);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProbability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncodeVector;
        private System.Windows.Forms.NumericUpDown numericM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericR;
        private System.Windows.Forms.Button btnTunnel;
        private System.Windows.Forms.TextBox txtEncodedVector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataFromTunnel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDecodedVector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDecodeVector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.NumericUpDown numericProbability;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTunnelString;
        private System.Windows.Forms.TextBox txtTunneledString;
        private System.Windows.Forms.TextBox txtEncodedDecodedText;
    }
}

