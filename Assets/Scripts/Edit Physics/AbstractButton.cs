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
        Debug.Log("CALLED THIS");
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
    }
    private void Close()
    {
        a_lineRenderer.enabled = false;
    }
    public virtual void editPhysics()
    {
        activeButton = true;
        Debug.Log("MY POS2 is " + a_Object.transform.position);
    }
    public virtual void updatePhysics() 
    {
        activeButton= false;
    }
}
