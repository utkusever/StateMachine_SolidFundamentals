using System;
using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base.Enemy;
using UnityEngine;

public class PlayerAreaController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IArea area))
        {
            area.OnCollision(this.GetComponent<IHealth>());
        }
    }
}