using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyDialogue : MonoBehaviour
{

    private InteractableObject cage;
    private Dialogue lines;

    void Start()
    {
        cage = GameObject.Find("Cage").GetComponent<InteractableObject>();
        lines = GetComponent<Dialogue>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cage.interacted == false)
        {
            lines.dialogue[0] = "Greetings Skoll. I am in need of your assistance.";
            lines.dialogue[1] = "I've gotten trapped in this cage.";
            lines.dialogue[2] = "There is a key somewhere around here that opens it. I believe it is in one of the chests.";
            lines.dialogue[3] = "Please... ";
            lines.dialogue[4] = "Release me";
        }
        else if(cage.interacted == true)
        {
            lines.dialogue[0] = "Thank you brave hero";
            lines.dialogue[1] = "You've freed my from my cage";
            lines.dialogue[2] = "I am in your debt";
            lines.dialogue[3] = "I will help you for the rest of your journey";
            lines.dialogue[4] = "a fairy doesn't forget it's debts";
        }
        
    }
}
