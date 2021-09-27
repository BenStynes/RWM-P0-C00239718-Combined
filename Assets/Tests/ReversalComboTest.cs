using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;


namespace Tests
{
    public class ReversalComboTest
    {
        [Test]
        public void reversealComboSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 1 };
            int[] output = ReversalCombo.reversalCCombo(input);
            int[] expected = { 0, 6, 11, 5, 10, 4, 9, 2, 8, 1, 4 };
           

            CollectionAssert.AreEqual(expected, output);
        }
    }
}