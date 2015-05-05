using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class BoardFolding
{
    public int howMany(int N, int M, string[] compressedPaper)
    {
        var paper0 = compressedPaper.Select(line => line.SelectMany(c => Enumerable.Range(0, 6).Select(j => (ToNumber(c) >> j) % 2)).Take(M).ToArray()).ToArray();
        var inverted = Enumerable.Range(0, M).Select(index => paper0.Select(line => line.Where((elem, i) => i == index).Single()).ToArray()).ToArray();

        var paperX = new[] {paper0, inverted};

        return paperX.Aggregate(1, (accX, paper) => {
            int n = paper.Count();
            var same = paper.Select(line => new bool[n]).ToArray();
            for (int y1=0; y1<n; y1++)
            {
                for (int y2 =y1+1; y2<n; y2++)
                {
                    same [y1] [y2] = paper [y1].SequenceEqual(paper [y2]);
                }
            }

            var ok = paper.Select(line => new bool[n]).ToArray();
            ok [0] [n - 1] = true;

            int num = 1;
            for (int h = n - 1; h >= 1; h--)
            {
                for (int y1 = 0; y1 < n; y1++)
                {
                    var y2 = y1 + h - 1;
                    if (y2 >= n)
                        continue;
                    ok [y1] [y2] = false;
                    for (int y = y1 - 1; y >= 0 && !ok[y1][y2]; y--)
                    {
                        if (y1 - y > y2 - y1 + 1)
                            break;
                        if (!same [y] [y1 + (y1 - y - 1)])
                            break;
                        ok [y1] [y2] |= ok [y] [y2];
                    }
                    for (int y = y2+1; y<n && !ok[y1][y2]; y++)
                    {
                        if (y - y2 > y2 - y1 + 1)
                            break;
                        if (!same [y2 - (y - y2 - 1)] [y])
                            break;
                        ok [y1] [y2] |= ok [y1] [y];
                    }
                    num += (ok [y1] [y2] ? 1 : 0);
                }
            }

            return accX * num;
        });
    }

    int ToNumber(char c)
    {
        if ('0' <= c && c <= '9')
            return c - '0';
        if ('a' <= c && c <= 'z')
            return c - 'a' + 10;
        if ('A' <= c && c <= 'Z')
            return c - 'A' + 36;
        if ('#' == c)
            return 62;
        if ('@' == c)
            return 63;
//        throw new Exception();
        return -1;
    }
}
