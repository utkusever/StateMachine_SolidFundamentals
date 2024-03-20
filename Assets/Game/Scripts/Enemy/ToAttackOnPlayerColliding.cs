using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToAttackOnPlayerColliding : MonoBehaviour, IOnPlayerCollide
{
    [SerializeField] private StateController stateController;

    public void OnPlayerCollide(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            stateController.ChangeState(stateController.AttackState);
        }
    }

    public void OnPlayerExitCollide(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            stateController.ChangeState(stateController.patrolState);
        }
    }
}