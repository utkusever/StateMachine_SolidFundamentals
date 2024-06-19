using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Chase-Direct Chase", menuName = "Enemy Logic/Chase Logic/Direct Chase")]
public class EnemyChaseDirectToPlayer : EnemyChaseSOBase
{
    [SerializeField] private float movementSpeed;


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
        enemy.MoveEnemy(playerTransform.position, movementSpeed);
    }
}