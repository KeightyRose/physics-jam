using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D hook;

    public float releaseTime = 0.15f;
    public float maxDragDist = 2f;

    public GameObject nextBall;

    private bool _isPressed = false;

    public LineRenderer lineFront;
    public LineRenderer lineBack;

    private Ray _leftCatapultToProjectile;
    private float _circleRadius;

    void Start()
    {
        LineRendererSetUp();
        _circleRadius = 0.3f;
        _leftCatapultToProjectile = new Ray(lineFront.transform.position, Vector3.zero);

    }

    
    void Update()
    {
        if (_isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(Vector3.Distance(mousePos, hook.position) > maxDragDist)
            {
                rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDist;
            }
            else
            {
                rb.position = mousePos;
            }

            LineRendererUpdate();
        }
    }

    void LineRendererUpdate()
    {
        Vector2 catapultToProjectile = transform.position - lineFront.transform.position;
        _leftCatapultToProjectile.direction = catapultToProjectile;
        Vector3 holdPoint = _leftCatapultToProjectile.GetPoint(catapultToProjectile.magnitude + _circleRadius);
        lineFront.SetPosition(1, holdPoint);
        lineBack.SetPosition(1, holdPoint);
    }

    private void LineRendererSetUp()
    {
        lineFront.SetPosition(0, lineFront.transform.position);
        lineBack.SetPosition(0, lineBack.transform.position);

        lineFront.sortingLayerName = "Foreground";
        lineBack.sortingLayerName = "Foreground";

        lineFront.sortingOrder = 3;
        lineBack.sortingOrder = 1;
    }

    private void OnMouseDown()
    {
        _isPressed = true;
        rb.isKinematic = true;
    }

    private void OnMouseUp()
    {
        _isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;

        yield return new WaitForSeconds(2f);
        if (nextBall != null)
        {
            nextBall.SetActive(true);
        }
    }

    
}
