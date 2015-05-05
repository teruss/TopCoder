using System;
using NUnit.Framework;

[TestFixture]
public class EllysLampsTest
{
	[Test]
	public void Example0()
	{
		string lamps = "YNNYN";
		int __expected = 2;
		int __result = new EllysLamps().getMin(lamps);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		string lamps = "NNN";
		int __expected = 0;
		int __result = new EllysLamps().getMin(lamps);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		string lamps = "YY";
		int __expected = 0;
		int __result = new EllysLamps().getMin(lamps);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		string lamps = "YNYYYNNNY";
		int __expected = 3;
		int __result = new EllysLamps().getMin(lamps);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		string lamps = "YNYYYYNYNNYYNNNNNNYNYNYNYNNYNYYYNY";
		int __expected = 13;
		int __result = new EllysLamps().getMin(lamps);
		Assert.AreEqual(__expected, __result);
	}

}
