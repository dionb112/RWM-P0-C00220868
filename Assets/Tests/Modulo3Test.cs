using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Modulo3Test
    {
        [Test]
        public void Modulo3Simple()
        {
            int[] input = { 7, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = Modulo3.moduloThree(input);
            int[] expected = { 1, 2, 2, 0, 0, 1, 1, 2, 2, 0 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void Modulo3Complex()
        {
            int[] input = { 0, -2, 100000 };
            int[] output = Modulo3.moduloThree(input);
            int[] expected = { 0, 1, 1 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
