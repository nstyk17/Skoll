using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
    public int i;
   
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    private void Update()
    {
        
        if (transform.childCount <= 0)
        {       
            inventory.isFull[i] = false;
        }else if (transform.childCount > 0)
        {
            //check if there is a child
            if (Input.GetKeyDown("q"))
            {
                DropItem();
            }
        }
    }


    public void DropItem()
    {
        //run for every child in the slot img
        foreach (Transform child in transform)
        {
            child.GetComponent<Spawn>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
        }
    }


    //Help from: https://www.youtube.com/watch?v=OG7vHstkZqM
}
