using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : Colidable
{
    //public GameObject ob;

    private bool interacted = false;
    [SerializeField] private bool destroyObject = true;
    [SerializeField] private GameObject slot;
    [SerializeField] private GameObject ob;

    protected override void OnCollided(GameObject collidedObject)
    {
        //base. accesses the parent's properties
        //base.OnCollided(collidedObject);

        if (Input.GetKey(KeyCode.E))
        {
            if (slot.transform.childCount > 0)
            {
                if (slot.transform.GetChild(0).gameObject.name == ob.name) {
                    if (destroyObject == true)
                    {
                        Destroy(this.gameObject);
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
