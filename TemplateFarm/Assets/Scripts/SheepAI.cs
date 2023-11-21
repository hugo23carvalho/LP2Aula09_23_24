using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepAI : AnimalsAI
{
    protected override void Move()
    {
        Debug.Log("sheep is moving");
    }

    protected override void TryEat()
    {
         Debug.Log("sheep is trying to eat");
    }

    protected override void TryReproduce()
    {
         Debug.Log("sheep is trying to reproduce");
    }

}
