using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretWeapon : MonoBehaviour, IOnPlayerCollide
{
    [SerializeField] private Weapon weapon;

    private IWeaponActivator weaponActivator;

    void Start()
    {
        weaponActivator = new WeaponActivator(weapon);
        weaponActivator.DeActivateWeapon();
    }

    public void OnPlayerCollide(Collider other)
    {
        weaponActivator.ActivateWeapon();
    }

    public void OnPlayerExitCollide(Collider other)
    {
        weaponActivator.DeActivateWeapon();
    }
}