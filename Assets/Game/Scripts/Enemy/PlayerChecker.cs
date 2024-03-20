using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChecker : MonoBehaviour
{
    private IOnPlayerCollide onPlayerCollide;
    private void Start()
    {
        onPlayerCollide = this.GetComponent<IOnPlayerCollide>();
    }

    private void OnTriggerEnter(Collider other)
    {
        onPlayerCollide.OnPlayerCollide(other);
    }

    private void OnTriggerExit(Collider other)
    {
        onPlayerCollide.OnPlayerExitCollide(other);
    }
}