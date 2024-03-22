using System;
using UnityEngine;

public class InputCheck : IInput
{
    public Quaternion Direction { get; set; }
    public bool HasInput { get; set; }
    private Vector3 firstInput, lastInput;

    public void HandleInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstInput = Input.mousePosition;
            HasInput = true;
        }

        if (Input.GetMouseButton(0))
        {
            lastInput = Input.mousePosition;
            var deltaPos = (lastInput - firstInput).normalized;
            HasInput = lastInput != firstInput;
            CalculateDirection(deltaPos);
        }

        if (Input.GetMouseButtonUp(0))
        {
            HasInput = false;
        }
    }

    private void CalculateDirection(Vector3 deltaPos)
    {
        float x = deltaPos.x;
        float z = deltaPos.y;
        Vector3 newDirection = new Vector3(x, 0f, z);
        Quaternion dir = Quaternion.LookRotation(newDirection, Vector3.up);
        Direction = dir;
    }
}