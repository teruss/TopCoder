using System;
using NUnit.Framework;

[TestFixture]
public class AstronomicalRecordsTest
{
	[Test]
	public void Example0()
	{
		int[] A = new int[] {
			1,
			2,
			1,
			2,
			1
		};
		int[] B = new int[] {
			2,
			1,
			2,
			1,
			2
		};
		int __expected = 6;
		int __result = new AstronomicalRecords().minimalPlanets(A, B);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int[] A = new int[] {
			1,
			2,
			3,
			4
		};
		int[] B = new int[] {
			2,
			4,
			6,
			8
		};
		int __expected = 4;
		int __result = new AstronomicalRecords().minimalPlanets(A, B);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int[] A = new int[] {
			2,
			3,
			2,
			3,
			2,
			3,
			2
		};
		int[] B = new int[] {
			600,
			700,
			600,
			700,
			600,
			700,
			600
		};
		int __expected = 10;
		int __result = new AstronomicalRecords().minimalPlanets(A, B);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int[] A = new int[] {
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9
		};
		int[] B = new int[] {
			6,
			7,
			8,
			9,
			10,
			11,
			12
		};
		int __expected = 12;
		int __result = new AstronomicalRecords().minimalPlanets(A, B);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int[] A = new int[] {
			100000000,
			200000000
		};
		int[] B = new int[] {
			200000000,
			100000000
		};
		int __expected = 3;
		int __result = new AstronomicalRecords().minimalPlanets(A, B);
		Assert.AreEqual(__expected, __result);
	}

}
