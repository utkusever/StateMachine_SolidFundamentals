using System;
using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base.Enemy;
using UnityEngine;

public abstract class HealthBase : MonoBehaviour, IDamageable, IHealth
{
    [field: SerializeField] public float Health { get; set; }
    public bool IsDead { get; set; }
    private IStats Istat;

    private void Start()
    {
        Istat = this.GetComponent<IStats>();
        Health = Istat.BaseStat.health;
    }

    public virtual void ApplyDamage(IHealth health, float value)
    {
        health.Health -= value;
        CheckHealth();
        if (IsDead) return;
    }

    private void CheckHealth()
    {
        IsDead = Health <= 0;
        if (IsDead)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Destroy(this.gameObject);
    }
}