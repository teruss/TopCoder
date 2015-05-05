using System;
using NUnit.Framework;

[TestFixture]
public class ForgetfulAdditionTest
{
	[Test]
	public void Example0()
	{
		string expression = "22";
		int __expected = 4;
		int __result = new ForgetfulAddition().minNumber(expression);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example1()
	{
		string expression = "123";
		int __expected = 15;
		int __result = new ForgetfulAddition().minNumber(expression);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example2()
	{
		string expression = "1289";
		int __expected = 101;
		int __result = new ForgetfulAddition().minNumber(expression);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example3()
	{
		string expression = "31415926";
		int __expected = 9067;
		int __result = new ForgetfulAddition().minNumber(expression);
		Assert.AreEqual(__expected, __result);
	}

	[Test]
	public void Example4()
	{
		string expression = "98765";
		int __expected = 863;
		int __result = new ForgetfulAddition().minNumber(expression);
		Assert.AreEqual(__expected, __result);
	}

}
