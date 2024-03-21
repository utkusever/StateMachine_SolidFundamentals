using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float coolDown;
    private float timer;
    private ILauncher launcher;

    private void Start()
    {
        timer = 0;
        launcher = this.GetComponent<ILauncher>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (CanFire())
        {
            ResetTimer();
            FireWeapon();
        }
    }

    private bool CanFire()
    {
        return timer > coolDown;
    }

    private void ResetTimer()
    {
        timer = 0;
    }

    private void FireWeapon()
    {
        launcher.Launch(this);
    }
}