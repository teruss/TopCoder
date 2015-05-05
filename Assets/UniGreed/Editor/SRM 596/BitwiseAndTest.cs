using System;
using NUnit.Framework;

[TestFixture]
public class BitwiseAndTest
{
	[Test]
	public void Example0()
	{
		long[] subset = new long[] {
			14L,
			20L
		};
		int N = 3;
		long[] __expected = new long[] {
			14L,
			18L,
			20L
		};
		long[] __result = new BitwiseAnd().lexSmallest(subset, N);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		long[] subset = new long[] {
			11L,
			17L,
			20L
		};
		int N = 4;
		long[] __expected = new long[] {
		};
		long[] __result = new BitwiseAnd().lexSmallest(subset, N);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		long[] subset = new long[] {
			99L,
			157L
		};
		int N = 4;
		long[] __expected = new long[] {
			99L,
			157L,
			262L,
			296L
		};
		long[] __result = new BitwiseAnd().lexSmallest(subset, N);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		long[] subset = new long[] {
			1152921504606846975L
		};
		int N = 3;
		long[] __expected = new long[] {
		};
		long[] __result = new BitwiseAnd().lexSmallest(subset, N);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		long[] subset = new long[] {
		};
		int N = 5;
		long[] __expected = new long[] {
			15L,
			113L,
			402L,
			676L,
			840L
		};
		long[] __result = new BitwiseAnd().lexSmallest(subset, N);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example5()
	{
		long[] subset = new long[] {
			1L,
			3L,
			5L,
			7L,
			9L,
			11L
		};
		int N = 6;
		long[] __expected = new long[] {
		};
		long[] __result = new BitwiseAnd().lexSmallest(subset, N);
		Assert.AreEqual(__expected, __result);
	}

}
