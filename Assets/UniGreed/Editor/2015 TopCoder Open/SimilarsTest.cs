using System;
using NUnit.Framework;

[TestFixture]
public class SimilarsTest
{
	[Test]
	public void Example0()
	{
		int L = 1;
		int R = 10;
		int __expected = 1;
		int __result = new Similars().maxsim(L, R);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int L = 1;
		int R = 99;
		int __expected = 2;
		int __result = new Similars().maxsim(L, R);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int L = 99;
		int R = 100;
		int __expected = 0;
		int __result = new Similars().maxsim(L, R);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int L = 1000;
		int R = 1010;
		int __expected = 2;
		int __result = new Similars().maxsim(L, R);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int L = 444;
		int R = 454;
		int __expected = 2;
		int __result = new Similars().maxsim(L, R);
		Assert.AreEqual(__expected, __result);
	}

}
