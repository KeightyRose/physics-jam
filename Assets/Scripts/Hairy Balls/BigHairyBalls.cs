using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigHairyBalls : MonoBehaviour
{
    public Rigidbody2D rb;

    private ForceSlider forceSlider;
    private GravitySlider gravitySlider;
    private MassSlider massSlider;
    private VelocitySlider velocitySlider;

    public GameObject spawnPoint;

    private void Awake()
    {
        spawnPoint = GameObject.Find("Spawn");

        forceSlider = FindObjectOfType<ForceSlider>();
        gravitySlider = FindObjectOfType<GravitySlider>();
        massSlider = FindObjectOfType<MassSlider>();
        velocitySlider = FindObjectOfType<VelocitySlider>();
    }

    void Start()
    {
        Physics2D.gravity = new Vector3(0, 0, 0);
        rb.mass = 0;
    }

    void Update()
    {
        
    }

    public void Launch()
    {
        float force = forceSlider.forceSlider.value;
        float mass = massSlider.massSlider.value;
        float velocity = velocitySlider.velocitySlider.value;
        Vector3 launchDirection = spawnPoint.transform.forward * velocity;

        rb.mass = mass;
        rb.AddForce(launchDirection * force, ForceMode2D.Impulse);
    }

    public void OnGravitySliderChanged()
    {
        Physics2D.gravity = new Vector3(0, -gravitySlider.gravitySlider.value);
    }
}
