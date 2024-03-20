using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base.Enemy;
using UnityEngine;

public class PlayerHealth : HealthBase
{
    public override void ApplyDamage(IHealth health, float value)
    {
        base.ApplyDamage(health, value);
        print("health: " + health);
    }
}