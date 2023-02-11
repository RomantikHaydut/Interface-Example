using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamagable<float>, IHealable<int>
{
    private float _health = 100;

    public float Health
    {
        get => _health; 

        set { _health = value; }
    }

    public void Die()
    {
        _health= 0;
        print("Player Died!");
    }

    public void GetDamage(float damageAmount)
    {
        _health -= damageAmount;

        if (_health <= 0)
            Die();
    }

    public void GetHeal(int healAmount)
    {
        _health += healAmount;
    }
}
