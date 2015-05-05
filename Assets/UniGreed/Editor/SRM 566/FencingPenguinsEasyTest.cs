using System;
using NUnit.Framework;

[TestFixture]
public class FencingPenguinsEasyTest
{
	class TcDoubleEqualityComparer : System.Collections.Generic.IEqualityComparer<double>
	{
		public bool Equals(double x, double y)
		{
			double eps = 1e-9;
			return
				!double.IsNaN(x) && !double.IsNaN(y)
				&& Math.Abs(x - y) <= eps*Math.Max(1.0, Math.Min(Math.Abs(x), Math.Abs(y)));
		}

		public int GetHashCode(double obj)
		{
			// Not relevant
			throw new NotImplementedException();
		}
	}

	private static void AssertTcEqualTo<T>(T expected, T actual)
	{
		Assert.That(actual, Is.EqualTo(expected).Using(new TcDoubleEqualityComparer()));
	}

	[Test]
	public void Example0()
	{
		int numPosts = 3;
		int radius = 5;
		int[] x = new int[] {
			-1
		};
		int[] y = new int[] {
			0
		};
		double __expected = 32.47595264191645;
		double __result = new FencingPenguinsEasy().calculateMinArea(numPosts, radius, x, y);
		AssertTcEqualTo(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int numPosts = 30;
		int radius = 5;
		int[] x = new int[] {
			6
		};
		int[] y = new int[] {
			0
		};
		double __expected = -1.0;
		double __result = new FencingPenguinsEasy().calculateMinArea(numPosts, radius, x, y);
		AssertTcEqualTo(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int numPosts = 4;
		int radius = 5;
		int[] x = new int[] {
			2
		};
		int[] y = new int[] {
			1
		};
		double __expected = 25.0;
		double __result = new FencingPenguinsEasy().calculateMinArea(numPosts, radius, x, y);
		AssertTcEqualTo(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int numPosts = 4;
		int radius = 5;
		int[] x = new int[] {
			2,
			-2
		};
		int[] y = new int[] {
			1,
			-1
		};
		double __expected = 50.0;
		double __result = new FencingPenguinsEasy().calculateMinArea(numPosts, radius, x, y);
		AssertTcEqualTo(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int numPosts = 8;
		int radius = 5;
		int[] x = new int[] {
			8
		};
		int[] y = new int[] {
			8
		};
		double __expected = -1.0;
		double __result = new FencingPenguinsEasy().calculateMinArea(numPosts, radius, x, y);
		AssertTcEqualTo(__expected, __result);
	}

	[Test]
	public void Example5()
	{
		int numPosts = 7;
		int radius = 10;
		int[] x = new int[] {
			9
		};
		int[] y = new int[] {
			1
		};
		double __expected = 29.436752637711805;
		double __result = new FencingPenguinsEasy().calculateMinArea(numPosts, radius, x, y);
		AssertTcEqualTo(__expected, __result);
	}

	[Test]
	public void Example6()
	{
		int numPosts = 30;
		int radius = 800;
		int[] x = new int[] {
			8,
			2,
			100,
			120,
			52,
			67,
			19,
			-36
		};
		int[] y = new int[] {
			-19,
			12,
			88,
			-22,
			53,
			66,
			-140,
			99
		};
		double __expected = 384778.74757953023;
		double __result = new FencingPenguinsEasy().calculateMinArea(numPosts, radius, x, y);
		AssertTcEqualTo(__expected, __result);
	}

}
