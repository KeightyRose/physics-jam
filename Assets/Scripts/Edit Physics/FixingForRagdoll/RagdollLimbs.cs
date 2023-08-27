using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollLimbs : MonoBehaviour
{
    private EditPhysics editPhysics;
    // Start is called before the first frame update
    void Start()
    {
        editPhysics = transform.parent.GetComponentInChildren<EditPhysics>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (editPhysics != null)
        {
            editPhysics.OnMouseDown();
        }
    }
}
