using System;
using NUnit.Framework;

[TestFixture]
public class HyperKnightTest
{
	[Test]
	public void Example0()
	{
		int a = 2;
		int b = 1;
		int numRows = 8;
		int numColumns = 8;
		int k = 4;
		long __expected = 20L;
		long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int a = 3;
		int b = 2;
		int numRows = 8;
		int numColumns = 8;
		int k = 2;
		long __expected = 16L;
		long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int a = 1;
		int b = 3;
		int numRows = 7;
		int numColumns = 11;
		int k = 0;
		long __expected = 0L;
		long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int a = 3;
		int b = 2;
		int numRows = 10;
		int numColumns = 20;
		int k = 8;
		long __expected = 56L;
		long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int a = 1;
		int b = 4;
		int numRows = 100;
		int numColumns = 10;
		int k = 6;
		long __expected = 564L;
		long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example5()
	{
		int a = 2;
		int b = 3;
		int numRows = 1000000000;
		int numColumns = 1000000000;
		int k = 8;
		long __expected = 999999988000000036L;
		long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example8()
	{
		int a = 2;
		int b = 3;
		int numRows = 7;
		int numColumns = 7;
		int k = 3;
		long __expected = 16L;
		long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
		Assert.AreEqual(__expected, __result);
	}
	
	[Test]
	public void Example9()
	{
		int a = 2;
		int b = 3;
		int numRows = 7;
		int numColumns = 7;
		int k = 4;
		long __expected = 12L;
		long __result = new HyperKnight().countCells(a, b, numRows, numColumns, k);
		Assert.AreEqual(__expected, __result);
	}
	
}
