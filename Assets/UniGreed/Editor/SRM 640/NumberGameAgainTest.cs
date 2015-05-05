using System;
using NUnit.Framework;

[TestFixture]
public class NumberGameAgainTest
{
	[Test]
	public void Example0()
	{
		int k = 3;
		long[] table = new long[] {
			2L,
			4L,
			6L
		};
		long __expected = 2L;
		long __result = new NumberGameAgain().solve(k, table);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int k = 5;
		long[] table = new long[] {
			2L,
			3L
		};
		long __expected = 0L;
		long __result = new NumberGameAgain().solve(k, table);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int k = 5;
		long[] table = new long[] {
		};
		long __expected = 30L;
		long __result = new NumberGameAgain().solve(k, table);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int k = 40;
		long[] table = new long[] {
			2L,
			4L,
			8L,
			16L,
			32141531L,
			2324577L,
			1099511627775L,
			2222222222L,
			33333333333L,
			4444444444L,
			2135L
		};
		long __expected = 549755748288L;
		long __result = new NumberGameAgain().solve(k, table);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int k = 40;
		long[] table = new long[] {
		};
		long __expected = 1099511627774L;
		long __result = new NumberGameAgain().solve(k, table);
		Assert.AreEqual(__expected, __result);
	}

}
