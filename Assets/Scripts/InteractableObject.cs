using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : Colidable
{
    //public GameObject ob;

    private bool interacted = false;

    protected override void OnCollided(GameObject collidedObject)
    {
        //base. accesses the parent's properties
        //base.OnCollided(collidedObject);

        if (Input.GetKey(KeyCode.E))
        {

            Destroy(collidedObject);
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
