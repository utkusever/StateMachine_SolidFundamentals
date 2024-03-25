using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretWeapons : MonoBehaviour, IOnPlayerCollide
{
    [SerializeField] private Weapon[] weapons;

    private IWeaponActivator weaponActivatorBullet;
    private IWeaponActivator weaponActivatorMissile;

    void Start()
    {
        weaponActivatorBullet = new WeaponActivator(weapons[0]);
        weaponActivatorMissile = new WeaponActivator(weapons[1]);
        weaponActivatorBullet.DeActivateWeapon();
        weaponActivatorMissile.DeActivateWeapon();
    }

    public void OnPlayerCollide(Collider other)
    {
        weaponActivatorBullet.ActivateWeapon();
        weaponActivatorMissile.ActivateWeapon();
    }

    public void OnPlayerExitCollide(Collider other)
    {
        weaponActivatorBullet.DeActivateWeapon();
        weaponActivatorMissile.DeActivateWeapon();
    }
}