using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reed_Miuller_Code_Implementation
{
    class ReedMuller
    {
        public int R { get; private set; }
        public int M { get; private set; }
        public int Columns { get; private set; }
        public string[] aWords { get; private set; } //array of a vectors (000, 001, 010, 100, etc.)
        public int[,] Matrix { get; private set; } // v vectors. Saving the whole matrix



        public ReedMuller(int m, int r)
        {
            this.R = r;
            this.M = m;
            this.Columns = (int)Math.Pow(2, m);

            FillAWordsArray(Columns); //adding aVectors
            GenerateMatrix(); //GeneratingMatrix calculation
        }

        //Function that creates a vectors 000 001 010 011 etc.
        private void FillAWordsArray(int columns)
        {
            aWords = new string[columns]; //kiek pradiniu vektoriu bus?
                                          //Didziausia reiksme, kuria skaicius gali gauti yra 2^m. 2^3 = 8 (111)
            int temp = 0;
            for (int i = 0; i < columns; i++)
            {
                aWords[i] = Convert.ToString(temp, 2);

                while (aWords[i].Length < M)
                {
                    aWords[i] = '0' + aWords[i];
                }
                temp++;
            }
        }

        //Creating the Matrix
        private void GenerateMatrix()
        {
            //1) Need to find the number of initial rows
            //1 + C1m + C2m + Crm

            int rowCount = 1; //There will always be at least 1 row
            if (R > 0) //if more than 1 row
            {
                rowCount += M; //How many base V vectors (V1, V2, V3 ... Vn)
            }

            for (int i = 2; i <= R; i++)
            {
                rowCount += HelperFunctions.Combination(M, i);
            }

            //Generating the matrix
            Matrix = new int[rowCount, Columns];

            //The first vector in the matrix is (1,1,1,1.....1). Filling with 1s
            for (int i = 0; i < Columns; i++)
            {
                Matrix[0, i] = 1;
            }

            //Need to fill vectors v1, v2, v3 ... vn
            if (R > 0)
            {
                for (int i = 1; i <= M; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (aWords[j][i - 1] == '0') // if Position == '0", value is 0 in the matrix
                        {
                            Matrix[i, j] = 1;
                        }
                        else
                        {
                            Matrix[i, j] = 0;
                        }
                    }
                }
            }
            if (R > 1) //Creating binary matrix
            {
                //Preparing the array for permution calculations
                int[] tempArray = new int[M];
                for (int i = 0; i < M; i++)
                {
                    tempArray[i] = i + 1;
                }

                //Geting the permutations
                var result = HelperFunctions.GetPermutations(tempArray, R); //getting all of the rows permutations

                //Multiplying the rows and adding them to the matrix
                HelperFunctions.MultiplyMatrixRows(Matrix, result, M + 1); //multiplying the rows
            }
        }

        //Sends encoded vector via tunnel
        public string SendTunnel(string encodedVector, int probability)
        {
            StringBuilder builder = new StringBuilder();
            Random rnd = new Random();
            int errors = 0;
            int temp = 0;

            System.Windows.Forms.MessageBox.Show("Errors were made at: ");
            for (int i = 0; i < encodedVector.Length; i++) //iterating through the vector
            {
                if (probability > rnd.Next(0, 10000))
                {
                    temp = Convert.ToInt32(encodedVector[i]); //changing the value
                    temp = (temp + 1) % 2; //we use binary
                    builder.Append(temp);
                    System.Windows.Forms.MessageBox.Show($"{temp} ");
                    errors++;
                }
                else //just add the initial vector
                {
                    builder.Append(encodedVector[i]);
                }
            }
            System.Windows.Forms.MessageBox.Show($"Total Errors: {errors}");

            return builder.ToString();
        }

        //Encoding the initial vector by using the matrix
        public string EncodeVector(string vector)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < Matrix.GetLength(1); i++) //columns
            {
                int calculations = 0;
                for (int j = 0; j < Matrix.GetLength(0); j++) //rows
                {
                    calculations += Matrix[j, i] * Convert.ToInt32(vector[j]);
                }
                calculations %= 2; //since we use binary
                builder.Append(calculations);
            }
            return builder.ToString();
        }

        //Decoding information
        public string DecodeVector(string tunneledVector)
        {
            //Initial variables
            int[] decodedVector = new int[Matrix.GetLength(0)];
            StringBuilder builder = new StringBuilder(tunneledVector);
            int currentRow = Matrix.GetLength(0); //temp variable for saving row

            //Some lists for decoding parameters
            List<int> lValues; // l1 = 2, etc.
            List<int> tValues; //t=0, t=1, etc.
            List<int> wValues; //11001100, 00110011 etc.

            //R combinations
            for (int rValue = R; rValue > -1; rValue--) //R, R-1, R-2 ... 0
            {
                int multiplications = HelperFunctions.Combination(M, rValue); //How many multiplications will be performed?
                currentRow -= multiplications;

                //Multiplications
                for (int j = 0; j < multiplications; j++)
                {
                    //Initializing lists
                    lValues = GetLValues(); //receiving lValues from seperate method
                    tValues = new List<int>();
                    wValues = new List<int>();

                    StringBuilder tBuilder;

                    int tSize = M - rValue; //M - R(decremented)
                    int wSize = (int)Math.Pow(2, tSize); //2^ tSIze

                    for (int i = 0; i < wSize; i++)
                    {
                       // tBuilder = new StringBuilder(Convert.ToInt32(i, 2);

                        //while (tBuilder.Length < tSize)
                        //{
                        //    tBuilder.Insert(0, "0");

                        //}
                    }
                }
            }
            return "";
        }

        private List<int> GetLValues()
        {
            List<int> lValues = new List<int>();

            //We will need the permutations to find lValues
            int[] tempArray = new int[M];
            for (int i = 0; i < M; i++)
            {
                tempArray[i] = i + 1;
            }
            var result = HelperFunctions.GetPermutations(tempArray, 2);

            //Searching for lValues from the end of the Matrix
            for (int i = result.Count() - 1; i > -1; i--)
            {
                List<int> tempList = new List<int>();
                foreach (var item in result.ElementAt(i))
                {
                    tempList.Add(item);
                }
                var exceptElements = tempArray.Except(tempList); // {2,3} and {1, 2, 3} returns 1
                foreach (var item in exceptElements)
                {
                    lValues.Add(item);
                }
            }
            return lValues;
        }
    }
}
