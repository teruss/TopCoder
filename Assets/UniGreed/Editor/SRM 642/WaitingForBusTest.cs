using System;
using NUnit.Framework;

[TestFixture]
public class WaitingForBusTest
{
    class TcDoubleEqualityComparer : System.Collections.Generic.IEqualityComparer<double>
    {
        public bool Equals(double x, double y)
        {
            double eps = 1e-9;
            return
				!double.IsNaN(x) && !double.IsNaN(y)
                && Math.Abs(x - y) <= eps * Math.Max(1.0, Math.Min(Math.Abs(x), Math.Abs(y)));
        }

        public int GetHashCode(double obj)
        {
            // Not relevant
            throw new NotImplementedException();
        }
    }

    private static void AssertTcEqualTo<T>(T expected, T actual)
    {
        Assert.That(actual, Is.EqualTo(expected).Using(new TcDoubleEqualityComparer()));
    }

    [Test]
    public void Example0()
    {
        int[] time = new int[] {
			5,
			100
		};
        int[] prob = new int[] {
			90,
			10
		};
        int s = 5;
        double __expected = 9.5;
        double __result = new WaitingForBus().whenWillBusArrive(time, prob, s);
        AssertTcEqualTo(__expected, __result);
    }

    [Test]
    public void Example1()
    {
        int[] time = new int[] {
			5
		};
        int[] prob = new int[] {
			100
		};
        int s = 101;
        double __expected = 4.0;
        double __result = new WaitingForBus().whenWillBusArrive(time, prob, s);
        AssertTcEqualTo(__expected, __result);
    }

    [Test]
    public void Example2()
    {
        int[] time = new int[] {
			5,
			10
		};
        int[] prob = new int[] {
			50,
			50
		};
        int s = 88888;
        double __expected = 3.666666666666667;
        double __result = new WaitingForBus().whenWillBusArrive(time, prob, s);
        AssertTcEqualTo(__expected, __result);
    }

    [Test]
    public void Example3()
    {
        int[] time = new int[] {
			1,
			2,
			3,
			4
		};
        int[] prob = new int[] {
			10,
			20,
			30,
			40
		};
        int s = 1000;
        double __expected = 1.166666666666667;
        double __result = new WaitingForBus().whenWillBusArrive(time, prob, s);
        AssertTcEqualTo(__expected, __result);
    }

    [Test]
    public void Example4()
    {
        int[] time = new int[] {
			10,
			100,
			1000,
			10000,
			100000
		};
        int[] prob = new int[] {
			90,
			4,
			3,
			2,
			1
		};
        int s = 100000;
        double __expected = 21148.147303578935;
        double __result = new WaitingForBus().whenWillBusArrive(time, prob, s);
        AssertTcEqualTo(__expected, __result);
    }

}
