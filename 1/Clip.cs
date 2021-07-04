
using System;

public class Clip
{
    public Clip(int volume, int maxVolume)
    {
        Volume = volume;
        MaxVolume = maxVolume;
    }

    public event Action Empty;

    public event Action BulletGiven;

    public int Volume { get; private set; }

    public int MaxVolume { get; }

    public bool IsEmpty => HasBullets == false;

    private bool HasBullets => Volume > 0;

    public bool TryPickupBullet()
    {
        if(HasBullets)
        {
            Volume--;

            BulletGiven?.Invoke();

            if (HasBullets == false)
                Empty?.Invoke();

            return true;
        }

        Empty?.Invoke();

        return false;
    }
}
