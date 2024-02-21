using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colidable : MonoBehaviour
{
    private Collider2D collider;
    [SerializeField]
    private ContactFilter2D filter;
    private List<Collider2D> collidedObjects =  new List<Collider2D>(1);


    protected virtual void Start()
    {
        collider = GetComponent<Collider2D>();
    }


    protected virtual void Update()
    {
        collider.OverlapCollider(filter, collidedObjects);

        foreach(var i in collidedObjects)
        {
            OnCollided(i.gameObject);
        }
    }

    protected virtual void OnCollided(GameObject collidedObject)
    {
        Debug.Log("Collided with " + collidedObject.name);
    }


    //Collision System Help from: https://www.youtube.com/watch?v=R_DPVlJK8o8
}
