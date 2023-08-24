using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceSlider : MonoBehaviour
{

    public Slider forceSlider;

    void Start()
    {
        forceSlider.maxValue = 10;
        forceSlider.minValue = 1;

        forceSlider = GetComponent<Slider>();
        forceSlider.value = 10;
    }

    
    void Update()
    {
        
    }
}
