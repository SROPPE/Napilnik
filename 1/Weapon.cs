
using System;

public class Weapon
{
    private Damage _damage;
    private Clip _clip;

    public event Action NeedReload;

    public Weapon(Clip clip, Damage damage)
    {
        _damage = damage;
        SetClip(clip);
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

    public bool TryFire(IDamageable target)
    {
        try
        {
            _clip.TakeBullet();
            target.TakeDamage(_damage);

            return true;
        }
        catch (Exception)
        {
            NeedReload?.Invoke();

            return false;         
        }
    }
}
