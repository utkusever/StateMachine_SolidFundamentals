using Game.Scripts.Base;

public class EnemyStateController : StateController
{
    public EnemyState CurrentState { get; set; }

    public void Init(EnemyState startingState)
    {
        CurrentState = startingState;
        CurrentState.OnStateEnter();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override void ChangeState(State newState)
    {
        base.ChangeState(newState);
    }
}