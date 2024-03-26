using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckers : PlayerChecker
{
    private IOnPlayerCollide[] onPlayerCollides;

    protected override void Start()
    {
        onPlayerCollides = this.GetComponents<IOnPlayerCollide>();
    }

    protected override void OnPlayerEnter(Collider other)
    {
        foreach (var collide in onPlayerCollides)
        {
            collide.OnPlayerCollide(other);
        }
    }

    protected override void OnPlayerExit(Collider other)
    {
        foreach (var collide in onPlayerCollides)
        {
            collide.OnPlayerExitCollide(other);
        }
    }
}