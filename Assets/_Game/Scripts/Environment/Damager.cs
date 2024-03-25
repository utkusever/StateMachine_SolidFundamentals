using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base.Enemy;
using UnityEngine;

public class Damager : MonoBehaviour, IArea
{
    public void OnCollision(IHealth health)
    {
        health.Health -= 10f;
    }
}