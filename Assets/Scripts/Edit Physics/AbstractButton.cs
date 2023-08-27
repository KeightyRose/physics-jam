using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractButton : MonoBehaviour
{
    [NonSerialized] public GameObject a_Object;
    [NonSerialized] public Rigidbody2D a_Rb;
    [NonSerialized] public EditPhysics a_EditPhysics;

    public LineRenderer a_lineRenderer;

    private bool activeButton;

    private void Start()
    {
       
    }
    public void SetObject(GameObject obj)
    {
        a_Object = obj;
        a_Rb= obj.GetComponent<Rigidbody2D>();
        a_EditPhysics= obj.GetComponent<EditPhysics>();
        a_lineRenderer = obj.GetComponent<LineRenderer>();
    }
    private void Update()
    {
        if (a_Object != null)
        {
            if (a_lineRenderer.enabled)
            {
                
                Vector3 pos1 = a_Object.transform.position;
                
                Vector3 pos2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                pos2.z = 0;
                a_lineRenderer.SetPosition(0, pos1);
                a_lineRenderer.SetPosition(1, pos2);

                if(Input.GetMouseButton(0) && activeButton)
                {
                    updatePhysics();
                    Close();
                    a_EditPhysics.switchOffButtons();
                    a_EditPhysics.switchOnLayerMask();
                }
            }
        }
        Vector3 posChecker =  Camera.main.ScreenToViewportPoint(transform.position);
        if (posChecker.x > 1 || posChecker.y > 1 || posChecker.x < 0 || posChecker.y < 0)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(0.5f, 0.5f, 0), Time.deltaTime * 2);
        }

    }
    private void Close()
    {
        a_lineRenderer.enabled = false;
    }
    public virtual void editPhysics()
    {
        activeButton = true;
    }
    public virtual void updatePhysics() 
    {
        activeButton= false;
    }
}
