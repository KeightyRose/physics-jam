using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GravitySlider : MonoBehaviour
{

    public Slider gravitySlider;

    void Start()
    {
        gravitySlider = GetComponent<Slider>();

        gravitySlider.minValue = -1.5f;
        gravitySlider.maxValue = 1.5f;

        gravitySlider.value = -1f;
    }


    
    void Update()
    {
        
    }

    /*public void OnGravitySliderChanged()
    {
        Physics2D.gravity = new Vector3(0, -gravitySlider.value);
    }*/
}
