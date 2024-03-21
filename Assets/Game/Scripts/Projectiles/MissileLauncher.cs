using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviour, ILauncher
{
    [SerializeField] private Missile missilePrefab;
    [SerializeField] private float selfDestructTime;

    public void Launch(Weapon launcher)
    {
        var missile = Instantiate(missilePrefab, this.transform.position, Quaternion.identity);
        missile.SetTarget(GetTarget());
    }

    private Transform GetTarget()
    {
        return FindObjectOfType<Player>().transform;
    }
}