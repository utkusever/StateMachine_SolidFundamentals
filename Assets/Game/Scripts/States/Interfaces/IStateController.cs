using Game.Scripts.Base;

public interface IStateController
{
    public StateController StateController { get; set; }
    void ChangeState(StateController stateController);
}