namespace Game.Scripts.Base.Enemy
{
    public interface IHealth
    {
        public float Health { get; set; }
        public bool IsDead { get; set; }
    }
}