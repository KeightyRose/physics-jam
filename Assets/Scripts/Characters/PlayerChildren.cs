using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChildren : MonoBehaviour
{
    public Player player;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            player.playerHealth -= 1;
        }
    }
}
