using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private PlayerHealth pHealth;
    private HealthHeartBar healthbar;
    private bool takeDmg;

    [SerializeField] private int amountDamage;


    void Start()
    {
        pHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        healthbar = GameObject.Find("HealthHearts").GetComponent<HealthHeartBar>();

        takeDmg = false;
}

    public void Update()
    {
        healthbar.DrawHearts();
    }

    public void damage()
    {
      
        pHealth.TakeDamage(amountDamage);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(takeDmg == false && other.CompareTag("Player"))
        {
            takeDmg = true;
            damage();
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        takeDmg = false;
    }
}
