using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Idle-Random Wander", menuName = "Enemy Logic/Idle Logic/Random Wander")]
public class EnemyIdleRandomWander : EnemyIdleSOBase
{
    [SerializeField] private float randomMovementRange;
    [SerializeField] private float randomMovementSpeed;
    private Vector3 targetPos;
    private Vector3 direction;

    public override void Init(GameObject gameObject, Enemy enemy)
    {
        base.Init(gameObject, enemy);
    }

    protected override void OnEnter()
    {
        base.OnEnter();
        targetPos = GetRandomPointInCircle();
    }


    protected override void OnExit()
    {
        base.OnExit();
    }

    protected override void UpdateState()
    {
        base.UpdateState();
        enemy.MoveEnemy(targetPos,randomMovementRange);
        if (Vector3.Distance(enemy.transform.position, targetPos) < 0.1f)
        {
            targetPos = GetRandomPointInCircle();
        }
    }

    private Vector3 GetRandomPointInCircle()
    {
        float randX = UnityEngine.Random.Range(0.1f, randomMovementRange);
        float randZ = UnityEngine.Random.Range(0.1f, randomMovementRange);
        Vector3 newPos = new Vector3(randX, 0, randZ);
        return newPos;
    }
}