using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class ValidSudoku
    {
        private char[][] board;
        private char[][] board1 ={
                                 new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' }
                                ,new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' }
                                ,new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' }
                                ,new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' }
                                ,new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' }
                                ,new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' }
                                ,new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' }
                                ,new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' }
                                ,new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                                };
        private char[][] board2 ={
                                 new char[]{'8','3','.','.','7','.','.','.','.'}
                                ,new char[]{'6','.','.','1','9','5','.','.','.'}
                                ,new char[]{'.','9','8','.','.','.','.','6','.'}
                                ,new char[]{'8','.','.','.','6','.','.','.','3'}
                                ,new char[]{'4','.','.','8','.','3','.','.','1'}
                                ,new char[]{'7','.','.','.','2','.','.','.','6'}
                                ,new char[]{'.','6','.','.','.','.','2','8','.'}
                                ,new char[]{'.','.','.','4','1','9','.','.','5'}
                                ,new char[]{'.','.','.','.','8','.','.','7','9'}
                                };
        public ValidSudoku()
        {
            Console.WriteLine();
            Console.WriteLine();
            this.board = board2;
            int N = 9;
            HashSet<char>[] rows = new HashSet<char>[N];
            HashSet<char>[] columns = new HashSet<char>[N];
            HashSet<char>[] boxes = new HashSet<char>[N];
            for (int i = 0; i < N; i++)
            {
                rows[i] = new HashSet<char>();
                columns[i] = new HashSet<char>();
                boxes[i] = new HashSet<char>();
            }
            for (int row = 0; row < N; row++)
            {
                for (int column = 0; column < N; column++)
                {
                    char val = board[row][column];
                    if (val == '.')
                    {
                        continue;
                    }

                    #region rows
                    if (rows[row].Contains(val))
                    {
                        Console.WriteLine("FALSE VALUE ON ROW NO." + row);
                    }
                    rows[row].Add(val);
                    #endregion rows


                    #region columns
                    if (columns[column].Contains(val))
                    {
                        Console.WriteLine("FALSE VALUE ON COLUMN NO." + column);
                    }
                    columns[column].Add(val);
                    #endregion columns


                    #region boxes
                    int boxPosition = (row / 3) * 3 + (column / 3);
                    if (boxes[boxPosition].Contains(val))
                    {
                        Console.WriteLine("FALSE VALUE ON BOX NO." + boxPosition);
                    }
                    boxes[boxPosition].Add(val);
                    #endregion boxes
                }
            }
            // Time-COMPLEXITY:O(N2)
            // SPACE-COMPLEXITY:O(N2)
        }
        private bool ValudSudokuFunction()
        {
            this.board = board2;
            int N = 9;
            HashSet<char>[] rows = new HashSet<char>[N];
            HashSet<char>[] columns = new HashSet<char>[N];
            HashSet<char>[] boxes = new HashSet<char>[N];
            for (int i = 0; i < N; i++)
            {
                rows[i] = new HashSet<char>();
                columns[i] = new HashSet<char>();
                boxes[i] = new HashSet<char>();
            }
            for (int row = 0; row < N; row++)
            {
                for (int column = 0; column < N; column++)
                {
                    char val = board[row][column];
                    if (val == '.')
                    {
                        continue;
                    }

                    #region rows
                    if (rows[row].Contains(val))
                    {
                        return false;
                    }
                    rows[row].Add(val);
                    #endregion rows


                    #region columns
                    if (columns[column].Contains(val))
                    {
                        return false;
                    }
                    columns[column].Add(val);
                    #endregion columns


                    #region boxes
                    int boxPosition = (row / 3) * 3 + (column / 3);
                    if (boxes[boxPosition].Contains(val))
                    {
                        return false;
                    }
                    boxes[boxPosition].Add(val);
                    #endregion boxes
                }
            }
            return true;
            // Time-COMPLEXITY:O(N2)
            // SPACE-COMPLEXITY:O(N2)
        }
    }
}
