using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable<int>
{
    private int _health = 100;

    public int Health
    {
        get => _health;

        set { _health = value; }
    }

    public void GetDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
            Die();
    }

    public void Die()
    {
        _health = 0;

        print("Enemy Died!!!");

    }
}
