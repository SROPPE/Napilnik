
using System;

public class Health : IDamageable
{
    public int Amount { get; private set; }

    public Health(int amount)
    {
        if (amount < 0)
            throw new ArgumentException("Health cannot be less than zero.");

        Amount = amount;
    }

    public void TakeDamage(Damage damage)
    {
        if (damage.Value < 0)
            throw new ArgumentException("Damage cannot be less than zero.");

        Amount -= damage.Value;
        
        if (Amount < 0)
            Amount = 0;
    }
}
