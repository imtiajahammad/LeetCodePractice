using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Transpose_Matrix
    {
        private int[][] matrix1 ={
                                 new int[] { 1, 2, 3 }
                                ,new int[] { 4, 5, 6 }
                                ,new int[] { 7, 8, 9 }
                                };
        private int[][] matrix ={
                                 new int[] { 1, 2, 3 }
                                ,new int[] { 4, 5, 6 }
                                };

        public Transpose_Matrix()
        {
            int toBeColumns = matrix.Length;
            int toBeRows = matrix[0].Length;
            int[][] transpose = new int[toBeRows][];
            for (int i = 0; i < toBeRows; i++) //this loop is because i cant just declare int [][] transpose = new int[m][n] ... c# things
            {
                transpose[i] = new int[toBeColumns];
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    Console.WriteLine("row is {0} and column in {1}", row, column);
                    int temp = matrix[row][column];
                    Console.WriteLine("matrix[{0}][{1}] is  [2]", row, column, matrix[row][column]);
                    transpose[column][row] = matrix[row][column];
                    Console.WriteLine();


                    Console.WriteLine("loop transpose");
                    for (int i = 0; i < transpose.Length; i++)
                    {
                        for (int j = 0; j < transpose[i].Length; j++)
                        {
                            Console.Write("{0}", transpose[i][j]);

                            Console.Write("|");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("loop transpose");

                }
                Console.WriteLine("---");

            }
            Console.WriteLine("loop matrix");
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    Console.Write("{0}", matrix[row][column]);

                    Console.Write("|");
                }
                Console.WriteLine("---");
            }
            Console.WriteLine("loop matrix");
        }

        public int[][] Transpose_Matrix_Function()
        {
            int toBeColumns = matrix.Length;
            int toBeRows = matrix[0].Length;
            int[][] transpose = new int[toBeRows][];
            for (int i = 0; i < toBeRows; i++) //this loop is because i cant just declare int [][] transpose = new int[m][n] ... c# things
            {
                transpose[i] = new int[toBeColumns];
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    transpose[column][row] = matrix[row][column];
                }
            }
            return transpose;
        }
    }
}
