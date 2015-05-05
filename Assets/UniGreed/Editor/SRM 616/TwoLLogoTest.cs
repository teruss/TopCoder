using System;
using NUnit.Framework;

[TestFixture]
public class TwoLLogoTest
{
	[Test]
	public void Example0()
	{
		string[] grid = new string[] {
			"....",
			"...."
		};
		long __expected = 1L;
		long __result = new TwoLLogo().countWays(grid);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		string[] grid = new string[] {
			".##..",
			"...#.",
			".#.#.",
			"#...#"
		};
		long __expected = 3L;
		long __result = new TwoLLogo().countWays(grid);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		string[] grid = new string[] {
			"..#.",
			"#.#.",
			"....",
			"..#."
		};
		long __expected = 4L;
		long __result = new TwoLLogo().countWays(grid);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		string[] grid = new string[] {
			"..",
			".."
		};
		long __expected = 0L;
		long __result = new TwoLLogo().countWays(grid);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		string[] grid = new string[] {
			".#.#",
			"....",
			".#.#",
			"...."
		};
		long __expected = 34L;
		long __result = new TwoLLogo().countWays(grid);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example5()
	{
		string[] grid = new string[] {
			"##############",
			"##############",
			"#.############",
			"#.############",
			"#.############",
			"#.############",
			"#.############",
			"#.############",
			"#.#####.######",
			"#.#####.######",
			"#.#####.######",
			"#....##.######",
			"#######.######",
			"#######.######",
			"#######.######",
			"#######.######",
			"#######.######",
			"#######.######",
			"#######......#",
			"##############"
		};
		long __expected = 1350L;
		long __result = new TwoLLogo().countWays(grid);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example6()
	{
		string[] grid = new string[] {
			"#......",
			".#....#",
			".#.#...",
			"#....#.",
			".##..#.",
			".#.....",
			".....#.",
			".#.#...",
			".#...#.",
			"..##..."
		};
		long __expected = 2386L;
		long __result = new TwoLLogo().countWays(grid);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example7()
	{
		string[] grid = new string[] {
			"...#..........................",
			"..............................",
			"..............................",
			"..................#...#.......",
			"..................#...........",
			"..............................",
			"...........#..................",
			"..............................",
			".....#..#.....................",
			".......................#......",
			"..................#.....#.....",
			"..............................",
			"..............................",
			"..............................",
			"..............................",
			"..#...........................",
			"..............................",
			"..............................",
			"..............................",
			"#............................#",
			"..............................",
			".....#.........#............#.",
			"..............................",
			".........................#....",
			".#............................",
			".............#................",
			"..............................",
			"..............................",
			".......................#......",
			".............#................"
		};
		long __expected = 5020791386L;
		long __result = new TwoLLogo().countWays(grid);
		Assert.AreEqual(__expected, __result);
	}

}
