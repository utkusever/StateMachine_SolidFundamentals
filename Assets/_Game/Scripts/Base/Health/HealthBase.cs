using System;
using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base.Enemy;
using UnityEngine;
using UnityEngine.Events;

public abstract class HealthBase : MonoBehaviour, IDamageable, IHealth
{
    public float Health
    {
        get => health;
        set
        {
            health = value;
            healthEvent?.Invoke(health);
        }
    }

    public bool IsDead { get; set; }
    private IStats Istat;
    public UnityEvent<float> healthEvent;
    [SerializeField] private float health;

    private void Start()
    {
        Istat = this.GetComponent<IStats>();
        Health = Istat.BaseStat.health;
    }

    public virtual void ApplyDamage(float value)
    {
        Health -= value;
        CheckHealth();
    }

    private void CheckHealth()
    {
        IsDead = Health <= 0;
        if (IsDead)
        {
            Die();
            return;
        }
    }

    protected virtual void Die()
    {
        Destroy(this.gameObject);
    }
}