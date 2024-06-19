using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleSOBase : ScriptableObject
{
    protected Enemy enemy;
    protected Transform transform;
    protected GameObject gameObject;
    protected Transform playerTransform;

    public virtual void Init(GameObject gameObject, Enemy enemy)
    {
        this.gameObject = gameObject;
        transform = gameObject.transform;
        this.enemy = enemy;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void OnStateEnter()
    {
        OnEnter();
    }

    protected virtual void OnEnter()
    {
    }

    public void OnStateExit()
    {
        //always work
        OnExit();
    }

    protected virtual void OnExit()
    {
        //overridden
    }

    public void OnStateUpdate()
    {
        UpdateState();
    }

    protected virtual void UpdateState()
    {
    }
}