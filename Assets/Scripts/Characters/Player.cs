using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float playerHealth = 3;

    public Slider playerHealthSlider;

    void Start()
    {
        playerHealthSlider.minValue = 0;
        playerHealthSlider.maxValue = 3;
        playerHealthSlider.value = 3;
    }

    
    void Update()
    {
        if(playerHealth <= 0)
        {
            Debug.Log("game over");
        }
    }
}
