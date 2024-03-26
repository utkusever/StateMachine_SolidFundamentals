using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChecker : MonoBehaviour
{
    private IOnPlayerCollide onPlayerCollide;

    protected virtual void Start()
    {
        onPlayerCollide = this.GetComponent<IOnPlayerCollide>();
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnPlayerEnter(other);
        }
    }

    protected virtual void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnPlayerExit(other);
        }
    }

    protected virtual void OnPlayerEnter(Collider other)
    {
        onPlayerCollide.OnPlayerCollide(other);
    }


    protected virtual void OnPlayerExit(Collider other)
    {
        onPlayerCollide.OnPlayerExitCollide(other);
    }
}