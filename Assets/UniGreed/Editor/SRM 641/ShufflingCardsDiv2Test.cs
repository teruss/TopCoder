using System;
using NUnit.Framework;

[TestFixture]
public class ShufflingCardsDiv2Test
{
	[Test]
	public void Example0()
	{
		int[] permutation = new int[] {
			1,
			2,
			3,
			4
		};
		string __expected = "Possible";
		string __result = new ShufflingCardsDiv2().shuffle(permutation);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int[] permutation = new int[] {
			4,
			3,
			2,
			1
		};
		string __expected = "Possible";
		string __result = new ShufflingCardsDiv2().shuffle(permutation);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int[] permutation = new int[] {
			1,
			3,
			2,
			4
		};
		string __expected = "Impossible";
		string __result = new ShufflingCardsDiv2().shuffle(permutation);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		int[] permutation = new int[] {
			1,
			4,
			2,
			5,
			3,
			6
		};
		string __expected = "Impossible";
		string __result = new ShufflingCardsDiv2().shuffle(permutation);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int[] permutation = new int[] {
			8,
			5,
			4,
			9,
			1,
			7,
			6,
			10,
			3,
			2
		};
		string __expected = "Possible";
		string __result = new ShufflingCardsDiv2().shuffle(permutation);
		Assert.AreEqual(__expected, __result);
	}

}
