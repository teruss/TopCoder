using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class HexagonalBoard
{
    int[,] intBoard;
    string[] board;
    int res;

    public int minColors(string[] board)
    {
        this.board = board;
        intBoard = new int[board.Length, board [0].Length];

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                DFS(i, j, 1);
            }
        }
        return res;
    }

    void DFS(int x, int y, int c)
    {
        if (x < 0 || board.Length <= x || y < 0 || board [x].Length <= y)
            return;
        if (board [x] [y] == '-' || intBoard [x, y] != 0)
            return;

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                if (i == -1 && j == -1 || i == 1 && j == 1)
                    continue;
                int nextX = x + i;
                int nextY = y + j;
                if (nextX >= 0 && nextX < board.Length && 0 <= nextY && nextY < board [nextX].Length && intBoard [x + i, y + j] == c)
                {
                    res = 3;
                    return;
                }
            }
        }

        intBoard [x, y] = c;
        res = Math.Max(res, c);

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                if (i == -1 && j == -1 || i == 1 && j == 1)
                    continue;
                int nextX = x + i;
                int nextY = y + j;
                DFS(nextX, nextY, c == 1 ? 2 : 1);
            }
        }
    }
}
