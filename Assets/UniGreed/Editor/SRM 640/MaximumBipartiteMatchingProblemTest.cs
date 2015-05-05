using System;
using NUnit.Framework;

[TestFixture]
public class MaximumBipartiteMatchingProblemTest
{
	[Test]
	public void Example0()
	{
		int n1 = 3;
		int n2 = 3;
		int ans = 2;
		int d = 1;
		long __expected = 5L;
		long __result = new MaximumBipartiteMatchingProblem().solve(n1, n2, ans, d);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int n1 = 3;
		int n2 = 3;
		int ans = 1;
		int d = 1;
		long __expected = -1L;
		long __result = new MaximumBipartiteMatchingProblem().solve(n1, n2, ans, d);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int n1 = 5;
		int n2 = 10;
		int ans = 5;
		int d = 2;
		long __expected = 50L;
		long __result = new MaximumBipartiteMatchingProblem().solve(n1, n2, ans, d);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int n1 = 100000000;
		int n2 = 87654321;
		int ans = 12345678;
		int d = 54321;
		long __expected = 1233229491567444L;
		long __result = new MaximumBipartiteMatchingProblem().solve(n1, n2, ans, d);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int n1 = 1000000000;
		int n2 = 1000000000;
		int ans = 1000000000;
		int d = 1000000000;
		long __expected = 1000000000000000000L;
		long __result = new MaximumBipartiteMatchingProblem().solve(n1, n2, ans, d);
		Assert.AreEqual(__expected, __result);
	}

}
