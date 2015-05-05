using System;
using NUnit.Framework;

[TestFixture]
public class MagicMoleculeTest
{
    [Test]
    public void Example0()
    {
        int[] magicPower = new int[] {
			1,
			2,
			3
		};
        string[] magicBond = new string[] {
			"NYY",
			"YNN",
			"YNN"
		};
        int __expected = 4;
        int __result = new MagicMolecule().maxMagicPower(magicPower, magicBond);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example1()
    {
        int[] magicPower = new int[] {
			1,
			1,
			1,
			1
		};
        string[] magicBond = new string[] {
			"NNYY",
			"NNYY",
			"YYNN",
			"YYNN"
		};
        int __expected = -1;
        int __result = new MagicMolecule().maxMagicPower(magicPower, magicBond);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example2()
    {
        int[] magicPower = new int[] {
			86,
			15,
			100,
			93,
			53,
			50
		};
        string[] magicBond = new string[] {
			"NYYYYN",
			"YNNNNY",
			"YNNYYN",
			"YNYNYN",
			"YNYYNY",
			"NYNNYN"
		};
        int __expected = 332;
        int __result = new MagicMolecule().maxMagicPower(magicPower, magicBond);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example3()
    {
        int[] magicPower = new int[] {
			3969,
			9430,
			7242,
			8549,
			8190,
			8368,
			3704,
			9740,
			1691
		};
        string[] magicBond = new string[] {
			"NYYYYYYYY",
			"YNYYYYYYY",
			"YYNYYYYYY",
			"YYYNYYYYY",
			"YYYYNYYYY",
			"YYYYYNYYY",
			"YYYYYYNNY",
			"YYYYYYNNY",
			"YYYYYYYYN"
		};
        int __expected = 57179;
        int __result = new MagicMolecule().maxMagicPower(magicPower, magicBond);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void TestCase11()
    {
        int[] magicPower = new int[]
        {
            1545,
            9411,
            6974,
            3635,
            8403,
            5066,
            8452,
            1722,
            3513,
            5750,
            3022,
            4118,
            7281,
            4364,
            1577,
            9622,
            6348,
            211,
            3639,
            4357,
            3151,
            147,
            8259,
            1913,
            4704,
            3362,
            765,
            5262,
            4595,
            3978,
            2050,
            1074,
            8342,
            7535,
            6843,
            7970,
            7449,
            2751,
            3978,
            2101,
            5890
        };
        string[] magicBond = new string[]
        {
            "NYYYYYYYNYYYYYYYNYYYYYYYYYYNYYYYYYYYNYYYY",
            "YNNNYNYNYNYNYNNYNYYYYYYNYNNYYYYNYYNYYNYNN",
            "YNNYYYYYYYYYYYYNYYYYNYYNYYYYYYYYYYYNYYYYY",
            "YNYNYYYYYNNNYYYYYYYYYYYNYYYYYYYYYYYNYYYYY",
            "YYYYNNYYYNYYYYYNYYYYNYYNYYYNYYYYYYNYNYYYY",
            "YNYYNNYYNNYNYYNNYYYNNYYYYYNYYNYYNNNNYNYYY",
            "YYYYYYNYYNNYYYYYNYYYNYYNYYYYYNYYYYNNNYYYY",
            "YNYYYYYNNNNNYYYYYYYYYYYNYYYNYYYYYYNYYYYYY",
            "NYYYYNYNNNNYNYNYNYYYNNYNYYYYNYYNYNNYNNNYN",
            "YNYNNNNNNNNYNNYYYNNNYNYNNNNYYYYNNNYNNNYYY",
            "YYYNYYNNNNNNNYYYNYYNNNNYYYNNNYYYYYYYYNNNY",
            "YNYNYNYNYYNNYYYNYYYYYYYYNNNNNYYNYYYYYNNYN",
            "YYYYYYYYNNNYNYYNNYYYNYYYYYYYYYYYYYNNNYYYY",
            "YNYYYYYYYNYYYNYNNYYYNYYNYYYYYNYYYYNNYYYYY",
            "YNYYYNYYNYYYYYNYNYYYYYYNYYYNYYYYYYNYNYYYY",
            "YYNYNNYYYYYNNNYNNNYYNYNNYNYNNYNYNNYYYNNYY",
            "NNYYYYNYNYNYNNNNNYYNNNYYNNNYYYYNYYYYNNYYY",
            "YYYYYYYYYNYYYYYNYNYYNYYNYYYNYYYYYYYNNYYYY",
            "YYYYYYYYYNYYYYYYYYNYNYYYYYYYYYYYYYYYNYYYY",
            "YYYYYNYYYNNYYYYYNYYNYYYYYYYNYNYYYYYYYYYYY",
            "YYNYNNNYNYNYNNYNNNNYNYYYNYNNNYYYNNYNYNYYY",
            "YYYYYYYYNNNYYYYYNYYYYNYNYYYYYYYYYYYYYYYYY",
            "YYYYYYYYYYNYYYYNYYYYYYNNYYYNYNYYYYYYNYYYY",
            "YNNNNYNNNNYYYNNNYNYYYNNNNNYYNYNYNNNYNYYYN",
            "YYYYYYYYYNYNYYYYNYYYNYYNNYYNYYYYYYNYNYYYY",
            "YNYYYYYYYNYNYYYNNYYYYYYNYNYNYNYYYYNNNYYYY",
            "YNYYYNYYYNNNYYYYNYYYNYYYYYNYYNYYYYNNNYYYY",
            "NYYYNYYNYYNNYYNNYNYNNYNYNNYNYYNNNYYYNNNNY",
            "YYYYYYYYNYNNYYYNYYYYNYYNYYYYNYYYYYNNYYYYY",
            "YYYYYNNYYYYYYNYYYYYNYYNYYNNYYNNNNNNNNYYYY",
            "YYYYYYYYYYYYYYYNYYYYYYYNYYYNYNNYYYYYYYYYY",
            "YNYYYYYYNNYNYYYYNYYYYYYYYYYNYNYNYYNYYYYYY",
            "YYYYYNYYYNYYYYYNYYYYNYYNYYYNYNYYNYYNNYYYY",
            "YYYYYNYYNNYYYYYNYYYYNYYNYYYYYNYYYNYYNYYYY",
            "YNYYNNNNNYYYNNNYYYYYYYYNNNNYNNYNYYNYNYYYN",
            "YYNNYNNYYNYYNNYYYNYYNYYYYNNYNNYYNYYNYNYNN",
            "NYYYNYNYNNYYNYNYNNNYYYNNNNNNYNYYNNNYNYNNN",
            "YNYYYNYYNNNNYYYNNYYYNYYYYYYNYYYYYYYNYNYYY",
            "YYYYYYYYNYNNYYYNYYYYYYYYYYYNYYYYYYYYNYNYY",
            "YNYYYYYYYYNYYYYYYYYYYYYYYYYNYYYYYYYNNYYNY",
            "YNYYYYYYNYYNYYYYYYYYYYYNYYYYYYYYYYNNNYYYN"
        };
        int __expected = -1;
        int __result = new MagicMolecule().maxMagicPower(magicPower, magicBond);
        Assert.AreEqual(__expected, __result);
    }
}
