using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Rotate_Image
    {
        private int[][] matrix1 ={
                                 new int[] { 1, 2, 3 }
                                ,new int[] { 4, 5, 6 }
                                ,new int[] { 7, 8, 9 }
                                };

        private int[][] matrix ={
                                 new int[] { 5,  1,  9, 11 }
                                ,new int[] { 2,  4,  8, 10 }
                                ,new int[] {13,  3,  6,  7 }
                                ,new int[] {15, 14, 12, 16 }
                                };
        public Rotate_Image()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = row; column < matrix[row].Length; column++)
                {
                    int temp = matrix[row][column];
                    matrix[row][column] = matrix[column][row];
                    matrix[column][row] = temp;
                }
            }
            Console.WriteLine("loop modified matrix-transposed");
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    Console.Write("{0}", matrix[row][column]);

                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("loop modified matrix-transposed");
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < (matrix.Length / 2); column++)
                {
                    int leftValue = matrix[row][column];
                    int rightValue = matrix[row][matrix[row].Length - 1 - column];
                    matrix[row][column] = matrix[row][matrix[row].Length - 1 - column];
                    matrix[row][matrix[row].Length - 1 - column] = leftValue;
                }
                Console.WriteLine("loop modified matrix-" + row);
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        Console.Write("{0}", matrix[i][j]);

                        Console.Write("|");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("loop modified matrix-" + row);
            }
            Console.WriteLine("loop modified matrix");
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    Console.Write("{0}", matrix[row][column]);

                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("loop modified matrix");
        }

        public int[][] Rotate_Image_Function()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = row; column < matrix[row].Length; column++)
                {
                    int temp = matrix[row][column];
                    matrix[row][column] = matrix[column][row];
                    matrix[column][row] = temp;
                }
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < (matrix.Length / 2); column++)
                {
                    int leftValue = matrix[row][column];
                    matrix[row][column] = matrix[row][matrix[row].Length - 1 - column];
                    matrix[row][matrix[row].Length - 1 - column] = leftValue;
                }
            }
            return matrix;
        }
    }
}
