using System;
using NUnit.Framework;

[TestFixture]
public class AutogameTest
{
	[Test]
	public void Example0()
	{
		int[] a = new int[] {
			1,
			2,
			3
		};
		int K = 5;
		int __expected = 8;
		int __result = new Autogame().wayscnt(a, K);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int[] a = new int[] {
			1,
			1,
			1
		};
		int K = 1;
		int __expected = 4;
		int __result = new Autogame().wayscnt(a, K);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int[] a = new int[] {
			2,
			1
		};
		int K = 42;
		int __expected = 4;
		int __result = new Autogame().wayscnt(a, K);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int[] a = new int[] {
			2,
			3,
			4,
			3
		};
		int K = 3;
		int __expected = 9;
		int __result = new Autogame().wayscnt(a, K);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int[] a = new int[] {
			4,
			4,
			3,
			2,
			1
		};
		int K = 3;
		int __expected = 18;
		int __result = new Autogame().wayscnt(a, K);
		Assert.AreEqual(__expected, __result);
	}

}
