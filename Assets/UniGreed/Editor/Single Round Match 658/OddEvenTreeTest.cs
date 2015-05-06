using System;
using NUnit.Framework;

[TestFixture]
public class OddEvenTreeTest
{
	[Test]
	public void Example0 ()
	{
		string[] x = new string[] {
			"EOE",
			"OEO",
			"EOE"
		};
		int[] __expected = new int[] {
			0,
			1,
			1,
			2,
		};
		int[] __result = new OddEvenTree ().getTree (x);
		Assert.AreEqual (__expected, __result);
	}

	[Test]
	public void Example1 ()
	{
		string[] x = new string[] {
			"EO",
			"OE"
		};
		int[] __expected = new int[] {
			0,
			1
		};
		int[] __result = new OddEvenTree ().getTree (x);
		Assert.AreEqual (__expected, __result);
	}

	[Test]
	public void Example2 ()
	{
		string[] x = new string[] {
			"OO",
			"OE"
		};
		int[] __expected = new int[] {
			-1
		};
		int[] __result = new OddEvenTree ().getTree (x);
		Assert.AreEqual (__expected, __result);
	}

	[Test]
	public void Example3 ()
	{
		string[] x = new string[] {
			"EO",
			"EE"
		};
		int[] __expected = new int[] {
			-1
		};
		int[] __result = new OddEvenTree ().getTree (x);
		Assert.AreEqual (__expected, __result);
	}

	[Test]
	public void Example4 ()
	{
		string[] x = new string[] {
			"EOEO",
			"OEOE",
			"EOEO",
			"OEOE"
		};
		int[] __expected = new int[] {
			0,
			1,
			0,
			3,
			1,
			2,
		};
		int[] __result = new OddEvenTree ().getTree (x);
		Assert.AreEqual (__expected, __result);
	}

}
