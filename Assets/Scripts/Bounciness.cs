using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bounciness : MonoBehaviour
{

    public InputField bouncyInput;
    public float bounciness;

    public PhysicsMaterial2D ballMat;
    public Rigidbody2D rb;

    void Start()
    {
        //ballMat = this.GetComponent<PhysicsMaterial2D>();

        rb.sharedMaterial = ballMat;
    }

    
    void Update()
    {
        
    }

    public void SetBounciness()
    {
        bounciness = ParseFloat(bouncyInput, bounciness);
        Debug.Log(bounciness);

        ballMat.bounciness = bounciness;
    }

    private float ParseFloat(InputField inputField, float bouncy)
    {

        float.TryParse(inputField.text, out float result); bouncy = result;

        return bouncy;
    }
}
