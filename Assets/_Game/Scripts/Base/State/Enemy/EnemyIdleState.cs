using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleState : EnemyState
{
    public EnemyIdleState(EnemyStateController stateController) : base(stateController)
    {
    }

    protected override void UpdateState()
    {
        Debug.Log("enemy idle update");
        enemy.EnemyIdleBaseInstance.OnStateUpdate();
    }

    protected override void OnEnter()
    {
        Debug.Log("enemy idle enter");
        enemy.EnemyIdleBaseInstance.OnStateEnter();
    }

    protected override void OnExit()
    {
        Debug.Log("enemy idle exit");
        enemy.EnemyIdleBaseInstance.OnStateExit();
    }
}