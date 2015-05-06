using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Mutalisk
{

	bool Check (int[] x, int attacks)
	{
		UnityEngine.Debug.Log ("attacks:" + attacks);

		var attacked = new int[x.Length];
		for (int i = 0; i < attacks; i++) {
			int max = x.Max ();
			if (max <= 0)
				return true;
			int index = Array.IndexOf (x, max);
			if (attacked [index] >= attacks)
				return false;
			attacked [index]++;
			x [index] -= 9;
			UnityEngine.Debug.Log (x [index]);
		}
		for (int i = 0; i < attacks; i++) {
			int max = x.Max ();
			UnityEngine.Debug.Log ("max:" + max);
			if (max <= 0)
				return true;
			int index = Array.IndexOf (x, max);
			if (attacked [index] >= attacks)
				return false;
			attacked [index]++;
			x [index] -= 3;
			UnityEngine.Debug.Log (x [index]);
		}
		for (int i = 0; i < attacks; i++) {
			int max = x.Max ();
			if (max <= 0)
				return true;
			int index = Array.IndexOf (x, max);
			if (attacked [index] >= attacks)
				return false;
			attacked [index]++;
			x [index] -= 1;
			UnityEngine.Debug.Log (x [index]);
		}
		int maxx = x.Max ();
		if (maxx <= 0)
			return true;
		return false;
	}

	public int minimalAttacks (int[] x)
	{

		int l = 0, r = 134;
		while (l + 1 < r) {
//			UnityEngine.Debug.Log ("l:" + l + ",r:" + r);
			int mid = (l + r) / 2;
			if (!Check ((int[])x.Clone (), mid))
				l = mid;
			else
				r = mid;
			UnityEngine.Debug.Log ("l:" + l + ",r:" + r);
		}
		return l + 1;
	}

}
