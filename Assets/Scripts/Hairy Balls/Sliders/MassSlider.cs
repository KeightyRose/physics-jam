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
        massSlider.value = 1f;
    }

    
    void Update()
    {
        
    }
}
