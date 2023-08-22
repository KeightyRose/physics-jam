using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditGravity : AbstractButton
{
    public override void editPhysics()
    {
        base.editPhysics();
        a_lineRenderer.enabled = true;
    }
    public override void updatePhysics()
    {
        base.updatePhysics();
        a_Rb.gravityScale = 1;
    }
}
