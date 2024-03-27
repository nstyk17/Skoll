using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    private PlayerHealth pHealth;
    private HealthHeartBar healthbar;
    
    [SerializeField] private int amountHealed;


    void Start()
    {
        pHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        healthbar = GameObject.Find("HealthHearts").GetComponent<HealthHeartBar>();
    }

    public void Update()
    {
        heal();
        healthbar.DrawHearts();
    }

    public void heal()
    {
        if (Input.GetKeyDown("e"))
        {
            pHealth.Heal(amountHealed);
            Destroy(gameObject);
        }
    }
}
