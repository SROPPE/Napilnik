
using System;

public class Weapon
{
    private Damage _damage;
    private Clip _clip;

    public event Action NeedReload;

    public Weapon(Damage damage)
    {
        _damage = damage;
    }

    public void Reload(Clip clip)
    {
        if(_clip != null)
            _clip.Empty -= OnMagEmpty;

        _clip = clip;
        _clip.Empty += OnMagEmpty;

        if (_clip.IsEmpty)
            OnMagEmpty();
    }

    public bool TryFire(IDamageable target)
    {
        if (_clip == null)
            return false;

        if (_clip.TryPickupBullet())
        {
            target.TakeDamage(_damage);
            return true;
        }

        return false;
    }

    private void OnMagEmpty()
    {
        NeedReload?.Invoke();
    }
}
