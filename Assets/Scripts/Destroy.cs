using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{


    void Start()
    {
        Invoke("DestroyThis", 12f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Neighbor"))
        {

            GameObject.Destroy(gameObject);
        }
    }

    private void DestroyThis()
    {
        GameObject.Destroy(gameObject);
    }
}
