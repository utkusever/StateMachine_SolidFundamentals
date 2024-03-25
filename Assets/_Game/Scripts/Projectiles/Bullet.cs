using UnityEngine;

public class Bullet : Projectile
{
    private Vector3 direction;

    public void Launch(Vector3 launcherForward)
    {
        direction = launcherForward;
        this.transform.forward = direction;
    }

    private void Update()
    {
        transform.Translate(direction * (Time.deltaTime * speed), Space.World);
    }

    protected override void Destroy()
    {
    }
}