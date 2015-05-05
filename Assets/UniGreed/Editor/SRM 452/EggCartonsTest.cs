using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class EggCartonsTest : MonoBehaviour
{
    List<int> expectedList = new List<int>();
    List<int> resultList = new List<int>();

    void RunTestcase(int __case)
    {
        switch (__case)
        {
            case 0:
                {
                    int n = 20;
				int __expected = 3;
				expectedList.Add(__expected);
				resultList.Add(DoTest(n, __expected, __case));
				break;
			}
            case 1:
                {
                    int n = 24;
				int __expected = 3;
				expectedList.Add(__expected);
				resultList.Add(DoTest(n, __expected, __case));
				break;
			}
            case 2:
                {
                    int n = 15;
				int __expected = -1;
				expectedList.Add(__expected);
				resultList.Add(DoTest(n, __expected, __case));
				break;
			}
            case 3:
                {
                    int n = 4;
				int __expected = -1;
				expectedList.Add(__expected);
				resultList.Add(DoTest(n, __expected, __case));
				break;
			}
			default: break;
		}
    }

    int DoTest(int n, int __expected, int caseNo)
    {
        DateTime startTime = DateTime.Now;
        Exception exception = null;
        EggCartons instance = new EggCartons();
        int __result = 0;
        try
        {
            __result = instance.minCartons(n);
        } catch (Exception e)
        {
            exception = e;
        }
        TimeSpan __elapsed = new TimeSpan(DateTime.Now.Ticks - startTime.Ticks);

        nAll++;
        Console.Error.Write(string.Format("  Testcase #{0} ... ", caseNo));

        if (exception != null)
        {
            Console.Error.WriteLine("RUNTIME ERROR!");
            Console.Error.WriteLine(exception);
        } else if (__result == __expected)
        {
            Console.Error.WriteLine("PASSED! " + string.Format("({0:0.00} seconds)", __elapsed.TotalSeconds));
            nPassed++;
        } else
        {
            Console.Error.WriteLine("FAILED! " + string.Format("({0:0.00} seconds)", __elapsed.TotalSeconds));
        }
        return __result;
    }

    static int nExample = 4;
    static int nAll = 0, nPassed = 0;


    void Start()
    {
        for (int i = 0; i < nExample; ++i)
            RunTestcase(i);
    }

    void OnGUI()
    {
        GUILayout.Label("EggCartons (250 Points)");
        GUILayout.Label("");

        for (int caseNo = 0; caseNo < nExample; ++caseNo)
        {
            string resultString = string.Format("  Testcase #{0} ... ", caseNo);
            
            if (resultList[caseNo] == expectedList[caseNo])
            {
                GUILayout.Label(resultString + "PASSED!");
            } else
            {
                GUILayout.Label(resultString + "FAILED!");
                GUILayout.Label("           Expected: " + expectedList[caseNo]);
                GUILayout.Label("           Received: " + resultList[caseNo]);
            }

        }
        GUILayout.Label("");
        GUILayout.Label(string.Format("Passed : {0}/{1} cases", nPassed, nAll));
        
        DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        int T = (int)((DateTime.UtcNow - Jan1st1970).TotalSeconds - 1414743287);
        double PT = T / 60.0, TT = 75.0;
        GUILayout.Label(string.Format("Time   : {0} minutes {1} secs", T / 60, T % 60));
        GUILayout.Label(string.Format("Score  : {0:0.00} points", 250 * (0.3 + (0.7 * TT * TT) / (10.0 * PT * PT + TT * TT))));
    }
}
