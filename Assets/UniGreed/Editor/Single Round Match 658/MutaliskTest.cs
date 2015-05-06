using System;
using NUnit.Framework;

[TestFixture]
public class MutaliskTest
{
	[Test]
	public void Example0()
	{
		int[] x = new int[] {
			12,
			10,
			4
		};
		int __expected = 2;
		int __result = new Mutalisk().minimalAttacks(x);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int[] x = new int[] {
			54,
			18,
			6
		};
		int __expected = 6;
		int __result = new Mutalisk().minimalAttacks(x);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int[] x = new int[] {
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1
		};
		int __expected = 4;
		int __result = new Mutalisk().minimalAttacks(x);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int[] x = new int[] {
			55,
			60,
			53
		};
		int __expected = 13;
		int __result = new Mutalisk().minimalAttacks(x);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int[] x = new int[] {
			60
		};
		int __expected = 7;
		int __result = new Mutalisk().minimalAttacks(x);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example5()
	{
		int[] x = new int[] {
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60,
			60
		};
		int __expected = 93;
		int __result = new Mutalisk().minimalAttacks(x);
		Assert.AreEqual(__expected, __result);
	}

}
