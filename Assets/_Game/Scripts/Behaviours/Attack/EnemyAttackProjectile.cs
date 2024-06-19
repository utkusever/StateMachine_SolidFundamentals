using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attack-Single Projectile", menuName = "Enemy Logic/Attack Logic/Single Projectile")]
public class EnemyAttackProjectile : EnemyAttackSOBase
{
    private float timer;
    [SerializeField] private float shotsCooldown;

    public override void Init(GameObject gameObject, Enemy enemy)
    {
        base.Init(gameObject, enemy);
    }

    protected override void OnEnter()
    {
        base.OnEnter();
    }

    protected override void OnExit()
    {
        base.OnExit();
    }

    protected override void UpdateState()
    {
        base.UpdateState();
        if (timer > shotsCooldown)
        {
            timer = 0f;
            Debug.Log("ATTACK");
        }

        timer += Time.deltaTime;
    }
}