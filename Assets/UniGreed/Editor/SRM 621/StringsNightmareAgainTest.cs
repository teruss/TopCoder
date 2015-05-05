using System;
using NUnit.Framework;

[TestFixture]
public class StringsNightmareAgainTest
{
    [Test]
    public void Example0()
    {
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int n = 4;
        long __expected = 2L;
        long __result = new StringsNightmareAgain().UniqueSubstrings(a, b, c, d, n);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example1()
    {
        int a = 2;
        int b = 3;
        int c = 1;
        int d = 1;
        int n = 6;
        long __expected = 3L;
        long __result = new StringsNightmareAgain().UniqueSubstrings(a, b, c, d, n);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example2()
    {
        int a = 4;
        int b = 3;
        int c = 1;
        int d = 1;
        int n = 6;
        long __expected = 3L;
        long __result = new StringsNightmareAgain().UniqueSubstrings(a, b, c, d, n);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example3()
    {
        int a = 4;
        int b = 3;
        int c = 3;
        int d = 3;
        int n = 10;
        long __expected = 5L;
        long __result = new StringsNightmareAgain().UniqueSubstrings(a, b, c, d, n);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example4()
    {
        int a = 5;
        int b = 3;
        int c = 2;
        int d = 3;
        int n = 11;
        long __expected = 9L;
        long __result = new StringsNightmareAgain().UniqueSubstrings(a, b, c, d, n);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example5()
    {
        int a = 10;
        int b = 1000000;
        int c = 1000000;
        int d = 1;
        int n = 51;
        long __expected = 63L;
        long __result = new StringsNightmareAgain().UniqueSubstrings(a, b, c, d, n);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example14()
    {
        int a = 598;
        int b = 187;
        int c = 171;
        int d = 368;
        int n = 715;
        long __expected = 2703L;
        long __result = new StringsNightmareAgain().UniqueSubstrings(a, b, c, d, n);
        Assert.AreEqual(__expected, __result);
    }
}
