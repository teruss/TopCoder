using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class HyperKnight
{
	public long countCells(int a, int b, int numRows, int numColumns, int k)
	{
		if (a < b)
			return countCells(b, a, numRows, numColumns, k);
		if (k == 2) {
			return 4L * b * b;
		}
		if (k == 3)
			return 8L * (a - b) * b;
		if (k == 4)
			return 2L * b * (numColumns - a * 2L) + 2L * b * (numRows - a * 2L) + 4L * (a - b) * (a - b);
		if (k == 6)
			return 2L * (a - b) * (numRows - a * 2) + 2L * (a - b) * (numColumns - a * 2);
		if (k == 8)
			return (numColumns - a * 2L) * (numRows - a * 2L);
		return 0;
	}

}
