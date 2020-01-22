using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public static class BenchmarkHelper
{

    public static long Benchmark(Action act)
    {
        GC.Collect();
        act.Invoke();
        Stopwatch sw = Stopwatch.StartNew();
        for (int i = 0; i < 10; i++)
        {
            act.Invoke();
        }
        sw.Stop();
        return sw.ElapsedMilliseconds / 10;
    }

}
