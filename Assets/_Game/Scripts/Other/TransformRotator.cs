using System;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotator : MonoBehaviour, IOnPlayerCollide
{
    [SerializeField] private Transform objectToRotate;

    private IRotate rotate;

    private void Start()
    {
        rotate = this.GetComponent<IRotate>();
        rotate.TransformToRotate = objectToRotate;
    }

    public void OnPlayerCollide(Collider other)
    {
        StartCoroutine(rotate.RotateCoroutine(other.transform));
    }

    public void OnPlayerExitCollide(Collider other)
    {
        StopAllCoroutines();
        
    }
}