using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrajectoryLine : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public GameObject spawnPoint;
    //public float maxDrawDistance = 5f;

    public bool isDrawing;

    public Vector3 startPoint;
    public Vector3 endPoint;

    public Button launchButton;

    public float desiredLineLength = 1f;

    private void Awake()
    {
        spawnPoint = GameObject.Find("Spawn");
        //launchButton = GameObject.Find("YeetButton").GetComponent<Button>();
    }

    private void Start()
    {
        //lineRenderer.positionCount = 2;
        lineRenderer.enabled = false;
        launchButton.enabled = false;
    }

    private void Update()
    {
        if (isDrawing == true)
        {
            DrawTrajectory();
            UpdateTrajectoryLine();
        }

        if (Input.GetMouseButton(0))
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

        launchButton.enabled = true;

        Debug.Log("this is start: " + startPoint + " and this is end " + endPoint);
    }

    private void UpdateTrajectoryLine()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        endPoint = mousePosition;
        Vector3 direction = endPoint - startPoint;
        Vector3 newEndPoint = startPoint + direction.normalized * desiredLineLength;

        lineRenderer.SetPosition(0, startPoint);
        lineRenderer.SetPosition(1, newEndPoint);
  
    }

}
