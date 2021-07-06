
using System;

public class Clip
{
    public Clip(int volume, int maxVolume)
    {
        if (volume < 0)
            throw new ArgumentException("Volume cannot be less than zero.");

        if (maxVolume < 0)
            throw new ArgumentException("Max Volume cannot be less than zero.");

        if (volume > maxVolume)
            throw new ArgumentException("Max Volume cannot be less than current volume.");

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
