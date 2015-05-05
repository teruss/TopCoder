using System;
using NUnit.Framework;

[TestFixture]
public class LightSwitchingPuzzleTest
{
	[Test]
	public void Example0()
	{
		string state = "YYYYYY";
		int __expected = 1;
		int __result = new LightSwitchingPuzzle().minFlips(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		string state = "YNYNYNYNY";
		int __expected = 2;
		int __result = new LightSwitchingPuzzle().minFlips(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		string state = "NNNNNNNNNN";
		int __expected = 0;
		int __result = new LightSwitchingPuzzle().minFlips(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		string state = "YYYNYYYNYYYNYYNYYYYN";
		int __expected = 4;
		int __result = new LightSwitchingPuzzle().minFlips(state);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		string state = "NYNNYNNNYNNNNYNNNNNYNNNNNNYNNNNNNNY";
		int __expected = 12;
		int __result = new LightSwitchingPuzzle().minFlips(state);
		Assert.AreEqual(__expected, __result);
	}

}
