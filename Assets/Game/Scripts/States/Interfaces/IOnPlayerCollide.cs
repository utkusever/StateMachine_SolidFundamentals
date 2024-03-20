using UnityEngine;

internal interface IOnPlayerCollide
{
    void OnPlayerCollide(Collider other);
    void OnPlayerExitCollide(Collider other);
}