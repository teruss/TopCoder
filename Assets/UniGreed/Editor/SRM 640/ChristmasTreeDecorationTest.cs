using System;
using NUnit.Framework;

[TestFixture]
public class ChristmasTreeDecorationTest
{
	[Test]
	public void Example0()
	{
		int[] col = new int[] {
			1,
			1,
			2,
			2
		};
		int[] x = new int[] {
			1,
			2,
			3,
			4
		};
		int[] y = new int[] {
			2,
			3,
			4,
			1
		};
		int __expected = 1;
		int __result = new ChristmasTreeDecoration().solve(col, x, y);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int[] col = new int[] {
			1,
			1,
			2,
			2
		};
		int[] x = new int[] {
			1,
			2,
			3,
			4,
			1,
			2
		};
		int[] y = new int[] {
			2,
			3,
			4,
			1,
			3,
			4
		};
		int __expected = 0;
		int __result = new ChristmasTreeDecoration().solve(col, x, y);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int[] col = new int[] {
			50,
			50,
			50,
			50
		};
		int[] x = new int[] {
			1,
			2,
			3,
			1,
			1,
			2
		};
		int[] y = new int[] {
			2,
			3,
			4,
			4,
			3,
			4
		};
		int __expected = 3;
		int __result = new ChristmasTreeDecoration().solve(col, x, y);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int[] col = new int[] {
			1,
			4,
			2,
			3
		};
		int[] x = new int[] {
			1,
			2,
			3
		};
		int[] y = new int[] {
			2,
			3,
			4
		};
		int __expected = 0;
		int __result = new ChristmasTreeDecoration().solve(col, x, y);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int[] col = new int[] {
			1,
			1,
			1,
			2,
			2,
			2,
			3,
			3,
			3,
			4,
			4,
			4
		};
		int[] x = new int[] {
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9,
			10,
			11,
			12,
			1,
			1,
			1,
			1,
			1,
			1
		};
		int[] y = new int[] {
			2,
			3,
			1,
			5,
			6,
			4,
			8,
			9,
			7,
			11,
			12,
			10,
			5,
			7,
			12,
			11,
			6,
			4
		};
		int __expected = 5;
		int __result = new ChristmasTreeDecoration().solve(col, x, y);
		Assert.AreEqual(__expected, __result);
	}

}
