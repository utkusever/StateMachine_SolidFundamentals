using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponActivator : MonoBehaviour, IWeaponActivator
{
    public void ActivateWeapons(Weapon[] weapons)
    {
        foreach (var weapon in weapons)
        {
            weapon.enabled = true;
        }
    }

    public void DeActivateWeapons(Weapon[] weapons)
    {
        foreach (var weapon in weapons)
        {
            weapon.enabled = false;
        }
    }
}