using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : Colidable
{
    //public GameObject ob;

    [SerializeField] private bool interacted = false;
    [SerializeField] private bool hasReward = false;
    [SerializeField] private bool destroyObject = true;


    [SerializeField] private GameObject slot;
    [SerializeField] private GameObject ob;
    [SerializeField] private GameObject[] rewards;
    private int chosenReward;

    [SerializeField] private int dropPosY = 0;
    [SerializeField] private int dropPosX = 0;

    protected override void OnCollided(GameObject collidedObject)
    {
        //base. accesses the parent's properties
        //base.OnCollided(collidedObject);

        if (Input.GetKey(KeyCode.E))
        {
            if (slot.transform.childCount > 0)
            {
                if (interacted == false)
                {

                    if (slot.transform.GetChild(0).gameObject.name == ob.name) {
                        if (hasReward == true)
                        {
                            interacted = true;
                            Vector2 dropPosition = new Vector2(transform.position.x - dropPosX, transform.position.y - dropPosY);
                            chosenReward = Random.Range(0, rewards.Length);
                            Instantiate(rewards[chosenReward], dropPosition, Quaternion.identity);

                            if (destroyObject == true) Destroy(this.gameObject);
                        }
                    }
                    

                }
            }

            //if (interacted == false)
            //{
            //    interacted = true;
            //}
            //OnInteract();
        }

      
    }

    protected virtual void OnInteract()
    {
        

    }
}
