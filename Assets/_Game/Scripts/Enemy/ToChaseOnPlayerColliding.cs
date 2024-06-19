using UnityEngine;

internal class ToChaseOnPlayerColliding : MonoBehaviour, IOnPlayerCollide
{
    [SerializeField] private StateController stateController;

    public void OnPlayerCollide(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          //  stateController.ChangeState(stateController.chaseState);
        }
    }

    public void OnPlayerExitCollide(Collider other)
    {
        if (other.CompareTag("Player"))
        {
         //   stateController.ChangeState(stateController.patrolState);
        }
    }
}