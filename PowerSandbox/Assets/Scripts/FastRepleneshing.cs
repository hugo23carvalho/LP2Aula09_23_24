using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplenishingHealth : Superpower
{
    [SerializeField]
    [Range(-1f, 1f)]
    private float speedBoostPercent = 0.5f;

    [SerializeField]
    [Range(0, 100)]
    private float ReplenishedHealth = 30;

    public override void Activate()
    {
        BoostSpeed(speedBoostPercent);
        Heal(ReplenishedHealth);
    }
}
