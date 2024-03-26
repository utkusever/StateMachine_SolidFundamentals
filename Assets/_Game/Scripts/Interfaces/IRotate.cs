using System.Collections;
using UnityEngine;

public interface IRotate
{
    public Transform TransformToRotate { get; set; }
    IEnumerator RotateCoroutine(Transform target);
    void RotateToTarget(Transform target);
}