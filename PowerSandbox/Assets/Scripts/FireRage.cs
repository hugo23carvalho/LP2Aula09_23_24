using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRage : Superpower
{
   [SerializeField]
    [Range(0, 100)]
    private float damageToDeal = 45;

    public override void Activate()
    {
        DealDamage(damageToDeal);
        LightMyFire();
    }
}