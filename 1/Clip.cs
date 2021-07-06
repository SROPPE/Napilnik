
using System;

public class Clip
{
    public Clip(int volume, int maxVolume)
    {
        Volume = volume;
        MaxVolume = maxVolume;
    }

    public int Volume { get; private set; }

    public int MaxVolume { get; }

    public bool IsEmpty => HasBullets == false;

    private bool HasBullets => Volume > 0;

    public void TakeBullet()
    {
        if (IsEmpty)
            throw new InvalidOperationException("No bullets in the clip.");
     
        Volume--;
    }
}
