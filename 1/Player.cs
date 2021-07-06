using System;

public class Player : IDamageable
{
    private Health _health;

    public Player(Health health)
    {
        _health = health ?? throw new ArgumentNullException(nameof(health));
    }

    public void TakeDamage(Damage damage)
    {
        _health.TakeDamage(damage);
    }
}
