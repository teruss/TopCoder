using System;
using NUnit.Framework;

[TestFixture]
public class AliceGameEasyTest
{
    [Test]
    public void Example0()
    {
        long x = 7L;
        long y = 14L;
        long __expected = 2L;
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example1()
    {
        long x = 10L;
        long y = 0L;
        long __expected = 4L;
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example2()
    {
        long x = 932599670050L;
        long y = 67400241741L;
        long __expected = 1047062L;
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example3()
    {
        long x = 7L;
        long y = 13L;
        long __expected = -1L;
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example4()
    {
        long x = 0L;
        long y = 0L;
        long __expected = 0L;
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Assert.AreEqual(__expected, __result);
    }

    [Test]
    public void Example5()
    {
        long x = 100000L;
        long y = 400500L;
        long __expected = 106L;
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Assert.AreEqual(__expected, __result);
    }
    
    [Test]
    public void Example52()
    {
        long x = 59735405820L;
        long y = 15L;
        long __expected = 345640L;
        long __result = new AliceGameEasy().findMinimumValue(x, y);
        Assert.AreEqual(__expected, __result);
    }
    
}
