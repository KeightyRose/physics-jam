using UnityEngine;

public class LaunchController : MonoBehaviour
{
    private TrajectoryLine trajectoryLine;
    private BigHairyBalls bigHairyBalls;

    public Rigidbody2D projectilePrefab;
    public Transform spawnPoint;

    public void YeetThisBitch(Vector3 direction)
    {
        Rigidbody2D currentProjectile = Instantiate(projectilePrefab, spawnPoint.position, Quaternion.identity);

        LaunchProjectile(trajectoryLine.endPoint - trajectoryLine.startPoint);

        
    }

    private void LaunchProjectile(Vector3 direction)
    {
        bigHairyBalls.Launch();
    }

}
