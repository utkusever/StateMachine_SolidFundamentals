using UnityEngine;

public class Missile : Projectile
{
    private Transform target;

    public void SetTarget(Transform targetTransform)
    {
        target = targetTransform;
    }

    private void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, target.position, speed * Time.deltaTime);
        this.transform.LookAt(target);
    }
}