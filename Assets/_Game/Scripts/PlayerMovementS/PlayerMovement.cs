using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IStats stats;
    private IMover mover;
    private IInput input;

    void Start()
    {
        stats = this.GetComponent<IStats>();
        input = new InputCheck();
        mover = new MovementWithMouse(this, stats.BaseStat, input);
    }

    void Update()
    {
        input.HandleInput();
        if (input.HasInput)
        {
            mover.Movement();
        }
        //mover.Movement();
    }
}