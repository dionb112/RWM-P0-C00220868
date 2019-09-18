using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modulo3
{
    public static int[] moduloThree(int[] x)
    {
        int[] result = new int[x.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = x[i] % 3;
        }
        return result;
    }
}
