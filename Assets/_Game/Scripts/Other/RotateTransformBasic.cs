using System.Collections;
using UnityEngine;

public class RotateTransformBasic : MonoBehaviour, IRotate
{
    public Transform TransformToRotate { get; set; }

    public IEnumerator RotateCoroutine(Transform target)
    {
        while (true)
        {
            yield return null;
            RotateToTarget(target);
        }
    }

    public void RotateToTarget(Transform target)
    {
        var directionToTarget = (target.position - this.TransformToRotate.position).normalized;
        directionToTarget.y = 0;
        Vector3 newDirection =
            Vector3.RotateTowards(TransformToRotate.forward, directionToTarget, 10 * Time.deltaTime, 0f);
        TransformToRotate.rotation = Quaternion.LookRotation(newDirection);
    }
}