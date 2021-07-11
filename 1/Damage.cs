using System;

public struct Damage
{
    public int Value { get; }

    public Damage(int amount)
    {
        if (amount < 0)
            throw new ArgumentException("Damage cannot be less than zero.");

        Value = amount;
    }
}
