using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class ShufflingCardsDiv2
{
    public string shuffle(int[] permutation)
    {
        return permutation.Where((elem, index) => index % 2 == 0).Count(v => v <= permutation.Length / 2) == (permutation.Length / 2 + 1) / 2 ? "Possible" : "Impossible";
    }
}
