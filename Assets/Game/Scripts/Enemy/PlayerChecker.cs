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
        if (other.CompareTag("Player"))
        {
            onPlayerCollide.OnPlayerCollide(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onPlayerCollide.OnPlayerExitCollide(other);
        }
    }
}