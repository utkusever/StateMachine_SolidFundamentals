using UnityEngine;

public class MovementWithMouse : IMover
{
    private readonly float speed;
    private readonly float turnSpeed;
    private readonly PlayerMovement playerMovement;
    private readonly IInput input;

    public MovementWithMouse(PlayerMovement playerMovement, BaseStat stat, IInput input)
    {
        this.playerMovement = playerMovement;
        this.input = input;
        speed = stat.speed;
        turnSpeed = speed * 100f;
    }

    public void Movement()
    {
        playerMovement.transform.rotation = Quaternion.RotateTowards(playerMovement.transform.rotation,
            input.Direction,
            turnSpeed * Time.deltaTime);
        playerMovement.transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}