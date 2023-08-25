using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchController : MonoBehaviour
{
    public TrajectoryLine trajectoryLine;
    //private BigHairyBalls bigHairyBalls;

    public Rigidbody2D projectilePrefab;
    public Transform spawnPoint;

    private ForceSlider forceSlider;
    private GravitySlider gravitySlider;
    private MassSlider massSlider;
    //private VelocitySlider velocitySlider;

    private void Start()
    {
        forceSlider = FindObjectOfType<ForceSlider>();
        gravitySlider = FindObjectOfType<GravitySlider>();
        massSlider = FindObjectOfType<MassSlider>();
        //velocitySlider = FindObjectOfType<VelocitySlider>();
    }

    public void YeetThisBitch()
    {
        LaunchProjectile(trajectoryLine.endPoint - trajectoryLine.startPoint);

    }

    private void LaunchProjectile(Vector2 direction)
    {
        Rigidbody2D currentProjectile = Instantiate(projectilePrefab, spawnPoint.position, Quaternion.identity).GetComponent<Rigidbody2D>();

        float force = forceSlider.forceSlider.value;
        float mass = massSlider.massSlider.value;
        float gravityScale = gravitySlider.gravitySlider.value;
        float velocity = 1;

        direction = direction.normalized;

        Debug.Log(direction);

        currentProjectile.mass = mass;
        currentProjectile.gravityScale = gravityScale;
        currentProjectile.AddForce(direction * force, ForceMode2D.Impulse);
    }

}
