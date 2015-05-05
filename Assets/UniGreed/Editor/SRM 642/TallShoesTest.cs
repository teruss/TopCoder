using System;
using NUnit.Framework;

[TestFixture]
public class TallShoesTest
{
	[Test]
	public void Example0()
	{
		int N = 3;
		int[] X = new int[] {
			0,
			1,
			0
		};
		int[] Y = new int[] {
			1,
			2,
			2
		};
		int[] height = new int[] {
			3,
			4,
			2
		};
		long B = 1L;
		int __expected = 4;
		int __result = new TallShoes().maxHeight(N, X, Y, height, B);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int N = 3;
		int[] X = new int[] {
			0,
			1,
			0
		};
		int[] Y = new int[] {
			1,
			2,
			2
		};
		int[] height = new int[] {
			3,
			4,
			2
		};
		long B = 52L;
		int __expected = 9;
		int __result = new TallShoes().maxHeight(N, X, Y, height, B);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int N = 8;
		int[] X = new int[] {
			0,
			0,
			3,
			3,
			4,
			4,
			4,
			7,
			7
		};
		int[] Y = new int[] {
			1,
			2,
			1,
			2,
			3,
			5,
			6,
			5,
			6
		};
		int[] height = new int[] {
			1000,
			1000,
			1000,
			1000,
			1,
			1000,
			1000,
			1000,
			1000
		};
		long B = 3L;
		int __expected = 2;
		int __result = new TallShoes().maxHeight(N, X, Y, height, B);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int N = 10;
		int[] X = new int[] {
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8
		};
		int[] Y = new int[] {
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9
		};
		int[] height = new int[] {
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0
		};
		long B = 9876543210123L;
		int __expected = 1047565;
		int __result = new TallShoes().maxHeight(N, X, Y, height, B);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int N = 6;
		int[] X = new int[] {
			0,
			0,
			0,
			0,
			0,
			1,
			1,
			1,
			1,
			2,
			2,
			2,
			3,
			3,
			4
		};
		int[] Y = new int[] {
			1,
			2,
			3,
			4,
			5,
			2,
			3,
			4,
			5,
			3,
			4,
			5,
			4,
			5,
			5
		};
		int[] height = new int[] {
			999999,
			986588,
			976757,
			988569,
			977678,
			999999,
			967675,
			947856,
			955856,
			999999,
			975956,
			956687,
			999999,
			979687,
			999999
		};
		long B = 0L;
		int __expected = 999999;
		int __result = new TallShoes().maxHeight(N, X, Y, height, B);
		Assert.AreEqual(__expected, __result);
	}

}
