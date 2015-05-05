using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class ChocolateDividingEasy
{
    public int findBest(string[] chocolate)
    {
        int res = 0;
        int n = chocolate.Length, m = chocolate [0].Length;

        var solver = new Solver(chocolate);
        for (int i = 1; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = 1; k < m; k++)
                {
                    for (int l = k + 1; l < m; l++)
                    {
                        res = Math.Max(res, new int[]
                        {
                            solver.Calc(0, i, 0, k),
                            solver.Calc(0, i, k, l),
                            solver.Calc(0, i, l, m),
                            solver.Calc(i, j, 0, k),
                            solver.Calc(i, j, k, l),
                            solver.Calc(i, j, l, m),
                            solver.Calc(j, n, 0, k),
                            solver.Calc(j, n, k, l),
                            solver.Calc(j, n, l, m),
                        }.Min());
                    }
                }
            }
        }
        return res;
    }

    class Solver
    {
        int[,] sum;

        public Solver(string[] chocolate)
        {
            var sumC = new int[chocolate.Length, chocolate [0].Length + 1];
            for (int r = 0; r < chocolate.Length; r++)
            {
                for (int c = 0; c < chocolate[0].Length; c++)
                {
                    sumC [r, c + 1] = sumC [r, c] + chocolate [r] [c] - '0';
                }
            }
            sum = new int[chocolate.Length + 1, chocolate [0].Length + 1];
            for (int r = 0; r < chocolate.Length; r++)
            {
                for (int c = 0; c <= chocolate[0].Length; c++)
                {
                    sum [r + 1, c] = sum [r, c] + sumC [r, c];
                }
            }
        }

        public int Calc(int rb, int re, int cb, int ce)
        {
            return sum [re, ce] - sum [re, cb] - sum [rb, ce] + sum [rb, cb];
        }
    }
}
