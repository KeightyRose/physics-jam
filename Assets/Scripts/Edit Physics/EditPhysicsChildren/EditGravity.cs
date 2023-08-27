using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditGravity : AbstractButton
{
    private CustomGrav gravScript;
    private bool ragDoll = false;
    public override void editPhysics()
    {
        base.editPhysics();
        a_lineRenderer.enabled = true;
    }
    public override void updatePhysics()
    {
        gravScript = a_Object.GetComponent<CustomGrav>();
        base.updatePhysics();
        Vector3 pos1 = a_Object.transform.position;
        Vector3 pos2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gravScript.changeGravity(pos2 - pos1);
    }
}
