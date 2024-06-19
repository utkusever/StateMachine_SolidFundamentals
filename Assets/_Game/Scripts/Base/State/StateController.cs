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

    protected virtual void Update()
    {
        if (currentStateUpdateable != null)
        {
            currentStateUpdateable.OnStateUpdate();
        }
    }

    public virtual void ChangeState(State newState)
    {
        if (currentState != null)
        {
            currentState.OnStateExit();
        }

        currentStateUpdateable = newState as StateUpdateable;
        currentState = (State)newState;
        newState.OnStateEnter();
    }
}