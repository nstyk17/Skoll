using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : InteractableObject
{

    //plans:
    //    - make this extend the interactable
    //    - use the collision and button "e" setup and then trigger the inventory assesment

    private Inventory inventory;
    public GameObject itemImg;

    // Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    protected override void OnInteract()
    {

        Debug.Log("got here");

            for(int i = 0; i< inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemImg, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }      

    }
}
