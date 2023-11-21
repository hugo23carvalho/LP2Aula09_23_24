using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolvesAI : AnimalsAI
{
    protected override void SelectTarget()
    {
        Debug.Log("Wolves found a sheep");
    }
    
    protected override void Move()
    {
        Debug.Log("Wolves are moving");
    }

    protected override void TryEat()
    {
         Debug.Log("Wolves are trying to catch a sheep");
    }

    protected override void TryReproduce()
    {
         Debug.Log("Wolves are reproducing");
    }
}
