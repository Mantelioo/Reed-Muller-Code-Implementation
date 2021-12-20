using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Reed_Miuller_Code_Implementation
{
    public partial class Form1 : Form
    {
        //kintamasis pradiniam vektoriui saugoti.
        string initialVector = string.Empty;
        string dataFromTunnel = string.Empty;
        int timerValue = 0;
        ReedMuller rm;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bntTest_Click(object sender, EventArgs e)
        {
            int[] array = { 1, 2, 3 };
            var result = HelperFunctions.GetPermutations(array, 2);

            //Getting the tuples. Testing the permutation
            foreach (var perm in result)
            {
                foreach (int c in perm)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }

        private void btnTunnel_Click(object sender, EventArgs e)
        {
            txtDataFromTunnel.Text = rm.SendTunnel(txtEncodedVector.Text, (int)numericProbability.Value, true);
            btnDecodeVector.Enabled = true;
        }

        private void btnEncodeVector_Click(object sender, EventArgs e)
        {
            if (txtData.Text.Length != rm.Matrix.GetLength(0))
            {
                MessageBox.Show($"Incorrect vector length. Must be {rm.Matrix.GetLength(0)}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                    

            initialVector = txtData.Text;

            timer1.Enabled = true;
            Thread.Sleep(1);
            initialVector = rm.EncodeVector(initialVector);
            timer1.Enabled = false;

            txtEncodedVector.Text = initialVector;

            MessageBox.Show($"Vector encoded. Time {timerValue}");
            timerValue = 0;
            btnTunnel.Enabled = true;
        }

        private void btnDecodeVector_Click(object sender, EventArgs e)
        {
           txtDecodedVector.Text = rm.DecodeVector(txtDataFromTunnel.Text);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //string a = "asd";
            //string b = "qwe";

            //string c = string.Concat(a, b);
            //MessageBox.Show(c);

            int[] tempArray = new int[3];
            for (int i = 0; i < 3; i++)
            {
                tempArray[i] = i + 1;
            }
            var result = HelperFunctions.GetPermutations(tempArray, 2);
            result = result.Concat(HelperFunctions.GetPermutations(tempArray, 3));
            

            string temp = "";
            foreach (var item in result)
            {
                foreach (var element in item)
                {
                    temp += element + " ";
                }
                temp += Environment.NewLine;
            }
            MessageBox.Show(temp);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           txtEncodedDecodedText.Text= rm.EncodeDecodeText(textbox1.Text,(int)numericProbability.Value);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (numericM.Value < 1 || numericR.Value > numericM.Value)
            {
                MessageBox.Show("Bad parameters M >= 1, R<=M", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            txtMatrix.Clear();
            rm = new ReedMuller((int)numericM.Value, (int)numericR.Value);

            initialVector = txtData.Text;

            txtMatrix.Text += "Adding initial vectors:" + Environment.NewLine;
            foreach (var item in rm.aWords)
            {
                txtMatrix.Text += item + " ";
            }
            txtMatrix.Text += Environment.NewLine;

            txtMatrix.Text += "Generated Matrix:" + Environment.NewLine;
            txtMatrix.Text += HelperFunctions.Matrix2DToString(rm.Matrix);

            button1.Enabled = true;
            btnEncodeVector.Enabled = true;
            btnTunnelString.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerValue++;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTunnelString_Click(object sender, EventArgs e)
        {
           txtTunneledString.Text= rm.TunneledString(textbox1.Text, (int)numericProbability.Value);
        }

        private void txtEncodedDecodedText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
