using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Base;
using UnityEngine;

public class ChaseState : StateUpdateable
{
    protected override void UpdateState()
    {
        Debug.Log("chasing player");
    }
}