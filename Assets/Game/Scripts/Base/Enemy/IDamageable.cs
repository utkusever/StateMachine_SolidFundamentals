namespace Game.Scripts.Base.Enemy
{
    public interface IDamageable
    {
        void ApplyDamage(IHealth health, float value);
    }
}