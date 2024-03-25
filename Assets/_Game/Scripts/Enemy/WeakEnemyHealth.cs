using UnityEngine;

public class WeakEnemyHealth : EnemyHealth
{
    [SerializeField] private float takeDmgMultiplier;
    
    public override void ApplyDamage(float value)
    {
        base.ApplyDamage(value * takeDmgMultiplier);
    }
}