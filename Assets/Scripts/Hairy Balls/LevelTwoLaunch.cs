using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTwoLaunch : MonoBehaviour
{
    public TrajectoryLine trajectoryLine;
    //private BigHairyBalls bigHairyBalls;

    public Rigidbody2D projectilePrefab;
    public Transform spawnPoint;

    [SerializeField] private ForceSlider forceSlider;
    [SerializeField] private GravitySlider gravitySlider;
    [SerializeField] private MassSlider massSlider;
    [SerializeField] private BouncySlider bouncySlider;
 
    //private VelocitySlider velocitySlider;

    private void Start()
    {
        forceSlider = FindObjectOfType<ForceSlider>();
        gravitySlider = FindObjectOfType<GravitySlider>();
        massSlider = FindObjectOfType<MassSlider>();
        bouncySlider = FindObjectOfType<BouncySlider>();
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
        //float velocity = 2;

        direction = direction.normalized;

        Debug.Log(direction);

        currentProjectile.mass = mass;
        currentProjectile.gravityScale = gravityScale;

        currentProjectile.GetComponent<Rigidbody2D>().sharedMaterial.bounciness = bouncySlider.bouncinessMat.bounciness;


        currentProjectile.AddForce(direction * force, ForceMode2D.Impulse);
    }

}
