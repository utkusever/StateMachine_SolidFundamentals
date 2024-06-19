using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaseState : EnemyState
{
    public EnemyChaseState(EnemyStateController stateController) : base(stateController) //actin' like awake func.
    {
    }

    protected override void UpdateState()
    {
        Debug.Log("enemy chase update");
        enemy.EnemyChaseBaseInstance.OnStateUpdate();
    }

    protected override void OnEnter()
    {
        Debug.Log("enemy chase enter");
        enemy.EnemyChaseBaseInstance.OnStateEnter();
    }

    protected override void OnExit()
    {
        Debug.Log("enemy chase exit");
        enemy.EnemyChaseBaseInstance.OnStateExit();
    }
}