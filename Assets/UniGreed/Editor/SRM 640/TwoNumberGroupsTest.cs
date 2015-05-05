using System;
using NUnit.Framework;

[TestFixture]
public class TwoNumberGroupsTest
{
    [Test, Ignore]
    public void Example0()
    {
        int[] A = new int[] {
			1
		};
        int[] numA = new int[] {
			2
		};
        int[] B = new int[] {
			3,
			7
		};
        int[] numB = new int[] {
			1,
			1
		};
        int __expected = 14;
        int __result = new TwoNumberGroups().solve(A, numA, B, numB);
        Assert.AreEqual(__expected, __result);
    }

    [Test, Ignore]
    public void Example1()
    {
        int[] A = new int[] {
			100
		};
        int[] numA = new int[] {
			2
		};
        int[] B = new int[] {
			1
		};
        int[] numB = new int[] {
			1
		};
        int __expected = 28;
        int __result = new TwoNumberGroups().solve(A, numA, B, numB);
        Assert.AreEqual(__expected, __result);
    }

    [Test, Ignore]
    public void Example2()
    {
        int[] A = new int[] {
			5,
			1
		};
        int[] numA = new int[] {
			1,
			1
		};
        int[] B = new int[] {
			12,
			999999894
		};
        int[] numB = new int[] {
			1,
			1
		};
        int __expected = 202073;
        int __result = new TwoNumberGroups().solve(A, numA, B, numB);
        Assert.AreEqual(__expected, __result);
    }

    [Test, Ignore]
    public void Example3()
    {
        int[] A = new int[] {
			1
		};
        int[] numA = new int[] {
			1
		};
        int[] B = new int[] {
			1
		};
        int[] numB = new int[] {
			100000
		};
        int __expected = 0;
        int __result = new TwoNumberGroups().solve(A, numA, B, numB);
        Assert.AreEqual(__expected, __result);
    }

    [Test, Ignore]
    public void Example4()
    {
        int[] A = new int[] {
			11795180,
			41472124,
			44285836,
			84280940,
			117000811,
			150317409,
			154188370,
			167804776,
			225797581,
			240995620,
			301931440,
			306528163,
			327332717,
			333523124,
			341325123,
			350292524,
			400857064,
			401290197,
			426573408,
			427972026,
			448467719,
			563926065,
			574489831,
			579516358,
			609409829,
			659343788,
			678481187,
			775710113,
			806992032,
			831437250,
			839580344,
			842388073,
			869876247,
			899553191,
			902366903,
			975081878
		};
        int[] numA = new int[] {
			1188,
			1769,
			1782,
			1757,
			1527,
			4958,
			3083,
			4439,
			3621,
			3958,
			2655,
			2250,
			2079,
			3885,
			3598,
			3236,
			3035,
			2286,
			7340,
			4127,
			3126,
			2904,
			2592,
			3082,
			3789,
			2776,
			3907,
			2368,
			4005,
			4863,
			4482,
			3307,
			2459,
			1436,
			1656,
			2007
		};
        int[] B = new int[] {
			11795180,
			41472124,
			44285836,
			84280940,
			117000811,
			150317409,
			154188370,
			167804776,
			225797581,
			240995620,
			301931440,
			306528163,
			327332717,
			333523124,
			341325123,
			350292524,
			400857064,
			401290197,
			426573408,
			427972026,
			448467719,
			563926065,
			574489831,
			579516358,
			609409829,
			659343788,
			678481187,
			775710113,
			806992032,
			831437250,
			839580344,
			842388073,
			869876247,
			899553191,
			902366903,
			942362007,
			975081878
		};
        int[] numB = new int[] {
			3024,
			902,
			798,
			2,
			1426,
			4959,
			3082,
			4439,
			3622,
			3958,
			2653,
			2249,
			2081,
			3884,
			3599,
			3237,
			3033,
			2285,
			7340,
			4125,
			3127,
			2904,
			2592,
			3082,
			3789,
			2775,
			3907,
			2369,
			4006,
			4863,
			4483,
			3307,
			623,
			2303,
			2642,
			1757,
			2107
		};
        int __expected = 601548244;
        int __result = new TwoNumberGroups().solve(A, numA, B, numB);
        Assert.AreEqual(__expected, __result);
    }

}
