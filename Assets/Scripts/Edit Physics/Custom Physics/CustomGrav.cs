using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrav : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2d;
    private Vector2 gravityForce = Vector2.zero;
    void Start()
    {
        rb2d= GetComponent<Rigidbody2D>();
        rb2d.gravityScale= 0f;
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.AddForce(gravityForce * rb2d.mass);
    }

    public void changeGravity(Vector2 gravIn)
    {
       gravityForce = gravIn;

    }
}
