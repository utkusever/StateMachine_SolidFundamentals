using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseOnPlayerCollide : MonoBehaviour, IOnPlayerCollide
{
    [SerializeField] private Enemy enemy;

    public void OnPlayerCollide(Collider other)
    {
        enemy.EnemyStateController.ChangeState(enemy.EnemyChaseState);
    }

    public void OnPlayerExitCollide(Collider other)
    {
        enemy.EnemyStateController.ChangeState(enemy.EnemyIdleState);
    }
}