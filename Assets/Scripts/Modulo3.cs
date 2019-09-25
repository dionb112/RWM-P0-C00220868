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
            if (x[i] < 0)
            {
                result[i] = 3 - (-x[i] % 3);

            }
            else if (x[i] == 0)
            {
                result[i] = 0;
            }
            else
            {
                result[i] = x[i] % 3;

            }
        }
        return result;
    }
}
