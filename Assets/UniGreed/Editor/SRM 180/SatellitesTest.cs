using System;
using NUnit.Framework;

[TestFixture]
public class SatellitesTest
{
	[Test]
	public void Example0()
	{
		string[] rockets = new string[] {
			"+0000.000 -0000.000"
		};
		string[] satellites = new string[] {
			"+0000.000 -0000.000 +0200.000",
			"+0000.000 -0000.000 +0400.000",
			"+0000.000 -0000.000 +1200.000"
		};
		int[] __expected = new int[] {
			0
		};
		int[] __result = new Satellites().detectable(rockets, satellites);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		string[] rockets = new string[] {
			"-0050.000 +0045.000",
			"+0040.000 -0135.000"
		};
		string[] satellites = new string[] {
			"+0090.000 +0000.000 +1200.000",
			"-0090.000 +0000.000 +1200.000",
			"+0000.000 +0000.000 +1200.000",
			"+0000.000 -0090.000 +1200.000",
			"+0000.000 +0180.000 +1200.000",
			"-0000.000 -0045.000 +1200.000",
			"-0000.000 -0135.000 +1000.000",
			"-0011.000 -0136.000 +1086.828"
		};
		int[] __expected = new int[] {
			1
		};
		int[] __result = new Satellites().detectable(rockets, satellites);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		string[] rockets = new string[] {
			"+0037.431 -0143.361",
			"+0037.443 -0143.375",
			"+0037.413 -0143.364"
		};
		string[] satellites = new string[] {
			"+0037.470 -0143.316 +0513.143",
			"+0037.443 -0143.388 +0342.159",
			"+0037.434 -0143.361 +1034.123"
		};
		int[] __expected = new int[] {
			0,
			1,
			2
		};
		int[] __result = new Satellites().detectable(rockets, satellites);
		Assert.AreEqual(__expected, __result);
	}

}
