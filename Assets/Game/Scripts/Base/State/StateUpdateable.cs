using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base;
using UnityEngine;

public class StateUpdateable : State
{
    public void OnStateUpdate()
    {
        Debug.Log("base onstate updating");
        UpdateState();
    }

    protected virtual void UpdateState()
    {
        Debug.Log("base state updating");
    }
}