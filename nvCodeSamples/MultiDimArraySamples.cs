using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nvCodeSamples
{
    class MultiDimArraySamples
    {
        public int[,] Minesweeper(int[][] bombs, int numRows, int numCol)
        {
            int[,] minesweeper = new int[numRows, numCol];
            foreach (int[] bom in bombs)
            {
                int rowIndex = bom[0];
                int colIndex = bom[1];

                minesweeper[rowIndex, colIndex] = -1;

                for (int i = rowIndex - 1; i < rowIndex + 2; i++)
                {
                    for (int j = colIndex - 1; j < colIndex + 2; j++)
                    {
                        if (i >= 0 && i < numRows &&
                            j >= 0 && j < numCol &&
                            minesweeper[i, j] != -1)
                        {
                            minesweeper[i, j] += 1;
                        }

                    }
                }
            }
            for (int i = 0; i <= numRows - 1; i++)
            {
                for (int j = 0; j <= numCol - 1; j++)
                {
                    Console.Write($"{minesweeper[i, j]} ");
                }
                Console.WriteLine();
            }

            return minesweeper;
        }
        public void expandMinesweeper(int[,] minefield, int numRows, int numCol, int selectedRow, int selectedCol)
        {
            if (minefield[selectedRow, selectedCol] == 0)
            {
                minefield[selectedRow, selectedCol] = -2;
            }

            List<int[]> checkQueue = new List<int[]>();
            checkQueue.Add(new int[] { selectedRow, selectedCol });


            /*int[][] checkQueue = new int[][]
            {
                new int[] {selectedRow,selectedCol}
            };*/




            while (checkQueue.Count > 0)
            {
                int[] cell = checkQueue.ToArray()[0];
                int rowIndex = cell[0];
                int colIndex = cell[1];

                for (int i = rowIndex - 1; i < rowIndex + 2; i++)
                {
                    for (int j = colIndex - 1; j < colIndex + 2; j++)
                    {
                        if (i >= 0 && i < numRows &&
                            j >= 0 && j < numCol &&
                            minefield[i, j] == 0)
                        {
                            minefield[i, j] = -2;
                            checkQueue.Add(new int[] {i, j});
                        }

                    }
                }
                checkQueue.RemoveAt(0);
            }
            for (int i = 0; i <= numRows - 1; i++)
            {
                for (int j = 0; j <= numCol - 1; j++)
                {
                    Console.Write($"{minefield[i, j]} ");
                }
                Console.WriteLine();
                Console.Write(Environment.NewLine);

            }
        }
    }
}
