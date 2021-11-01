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

        public List<string> filteredMatrix = new List<string>();

        public ReedMuller(int m, int r)
        {
            this.R = r;
            this.M = m;
            this.Columns = (int)Math.Pow(2, m);

            FillAWordsArray(Columns);
            GenerateMatrix();

        }

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


            //////////////////////////////////////////////////////
            //////////////////////////////////////////////////////
            if (R > 1) //Creating binary matrix
            {
                for (int i = 0; i < Columns; i++)
                {
                    string temp = Convert.ToString(i, 2); //to binary string
                    while (temp.Length < M)
                    {
                        temp = '0' + temp;
                    }
                    string buildString = temp;
                    buildString.Reverse();
                    temp = buildString;

                    //How many 1s in temp?
                    int countOnes = temp.Count(a => a == '1');

                    if (countOnes > 1 && countOnes <= R)
                    {
                        int amountOfOnes = 0;
                        for (int j = 0; j < filteredMatrix.Count; j++)
                        {
                            int tempInt = filteredMatrix[j].Count(a => a == '1');
                            if (amountOfOnes < tempInt)
                            {
                                amountOfOnes = tempInt;
                            }
                        }
                        if (countOnes >= amountOfOnes)
                        {
                            filteredMatrix.Add(temp);
                        }
                        else
                        {
                            for (int j = 0; j < filteredMatrix.Count; j++)
                            {
                                if (countOnes < filteredMatrix[j].Count(a => a == '1'))
                                {
                                    filteredMatrix.Insert(j, temp);
                                    break;
                                }
                            }
                        }
                    }
                }

                int counter = 0;
                for (int i = M + 1; i < rowCount; i++)
                {
                    string multiply = filteredMatrix[counter];
                    for (int j = 0; j < Columns; j++)
                    {
                        int multiplyNumber = 1;
                        for (int k = 0; k < M; k++)
                        {
                            if (multiply[1] == '1')
                            {
                                multiplyNumber *= Matrix[k + 1, j];
                            }
                        }
                        Matrix[i, j] = multiplyNumber;
                    }
                    counter++;
                }

                for (int i = M; i > 0; i--)
                {
                    string temp = "0";
                    while (temp.Length < M)
                    {
                        temp = '0' + temp;
                    }
                    StringBuilder sb = new StringBuilder(temp);
                    sb[i - 1] = '1';
                    temp = sb.ToString();

                    filteredMatrix.Insert(0, temp);
                }

                StringBuilder v0Line = new StringBuilder("0");
                while (v0Line.Length < M)
                {
                    v0Line.Insert(0, '0');
                }

                filteredMatrix.Insert(0, v0Line.ToString());
            }
            //////////////////////////////////////////////////////
            //////////////////////////////////////////////////////


        }
    }
}
