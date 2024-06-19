using System;
using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyStateController EnemyStateController;
    public EnemyIdleState EnemyIdleState;
    public EnemyChaseState EnemyChaseState;
    public EnemyAttackState EnemyAttackState;
   

    [SerializeField] private EnemyIdleSOBase enemyIdleSoBase;
    [SerializeField] private EnemyChaseSOBase enemyChaseSoBase;
    [SerializeField] private EnemyAttackSOBase enemyAttackSoBase;
    public EnemyIdleSOBase EnemyIdleBaseInstance { get; set; }
    public EnemyChaseSOBase EnemyChaseBaseInstance { get; set; }
    public EnemyAttackSOBase EnemyAttackBaseInstance { get; set; }

    private void Awake()
    {
        // this wont create new scriptable objects it just creates instances of classes for each enemy
        EnemyIdleBaseInstance = Instantiate(enemyIdleSoBase);
        EnemyChaseBaseInstance = Instantiate(enemyChaseSoBase);
        EnemyAttackBaseInstance = Instantiate(enemyAttackSoBase);

        EnemyIdleState = new EnemyIdleState(EnemyStateController);
        EnemyChaseState = new EnemyChaseState(EnemyStateController);
        EnemyAttackState = new EnemyAttackState(EnemyStateController);
    }

    private void Start()
    {
        EnemyIdleBaseInstance.Init(gameObject, this);
        EnemyChaseBaseInstance.Init(gameObject, this);
        EnemyAttackBaseInstance.Init(gameObject, this);
        EnemyStateController.ChangeState(EnemyIdleState);
    }

    public void MoveEnemy(Vector3 targetPos,float movementSpeed)
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, targetPos, movementSpeed * Time.deltaTime);
    }
}