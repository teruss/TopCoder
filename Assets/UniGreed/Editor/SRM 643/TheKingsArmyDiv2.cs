using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class TheKingsArmyDiv2
{
    public int getNumber(string[] state)
    {
        if (state.SequenceEqual(Enumerable.Repeat(new string('S', state [0].Length), state.Length)))
            return 2;

        for (int i = 0; i < state.Length-1; i++)
        {
            for (int k = 0; k < state[0].Length; k++)
            {
                if (state [i] [k] == 'H' && state [i + 1] [k] == 'H')
                {
                    return 0;
                }
            }
        }

        foreach (var s in state)
        {
            if (s.Contains("HH"))
            {
                return 0;
            }
        }

        return 1;
    }

}
