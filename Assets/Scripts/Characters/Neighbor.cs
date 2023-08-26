using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Neighbor : MonoBehaviour
{
    public Slider neighborHealthBar;

    //private CircleCollider2D headCollider;

    void Start()
    {
        neighborHealthBar.maxValue = 3;
        neighborHealthBar.minValue = 0;
        neighborHealthBar.value = 3;
    }

    
    void Update()
    {
        Collider2D[] childColliders = GetComponentsInChildren<Collider2D>();

        foreach (Collider2D childCollider in childColliders)
        {
            if (childCollider != null && childCollider != GetComponent<Collider2D>())
            {
                Debug.Log("This child has a collider: " + childCollider.name);
            }
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Hit head");
        }
    }

    Children scripts calls from the parent the drecrease health 
    transform.parent returns parent game object 
    transform.parent.gameobject.getcomponent<health>
        */

}
