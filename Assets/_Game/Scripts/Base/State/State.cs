using UnityEngine;

namespace Game.Scripts.Base
{
    public abstract class State
    {
        protected StateController stateController;

        public void OnStateEnter(StateController stateController)
        {
            this.stateController = stateController;
            Debug.Log("base state enter");
            OnEnter();
        }

        protected virtual void OnEnter()
        {
        }

        // public void OnStateUpdate()
        // {
        //     Debug.Log("base onstate updating");
        //     UpdateState();
        // }
        //
        // protected virtual void UpdateState()
        // {
        //     Debug.Log("base state updating");
        // }

        public void OnStateExit()
        {
            //always work
            OnExit();
        }

        protected virtual void OnExit()
        {
            //overridden
            Debug.Log("base state exit");
        }
    }
}