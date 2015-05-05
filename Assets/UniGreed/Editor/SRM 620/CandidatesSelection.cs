using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class CandidatesSelection
{
	public string possible(string[] score, int[] result)
	{
		var conds = result.Zip(result.Skip(1), (first, second) => new []{first, second}).ToList();
		int m = score [0].Length;

		var used = new bool[m];
		while (conds.Count > 0) {
			if (conds.All(cond => cond [0] < cond [1]))
				break;
			bool removed = false;
			for (int i = 0; i < m; i++) {
				if (!used [i]) {
					if (conds.All(x => score [x [0]] [i] <= score [x [1]] [i])) {
						removed = true;
						used [i] = true;
						conds = conds.Where(x => score [x [0]] [i] == score [x [1]] [i]).ToList();
					}
				}
			}
			if (!removed)
				return "Impossible";
		}
		return "Possible";
	}

}
