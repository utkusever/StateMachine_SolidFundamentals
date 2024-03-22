using UnityEngine;

public interface IInput
{
    public Quaternion Direction { get; set; }
    public bool HasInput { get; set; }
    void HandleInput();
}