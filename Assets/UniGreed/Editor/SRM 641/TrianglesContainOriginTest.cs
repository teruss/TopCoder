using System;
using NUnit.Framework;

[TestFixture]
public class TrianglesContainOriginTest
{
	[Test]
	public void Example0()
	{
		int[] x = new int[] {
			-1,
			-1,
			1
		};
		int[] y = new int[] {
			1,
			-1,
			0
		};
		long __expected = 1L;
		long __result = new TrianglesContainOrigin().count(x, y);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int[] x = new int[] {
			-1,
			-1,
			1,
			2
		};
		int[] y = new int[] {
			1,
			-1,
			2,
			-1
		};
		long __expected = 2L;
		long __result = new TrianglesContainOrigin().count(x, y);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int[] x = new int[] {
			-1,
			-2,
			3,
			3,
			2,
			1
		};
		int[] y = new int[] {
			-2,
			-1,
			1,
			2,
			3,
			3
		};
		long __expected = 8L;
		long __result = new TrianglesContainOrigin().count(x, y);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int[] x = new int[] {
			1,
			5,
			10,
			5,
			-5,
			7,
			-9,
			-6,
			-3,
			0,
			8,
			8,
			1,
			-4,
			7,
			-3,
			10,
			9,
			-6
		};
		int[] y = new int[] {
			5,
			-6,
			-3,
			4,
			-2,
			-8,
			-7,
			2,
			7,
			4,
			2,
			0,
			-4,
			-8,
			7,
			5,
			-5,
			-2,
			-9
		};
		long __expected = 256L;
		long __result = new TrianglesContainOrigin().count(x, y);
		Assert.AreEqual(__expected, __result);
	}

}
