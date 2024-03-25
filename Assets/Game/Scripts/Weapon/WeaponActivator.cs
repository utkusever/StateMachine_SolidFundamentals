using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponActivator : IWeaponActivator
{
    private readonly Weapon weapon;

    public WeaponActivator(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public void ActivateWeapon()
    {
        weapon.enabled = true;
    }

    public void DeActivateWeapon()
    {
        weapon.enabled = false;
    }
}