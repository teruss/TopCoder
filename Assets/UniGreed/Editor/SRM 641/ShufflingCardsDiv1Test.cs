using System;
using NUnit.Framework;

[TestFixture]
public class ShufflingCardsDiv1Test
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
		int __expected = 0;
		int __result = new ShufflingCardsDiv1().shuffle(permutation);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		int[] permutation = new int[] {
			1,
			4,
			3,
			2
		};
		int __expected = 2;
		int __result = new ShufflingCardsDiv1().shuffle(permutation);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		int[] permutation = new int[] {
			6,
			3,
			5,
			2,
			4,
			1
		};
		int __expected = 4;
		int __result = new ShufflingCardsDiv1().shuffle(permutation);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
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
		int __expected = 2;
		int __result = new ShufflingCardsDiv1().shuffle(permutation);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		int[] permutation = new int[] {
			9,
			1,
			7,
			2,
			10,
			3,
			6,
			4,
			8,
			5
		};
		int __expected = 4;
		int __result = new ShufflingCardsDiv1().shuffle(permutation);
		Assert.AreEqual(__expected, __result);
	}

}
