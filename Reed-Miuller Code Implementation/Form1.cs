using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reed_Miuller_Code_Implementation
{
    public partial class Form1 : Form
    {
        //kintamasis pradiniam vektoriui saugoti.
        string initialVector = string.Empty;
        ReedMuller rm = new ReedMuller(3, 2);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialVector = txtData.Text;

            txtMatrix.Text += "Adding initial vectors:" + Environment.NewLine;
            foreach (var item in rm.aWords)
            {
                txtMatrix.Text += item + " ";
            }
            txtMatrix.Text += Environment.NewLine;

            txtMatrix.Text += "Generated Matrix:" + Environment.NewLine;
            txtMatrix.Text += HelperFunctions.Matrix2DToString(rm.Matrix);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMatrix.Text += Environment.NewLine;
            foreach (var item in rm.filteredMatrix)
            {
                txtMatrix.Text += item + Environment.NewLine;
            }
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
    }
}
