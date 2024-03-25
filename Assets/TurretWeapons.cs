using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretWeapons : MonoBehaviour, IOnPlayerCollide
{
    [SerializeField] private Weapon[] weapons;

    private IWeaponActivator weaponActivator;

    void Start()
    {
        weaponActivator = this.GetComponent<IWeaponActivator>();
        weaponActivator.DeActivateWeapons(weapons);
    }

    public void OnPlayerCollide(Collider other)
    {
        weaponActivator.ActivateWeapons(weapons);
    }

    public void OnPlayerExitCollide(Collider other)
    {
        weaponActivator.DeActivateWeapons(weapons);
    }
}