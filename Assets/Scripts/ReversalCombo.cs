using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReversalCombo 
{
   public static int[] reversalCCombo(int[] xs)
    {
        return Reverse.reverses(DecrementIfLessThanFirst.decrementIfLessS(xs));
    }
}
