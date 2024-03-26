using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEffects : MonoBehaviour, IHealthObserver
{
    [SerializeField] private ParticleSystem healEffects;
    [SerializeField] private ParticleSystem hurtEffects;

    private void Start()
    {
        this.GetComponent<HealthEvents>().AddListener(this);
    }

    public void OnNotify(float value)
    {
        if (value > 0)
        {
            if (!healEffects.isPlaying)
            {
                healEffects.Play();
            }
        }
        else
        {
            if (!hurtEffects.isPlaying)
            {
                hurtEffects.Play();
            }
        }
    }
}