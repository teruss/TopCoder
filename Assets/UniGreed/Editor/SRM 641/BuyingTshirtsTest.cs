using System;
using NUnit.Framework;

[TestFixture]
public class BuyingTshirtsTest
{
	[Test]
	public void Example0()
	{
		int T = 5;
		int[] Q = new int[] {
			1,
			2,
			3,
			4,
			5
		};
		int[] P = new int[] {
			5,
			4,
			3,
			2,
			1
		};
		int __expected = 2;
		int __result = new BuyingTshirts().meet(T, Q, P);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int T = 10;
		int[] Q = new int[] {
			10,
			10,
			10
		};
		int[] P = new int[] {
			10,
			10,
			10
		};
		int __expected = 3;
		int __result = new BuyingTshirts().meet(T, Q, P);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int T = 2;
		int[] Q = new int[] {
			1,
			2,
			1,
			2,
			1,
			2,
			1,
			2
		};
		int[] P = new int[] {
			1,
			1,
			1,
			1,
			2,
			2,
			2,
			2
		};
		int __expected = 5;
		int __result = new BuyingTshirts().meet(T, Q, P);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int T = 100;
		int[] Q = new int[] {
			1,
			2,
			3
		};
		int[] P = new int[] {
			4,
			5,
			6
		};
		int __expected = 0;
		int __result = new BuyingTshirts().meet(T, Q, P);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int T = 10;
		int[] Q = new int[] {
			10,
			1,
			10,
			1
		};
		int[] P = new int[] {
			1,
			10,
			1,
			10
		};
		int __expected = 0;
		int __result = new BuyingTshirts().meet(T, Q, P);
		Assert.AreEqual(__expected, __result);
	}

}
