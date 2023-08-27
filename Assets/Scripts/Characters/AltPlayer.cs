using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AltPlayer : MonoBehaviour
{
    public Slider healthSlider;

    private float _health;

    void Start()
    {
        healthSlider.minValue = 0;
        healthSlider.maxValue = 3;

        healthSlider.value = _health = 3;
    }

    
    void Update()
    {
        if(_health <= 0)
        {
            Debug.Log("game over");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            _health -= 1;
            healthSlider.value = _health;
        }
    }
}
