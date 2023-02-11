using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable<T>
{
    T Health { get; set; }

    void GetDamage(T damageAmount);

    void Die();
}
