using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BouncySlider : MonoBehaviour
{
    public Slider bouncySlider;

    public PhysicsMaterial2D bouncinessMat;

    void Start()
    {
        bouncySlider = GetComponent<Slider>();

        bouncySlider.minValue = 0.1f;
        bouncySlider.maxValue = 1.5f;

        bouncinessMat.bounciness = bouncySlider.value = .5f;
    }

    void Update()
    {
        bouncinessMat.bounciness = bouncySlider.value;
    }
}
