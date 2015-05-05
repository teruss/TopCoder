using System;
using NUnit.Framework;

[TestFixture]
public class HexagonalBoardTest
{
	[Test]
	public void Example0()
	{
		string[] board = new string[] {
			"---",
			"---",
			"---"
		};
		int __expected = 0;
		int __result = new HexagonalBoard().minColors(board);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		string[] board = new string[] {
			"-X--",
			"---X",
			"----",
			"-X--"
		};
		int __expected = 1;
		int __result = new HexagonalBoard().minColors(board);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		string[] board = new string[] {
			"XXXX",
			"---X",
			"---X",
			"---X"
		};
		int __expected = 2;
		int __result = new HexagonalBoard().minColors(board);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		string[] board = new string[] {
			"XX-XX--",
			"-XX-XXX",
			"X-XX--X",
			"X--X-X-",
			"XX-X-XX",
			"-X-XX-X",
			"-XX-XX-"
		};
		int __expected = 3;
		int __result = new HexagonalBoard().minColors(board);
		Assert.AreEqual(__expected, __result);
	}

}
