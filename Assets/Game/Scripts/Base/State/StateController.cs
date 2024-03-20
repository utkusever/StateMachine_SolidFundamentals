using System;
using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base;
using UnityEngine;
using UnityEngine.Serialization;

public class StateController : MonoBehaviour
{
    private State currentState;
    private StateUpdateable currentStateUpdateable;
    public IdleState idleState = new();
    public PatrolState patrolState = new();
    public ChaseState chaseState = new();
    public AttackState AttackState = new();

    private void Start()
    {
        //  ChangeState(idleState);
    }

    private void Update()
    {
        if (currentStateUpdateable != null)
        {
            currentStateUpdateable.OnStateUpdate();
        }
    }

    public void ChangeState(State newState)
    {
        if (currentState != null)
        {
            currentState.OnStateExit();
        }

        currentStateUpdateable = newState as StateUpdateable;
        currentState = (State)newState;
        newState.OnStateEnter(this);
    }
}