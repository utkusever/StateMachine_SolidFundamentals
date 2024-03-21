using System;
using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base.Enemy;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    [SerializeField] protected float damageValue;
    [SerializeField] protected float speed;
    
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamageable damageable))
        {
            damageable.ApplyDamage(damageValue);
            OnTriggerPlayer();
        }
    }

    protected virtual void OnTriggerPlayer()
    {
        SpawnEffect();
        Destroy();
    }

    protected virtual void SpawnEffect()
    {
    }

    protected virtual void Destroy()
    {
        Destroy(this.gameObject);
    }
}