using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackOnPlayerCollide : MonoBehaviour, IOnPlayerCollide
{
    [SerializeField] private Enemy enemy;

    public void OnPlayerCollide(Collider other)
    {
        enemy.EnemyStateController.ChangeState(enemy.EnemyAttackState);
    }

    public void OnPlayerExitCollide(Collider other)
    {
        enemy.EnemyStateController.ChangeState(enemy.EnemyChaseState);
    }
}