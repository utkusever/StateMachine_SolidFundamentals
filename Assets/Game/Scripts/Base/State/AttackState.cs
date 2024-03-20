using UnityEngine;

public class AttackState : StateUpdateable
{
    protected override void OnEnter()
    {
        Debug.Log("Entered Att State");
    }

    protected override void OnExit()
    {
        Debug.Log("Exited Att State");
    }

    protected override void UpdateState()
    {
        Debug.Log("Update Att State");
    }
}