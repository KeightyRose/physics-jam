using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyThis", 12f);
    }

    void Update()
    {
        
    }

    private void DestroyThis()
    {
        GameObject.Destroy(gameObject);
    }
}
