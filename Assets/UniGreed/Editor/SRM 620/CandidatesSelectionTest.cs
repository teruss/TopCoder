using System;
using NUnit.Framework;

[TestFixture]
public class CandidatesSelectionTest
{
	[Test]
	public void Example0()
	{
		string[] score = new string[] {
			"CC",
			"AA",
			"BB"
		};
		int[] result = new int[] {
			1,
			2,
			0
		};
		string __expected = "Possible";
		string __result = new CandidatesSelection().possible(score, result);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		string[] score = new string[] {
			"BAB",
			"ABB",
			"AAB",
			"ABA"
		};
		int[] result = new int[] {
			2,
			0,
			1,
			3
		};
		string __expected = "Possible";
		string __result = new CandidatesSelection().possible(score, result);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		string[] score = new string[] {
			"BAB",
			"ABB",
			"AAB",
			"ABA"
		};
		int[] result = new int[] {
			0,
			1,
			3,
			2
		};
		string __expected = "Impossible";
		string __result = new CandidatesSelection().possible(score, result);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		string[] score = new string[] {
			"AAA",
			"ZZZ"
		};
		int[] result = new int[] {
			1,
			0
		};
		string __expected = "Impossible";
		string __result = new CandidatesSelection().possible(score, result);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		string[] score = new string[] {
			"ZZZ",
			"AAA"
		};
		int[] result = new int[] {
			0,
			1
		};
		string __expected = "Possible";
		string __result = new CandidatesSelection().possible(score, result);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example5()
	{
		string[] score = new string[] {
			"ZYYYYX",
			"YXZYXY",
			"ZZZZXX",
			"XZXYYX",
			"ZZZYYZ",
			"ZZXXYZ",
			"ZYZZXZ",
			"XZYYZX"
		};
		int[] result = new int[] {
			3,
			7,
			1,
			0,
			2,
			5,
			6,
			4
		};
		string __expected = "Possible";
		string __result = new CandidatesSelection().possible(score, result);
		Assert.AreEqual(__expected, __result);
	}

}
