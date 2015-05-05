using System;
using NUnit.Framework;

[TestFixture]
public class BoardFoldingTest
{
    [Test]
    public void Example0()
    {
        int N = 2;
        int M = 2;
        string[] compressedPaper = new string[] {
			"1",
			"3"
		};
        int __expected = 1;
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example1()
    {
        int N = 2;
        int M = 7;
        string[] compressedPaper = new string[] {
			"@@",
			"@@"
		};
        int __expected = 84;
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example2()
    {
        int N = 4;
        int M = 4;
        string[] compressedPaper = new string[] {
			"6",
			"9",
			"9",
			"6"
		};
        int __expected = 9;
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example3()
    {
        int N = 6;
        int M = 1;
        string[] compressedPaper = new string[] {
			"0",
			"2",
			"6",
			"@",
			"4",
			"A"
		};
        int __expected = 6;
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example4()
    {
        int N = 3;
        int M = 3;
        string[] compressedPaper = new string[] {
			"0",
			"2",
			"0"
		};
        int __expected = 1;
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Assert.AreEqual(__expected, __result);
    }

    [Test, MaxTime(2000)]
    public void SystemTest10()
    {
        int N = 250;
        int M = 11;
        string[] compressedPaper = new string[]
        {
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "m6",
            "Fp",
            "Fp",
            "m6",
            "Fp",
            "m6",
            "m6",
            "Fp",
            "Fp",
            "m6"
        };
        int __expected = 16448;
        int __result = new BoardFolding().howMany(N, M, compressedPaper);
        Assert.AreEqual(__expected, __result);
    }
}
