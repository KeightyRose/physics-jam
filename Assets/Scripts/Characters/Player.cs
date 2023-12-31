using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float playerHealth = 3;

    public Slider playerHealthSlider;

    void Start()
    {
        playerHealthSlider.minValue = 0;
        playerHealthSlider.maxValue = 3;
        playerHealthSlider.value = playerHealth;
    }

    
    void Update()
    {
        if(playerHealth <= 0)
        {
            Debug.Log("game over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
