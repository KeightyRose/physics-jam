using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassSlider : MonoBehaviour
{
    public Slider massSlider;

    void Start()
    {
        massSlider = GetComponent<Slider>();
        massSlider.value = 1.3f;

        massSlider.minValue = 0.3f;
        massSlider.maxValue = 2;
    }

    
    void Update()
    {
        
    }
}
