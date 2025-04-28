using UnityEngine;

public abstract class WeaponShootBase:MonoBehaviour
{
    [SerializeField]protected float _damage;
    [SerializeField]protected float _maxLength;

    public virtual void Shoot() { }
}
