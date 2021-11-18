using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            //How many rows?
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
            tunneledVector = "01110111";
            //Initial variables
            int[] decodedVector = new int[Matrix.GetLength(0)];
            StringBuilder builder = new StringBuilder(tunneledVector);
            int currRow = Matrix.GetLength(0);

            //Some lists for decoding parameters
            List<string> lValues = GetLValues(); // l1 = 2, etc.
            List<string> tValues; //t=0, t=1, etc. t = 00, 01, 10, 11.
            List<string> wValues; //11001100, 00110011 etc.
            int lIndex = 0;

            //R values
            for (int rValue = R; rValue > -1; rValue--) //R, R-1, R-2 ... 0
            {
                int multiplications = HelperFunctions.Combination(M, rValue); //How many multiplications will be performed?
                currRow -= multiplications;

                //Multiplications
                for (int j = multiplications-1; j > -1; j--)
                {
                    //Initializing lists
                    tValues = new List<string>();
                    wValues = new List<string>();

                    if (lValues.Any()) //if there are any elements in the list
                    {
                        int tLength = lValues[lIndex].Length; //M - R(decremented)
                        int wCounter = (int)Math.Pow(2, tLength); //2^ tSIze. How many wVectors?

                        //Building the t vectors
                        for (int t = 0; t < wCounter; t++) //until we reach the required length
                        {
                            StringBuilder tBuilder = new StringBuilder(Convert.ToString(t, 2)); //binary
                            while (tBuilder.Length < tLength)
                            {
                                tBuilder.Insert(0, '0'); //adding zeros if needed
                            }
                            tValues.Add(tBuilder.ToString()); //adding generated value to the list
                        }

                        //Building w vectors
                        for (int w = 0; w < wCounter; w++)
                        {
                            StringBuilder wVector = new StringBuilder();
                            string currentTValue = tValues[w];

                            bool correct = true;
                            int currentLValue;

                            foreach (var aVector in aWords) //iterating thorugh the aWords
                            {
                                for (int i = 0; i < lValues[lIndex].Length; i++) //iterating through the l values
                                {
                                    currentLValue = Convert.ToInt32(lValues[lIndex].ElementAt(i).ToString()); //converting to number

                                    //Now checking the vector positions t=0, l=1 11110000 when m=3, r=2
                                    if (aVector[currentLValue - 1] != currentTValue[i]) //index -1 since counter starts from 0.
                                    {
                                        correct = false;
                                    }

                                }
                                if (correct) //found the position
                                {
                                    wVector.Append("1");
                                }
                                else //any other case returns 0
                                {
                                    wVector.Append("0");
                                    correct = true;
                                }
                            }
                            wValues.Add(wVector.ToString());
                        }

                        //Initial vector * w vectors
                        //1111111 * 11110000
                        int[] decoding = new int[wCounter];
                        for (int index = 0; index < decoding.Length; index++)
                        {
                            string currentW = wValues[index];
                            int sumDecoded = 0;

                            //now calculating decoded sum
                            for (int i = 0; i < Matrix.GetLength(1); i++) //columns
                            {
                                sumDecoded += Convert.ToInt32(currentW.ElementAt(i).ToString()) * Convert.ToInt32(tunneledVector[i].ToString());
                            }
                            sumDecoded %= 2; // we use binary
                            decoding[index] = sumDecoded;
                        }

                        //Now checking the number of 1 and 0. We will use the majority logic here.
                        int one = 0, zero = 0;
                        foreach (var item in decoding)
                        {
                            if (item == 1)
                            {
                                one++;
                            }
                            else
                            {
                                zero++;
                            }
                        } //How many 1 and 0?

                        if (one > zero)
                        {
                            decodedVector[currRow + j] = 1;
                        }
                        else if (one < zero)
                        {
                            decodedVector[currRow + j] = 0;
                        }
                        else //If the number of 1 and 0 is equal, we cannot determine if mistake was made.
                        {
                            decodedVector[currRow + j] = 0;
                        }
                        lValues.RemoveAt(0);

                    }

                }


                //Last multiplication lines
                //if (rValue > 0)
                //{
                //    StringBuilder subBuilder = new StringBuilder();
                //    int[] subArray = new int[aWords.Length];
                //    bool isEmpty = true;

                //    for (int i = currRow; i < currRow + multiplications; i++)
                //    {
                //        if (decodedVector[i] >= 1)
                //        {
                //            if (isEmpty)
                //            {
                //                for (int j = 0; j < aWords.Length; j++)
                //                {
                //                    subArray[j] = Matrix[i, j];
                //                }
                //                isEmpty = false;
                //            }
                //            else
                //            {
                //                for (int j = 0; j < aWords.Length; j++)
                //                {
                //                    subArray[j] = (subArray[j] + Matrix[i, j]) % 2;
                //                }
                //            }
                //        }
                //    }

                //    foreach (var item in subArray)
                //    {
                //        subBuilder.Append(item.ToString());
                //    }

                //    int[] tempArray = new int[aWords.Length];

                //    for (int j = 0; j < aWords.Length; j++)
                //    {
                //        tempArray[j] = Convert.ToInt32(subArray[j].ToString()) + Convert.ToInt32(subBuilder[j].ToString());
                //        tempArray[j] %= 2; //binary
                //        builder[j] = Convert.ToChar(tempArray[j].ToString());
                //    }
                //}


            }

            StringBuilder finalBuilder = new StringBuilder();
            foreach (var item in decodedVector)
            {
                finalBuilder.Append(item);
            }
            System.Windows.Forms.MessageBox.Show(finalBuilder.ToString());
            return finalBuilder.ToString();
        }

        //Funtions that gets all of the lValues
        private List<string> GetLValues()
        {
            List<string> lValues = new List<string>();
            List<int> temp = new List<int>();

            //As before, building an array for permutations
            int[] tempArray = new int[M];
            for (int i = 0; i < M; i++)
            {
                tempArray[i] = i + 1;
            }


            for (int currR = R; currR > 0; currR--) //getting all of the permuations
            {
                var result = HelperFunctions.GetPermutations(tempArray, currR);
                string a = "";
                for (int i = result.Count() - 1; i >= 0; i--)
                {
                    //using except {1 2 3}/{2,3} = {1}
                    List<int> tempList = tempArray.Except(result.ElementAt(i)).ToList();
                    foreach (var item in tempList)
                    {
                        a += item;
                    }
                    lValues.Add(a); //building a string
                    a = string.Empty;
                }
            }
            string elementAt0 = "";
            foreach (var item in tempArray)
            {
                elementAt0 += item;
            }
            lValues.Add(elementAt0);// {1,2,3} >> "123"

            return lValues;
        }
    }
}
