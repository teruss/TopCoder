using System;
using NUnit.Framework;

[TestFixture]
public class TheKingsFactorizationTest
{
	[Test]
	public void Example0()
	{
		long N = 12L;
		long[] primes = new long[] {
			2L,
			3L
		};
		long[] __expected = new long[] {
			2L,
			2L,
			3L
		};
		long[] __result = new TheKingsFactorization().getVector(N, primes);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		long N = 7L;
		long[] primes = new long[] {
			7L
		};
		long[] __expected = new long[] {
			7L
		};
		long[] __result = new TheKingsFactorization().getVector(N, primes);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		long N = 1764L;
		long[] primes = new long[] {
			2L,
			3L,
			7L
		};
		long[] __expected = new long[] {
			2L,
			2L,
			3L,
			3L,
			7L,
			7L
		};
		long[] __result = new TheKingsFactorization().getVector(N, primes);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		long N = 49L;
		long[] primes = new long[] {
			7L
		};
		long[] __expected = new long[] {
			7L,
			7L
		};
		long[] __result = new TheKingsFactorization().getVector(N, primes);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		long N = 210L;
		long[] primes = new long[] {
			2L,
			5L
		};
		long[] __expected = new long[] {
			2L,
			3L,
			5L,
			7L
		};
		long[] __result = new TheKingsFactorization().getVector(N, primes);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example5()
	{
		long N = 100000L;
		long[] primes = new long[] {
			2L,
			2L,
			2L,
			5L,
			5L
		};
		long[] __expected = new long[] {
			2L,
			2L,
			2L,
			2L,
			2L,
			5L,
			5L,
			5L,
			5L,
			5L
		};
		long[] __result = new TheKingsFactorization().getVector(N, primes);
		Assert.AreEqual(__expected, __result);
	}
	
	[Test, Timeout(2000)]
	public void TestCase66()
	{
		long N = 999999999999999862L;
		long[] primes = new long[] {
			2L
		};
		long[] __expected = new long[] {
			2L,
			499999999999999931L
		};
		long[] __result = new TheKingsFactorization().getVector(N, primes);
		Assert.AreEqual(__expected, __result);
	}
	
}
