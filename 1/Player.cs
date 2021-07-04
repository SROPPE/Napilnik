public class Player : IDamageable
{
    private Health _health;

    public int HealthAmount => _health.Amount;

    public Player(Health health)
    {
        _health = health;
    }

    public void TakeDamage(Damage damage)
    {
        _health.TakeDamage(damage);
    }
}
