using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : EnemyState
{
    protected override void UpdateState()
    {
        Debug.Log("enemy attack update");
        enemy.EnemyAttackBaseInstance.OnStateUpdate();
    }

    protected override void OnEnter()
    {
        Debug.Log("enemy attack enter");
        enemy.EnemyAttackBaseInstance.OnStateEnter();
    }

    protected override void OnExit()
    {
        Debug.Log("enemy attack exit");
        enemy.EnemyAttackBaseInstance.OnStateExit();
    }


    public EnemyAttackState(EnemyStateController stateController) : base(stateController)
    {
    }
}