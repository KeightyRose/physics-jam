using System.Collections;
using UnityEngine;

public class TrajectoryLine : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public GameObject spawnPoint;
    //public float maxDrawDistance = 5f;

    public bool isDrawing;

    public Vector3 startPoint;
    public Vector3 endPoint;

    private void Awake()
    {
        spawnPoint = GameObject.Find("Spawn");
    }

    private void Start()
    {
        //lineRenderer.positionCount = 2;
        lineRenderer.enabled = false;
    }

    private void Update()
    {
        if (isDrawing == true)
        {
            DrawTrajectory();
            UpdateTrajectoryLine();
        }

        if (Input.GetMouseButton(1))
        {
            LockTrajectory();
        }

    }

    public void DrawTrajectory()
    {
        startPoint = spawnPoint.transform.position;
        lineRenderer.enabled = true;
        isDrawing = true;
    }

    private void LockTrajectory()
    {
        isDrawing = false;
        //lineRenderer.enabled = false;
    }

    private void UpdateTrajectoryLine()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        Debug.Log(mousePosition);

        lineRenderer.SetPosition(0, startPoint);
        lineRenderer.SetPosition(1, mousePosition);
    }

}
