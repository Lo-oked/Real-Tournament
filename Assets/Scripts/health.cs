using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int Health;
    public int maxHealth;


    void Start()
    {
        if (Health >= 0) Health = maxHealth;
    }
    public void Damage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
