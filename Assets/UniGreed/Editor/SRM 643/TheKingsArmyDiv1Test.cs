using System;
using NUnit.Framework;

[TestFixture]
public class TheKingsArmyDiv1Test
{
	[Test]
	public void Example0()
	{
		string[] state = new string[] {
			"HSH",
			"SHS"
		};
		int __expected = 2;
		int __result = new TheKingsArmyDiv1().getNumber(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		string[] state = new string[] {
			"HH",
			"HH"
		};
		int __expected = 0;
		int __result = new TheKingsArmyDiv1().getNumber(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		string[] state = new string[] {
			"HHHHH",
			"HSHSH"
		};
		int __expected = 1;
		int __result = new TheKingsArmyDiv1().getNumber(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		string[] state = new string[] {
			"S",
			"S"
		};
		int __expected = -1;
		int __result = new TheKingsArmyDiv1().getNumber(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		string[] state = new string[] {
			"HSHHSHSHSHHHSHSHSH",
			"SSSSHSSHSHSHHSSSSH"
		};
		int __expected = 8;
		int __result = new TheKingsArmyDiv1().getNumber(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example5()
	{
		string[] state = new string[] {
			"HS",
			"HS"
		};
		int __expected = 1;
		int __result = new TheKingsArmyDiv1().getNumber(state);
		Assert.AreEqual(__expected, __result);
	}

}
