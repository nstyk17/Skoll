using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject item;
    private Transform player;
    //accessing the player movement script
    private int dropPos;
    public PlayerMovement pm;

   
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (pm.isFlipped)
        {
            dropPos = -2;
        }
        else
        {
            dropPos = 2;
        }

    }

    public void SpawnDroppedItem()
    {
       

        Vector2 playerPos = new Vector2(player.position.x + (dropPos), player.position.y);
        Instantiate(item, playerPos, Quaternion.identity); //so item spawns with zero rotation
    }
}
