using UnityEngine;

public class BulletLauncher : MonoBehaviour, ILauncher
{
    [SerializeField] private Bullet bulletPrefab;

    public void Launch(Weapon weapon)
    {
        var bullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity);
        bullet.Launch(weapon.transform.forward);
    }
}