using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VelocitySlider : MonoBehaviour
{
    public Slider velocitySlider;

    void Start()
    {
        velocitySlider = GetComponent<Slider>();

        velocitySlider.maxValue = 15;
        velocitySlider.minValue = 1;

        velocitySlider.value = 5;
    }

    void Update()
    {
        
    }
}
