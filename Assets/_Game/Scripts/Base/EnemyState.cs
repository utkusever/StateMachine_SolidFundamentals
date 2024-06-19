using UnityEngine;

public class EnemyState : StateUpdateable
{
    protected Enemy enemy;
    protected EnemyStateController stateController;

    public EnemyState(EnemyStateController stateController)
    {
        this.stateController = stateController;
        enemy = this.stateController.GetComponent<Enemy>();
    }
}