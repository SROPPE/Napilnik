using System;

public class Weapon
{
    private readonly Damage _damage;

    private Clip _clip;

    public event Action NeedReload;

    public Weapon(Clip clip, Damage damage)
    {
        _damage = damage;
        SetClip(clip);
    }

    public bool TryFire(IDamageable target)
    {
        try
        {
            _clip.TakeBullet();
            target.TakeDamage(_damage);

            return true;
        }
        catch
        {
            NeedReload?.Invoke();

            return false;
        }
    }

    public void Reload(Clip clip)
    {
        SetClip(clip);

        if (_clip.IsEmpty)
            NeedReload?.Invoke();
    }

    private void SetClip(Clip clip)
    {
        _clip = clip ?? throw new NullReferenceException("Clip cannot be null.");
    }
}
