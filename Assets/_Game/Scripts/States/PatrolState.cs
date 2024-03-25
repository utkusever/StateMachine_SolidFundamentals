using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base;
using UnityEngine;

public class PatrolState : State
{
    protected override void OnEnter()
    {
        Debug.Log("entered patrol");
    }

    protected override void OnExit()
    {
        Debug.Log("exited patrol");
    }
}