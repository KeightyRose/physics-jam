using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrictionSlider : MonoBehaviour
{
    public Slider frictionSlider;

    public PhysicsMaterial2D physicsMat;

    void Start()
    {
        frictionSlider = GetComponent<Slider>();

        frictionSlider.minValue = 0.1f;
        frictionSlider.maxValue = 1.5f;

        physicsMat.bounciness = frictionSlider.value = .5f;
    }

    void Update()
    {
        physicsMat.friction = frictionSlider.value;
    }
}
