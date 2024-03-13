using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemButton;
    [SerializeField] private bool playerOverlap;
    private GameObject inventoryImg;
    private string objectName;


    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        playerOverlap = false;
    }

    void Update()
    {
        if (playerOverlap == true && Input.GetKeyDown("e"))
        {
            addToInventory();
        }

    }

    private void addToInventory()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                inventory.isFull[i] = true;
                inventoryImg = Instantiate(itemButton, inventory.slots[i].transform, false);
                objectName = itemButton.name;
                inventoryImg.name = objectName;
                Destroy(gameObject);
                break;
            }
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            playerOverlap = true;
        }


    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerOverlap = false;
        }
    }
}
