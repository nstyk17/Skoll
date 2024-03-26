using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health; 

    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Debug.Log("Health Below Zero");
        }
    }

    public void Heal(int amount)
    {

        health += amount;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
