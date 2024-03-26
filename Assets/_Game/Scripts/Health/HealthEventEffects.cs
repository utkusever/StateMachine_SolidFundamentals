using System;
using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base.Enemy;
using UnityEngine;

public class HealthEventEffects : MonoBehaviour
{
    private float currentHealth;
    private float tempHealth;

    public void CheckHealth(float value)
    {
        currentHealth = value;
        if (currentHealth < tempHealth)
        {
            //took dmg
            print("took dmg");
        }

        if (currentHealth > tempHealth)
        {
            print("healed");
        }

        tempHealth = currentHealth;
    }
}