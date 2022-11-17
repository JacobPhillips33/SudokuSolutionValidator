using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolutionValidator
{
    public class Methods
    {
        public static bool ValidateSolution(int[][] board)
        {
            #region Checks to make sure all of the rows are valid solutions
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (!board[i].Contains(j))
                    {
                        return false;
                    }
                }
            }
            #endregion

            #region Checks to make sure all of the columns are valid solutions
            int sum = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[j][i] != 1 && board[j][i] != 2 && board[j][i] != 3 && board[j][i] != 4 && board[j][i] != 5 &&
                        board[j][i] != 6 && board[j][i] != 7 && board[j][i] != 8 && board[j][i] != 9)
                    {
                        return false;
                    }

                    sum += board[j][i];
                }

                if (sum != 45)
                {
                    return false;
                }
                sum = 0;
            }
            #endregion

            #region Checks to make sure each 3x3 block is a valid solution
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;
            int[][] block1 = new int[9][];
            block1[0] = new int[3];
            block1[1] = new int[3];
            block1[2] = new int[3];
            block1[3] = new int[3];
            block1[4] = new int[3];
            block1[5] = new int[3];
            block1[6] = new int[3];
            block1[7] = new int[3];
            block1[8] = new int[3];

            while (k < 9)
            {
                for (int i = k; i < k + 3; i++)
                {
                    for (int j = l; j < l + 3; j++)
                    {
                        block1[m][n] = board[i][j];
                        n++;
                    }
                    m++;
                    n = 0;
                }
                if (block1[k].Sum() + block1[k + 1].Sum() + block1[k + 2].Sum() != 45)
                {
                    return false;
                }
                if (k < 9)
                {
                    k += 3;
                }
            }

            k = 0;
            l = 3;
            m = 0;
            n = 0;
            int[][] block2 = new int[9][];
            block2[0] = new int[3];
            block2[1] = new int[3];
            block2[2] = new int[3];
            block2[3] = new int[3];
            block2[4] = new int[3];
            block2[5] = new int[3];
            block2[6] = new int[3];
            block2[7] = new int[3];
            block2[8] = new int[3];

            while (k < 9)
            {
                for (int i = k; i < k + 3; i++)
                {
                    for (int j = l; j < l + 3; j++)
                    {
                        block2[m][n] = board[i][j];
                        n++;
                    }
                    m++;
                    n = 0;
                }
                if (block2[k].Sum() + block2[k + 1].Sum() + block2[k + 2].Sum() != 45)
                {
                    return false;
                }
                if (k < 9)
                {
                    k += 3;
                }
            }

            k = 0;
            l = 6;
            m = 0;
            n = 0;
            int[][] block3 = new int[9][];
            block3[0] = new int[3];
            block3[1] = new int[3];
            block3[2] = new int[3];
            block3[3] = new int[3];
            block3[4] = new int[3];
            block3[5] = new int[3];
            block3[6] = new int[3];
            block3[7] = new int[3];
            block3[8] = new int[3];

            while (k < 9)
            {
                for (int i = k; i < k + 3; i++)
                {
                    for (int j = l; j < l + 3; j++)
                    {
                        block3[m][n] = board[i][j];
                        n++;
                    }
                    m++;
                    n = 0;
                }
                if (block3[k].Sum() + block3[k + 1].Sum() + block3[k + 2].Sum() != 45)
                {
                    return false;
                }
                if (k < 9)
                {
                    k += 3;
                }
            }
            #endregion

            return true;
        }
    }
}
