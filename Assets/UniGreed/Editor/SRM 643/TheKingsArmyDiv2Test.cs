using System;
using NUnit.Framework;

[TestFixture]
public class TheKingsArmyDiv2Test
{
	[Test]
	public void Example0()
	{
		string[] state = new string[] {
			"SSSSS",
			"SSHHS",
			"SSSSS"
		};
		int __expected = 0;
		int __result = new TheKingsArmyDiv2().getNumber(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		string[] state = new string[] {
			"SSSSS",
			"SSHSH",
			"HSSSS"
		};
		int __expected = 1;
		int __result = new TheKingsArmyDiv2().getNumber(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		string[] state = new string[] {
			"SSS",
			"SSS",
			"SSS"
		};
		int __expected = 2;
		int __result = new TheKingsArmyDiv2().getNumber(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		string[] state = new string[] {
			"HSHSHSH",
			"SSSHSSS",
			"SSHSHSS",
			"SHSHSHS"
		};
		int __expected = 1;
		int __result = new TheKingsArmyDiv2().getNumber(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		string[] state = new string[] {
			"HHSH",
			"HHHS",
			"HSSS",
			"SHSH",
			"HHHS",
			"HSHH",
			"SSSH"
		};
		int __expected = 0;
		int __result = new TheKingsArmyDiv2().getNumber(state);
		Assert.AreEqual(__expected, __result);
	}

}
