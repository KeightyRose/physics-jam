using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField] Transform projectilePrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] LineRenderer lineRenderer;

    [SerializeField] float launchForce = 1.5f;
    [SerializeField] float trajectoryTimeStep = 0.05f;
    [SerializeField] int trajectoryStepCount = 15;

    Vector2 velocity, startMousePos, currentMousePos;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Records the startMousePos in world space using cam.main.screentoworldpoint method - will be used to calculate velocity for the projectile.
            startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            //If mouse button is held down it updates the current mouse pos in world space using cam.main.screentoworldpoint method
            currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            velocity = (startMousePos - currentMousePos) * launchForce;

            DrawTrajectory();
        }

        if (Input.GetMouseButtonUp(0))
        {
            Fireball();
        }
    }

    private void DrawTrajectory()
    {
        //Store the points along the curve in an array
        Vector3[] positions = new Vector3[trajectoryStepCount];

        //Use a for loop for each point to calculate its pos.
        for(int i = 0; i < trajectoryStepCount; i++)
        {
            //Calculate the time elapsed since the projectile was launched
            float t = i * trajectoryTimeStep;

            //Calc the pos of the proj at any given time and convert the pos to a vector 3 and add it to the pos array.
            Vector3 pos = (Vector2)spawnPoint.position + velocity * t + 0.5f * Physics2D.gravity * t * t;

            positions[i] = pos;
        }

        //Set position count of line rendered to the num of positions in the "list" and then set positions to the list using set positions method.
        lineRenderer.positionCount = trajectoryStepCount;
        lineRenderer.SetPositions(positions);
    }

    private void Fireball()
    {
        Transform pr = Instantiate(projectilePrefab, spawnPoint.position, Quaternion.identity);

        pr.GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
