using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : AbstractButton
{
    // Start is called before the first frame update
    [SerializeField] private float addForce = 1;
    public override void editPhysics()
    {
        base.editPhysics();
        a_lineRenderer.enabled = true;
    }
    public override void updatePhysics()
    {
        base.updatePhysics();
        Vector3 direction = a_Object.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction.z = 0;
        Debug.Log("FORCE TO ADD:" + direction);
        a_Rb.AddForce(-1*direction * addForce,ForceMode2D.Impulse);
        if (!a_Object.TryGetComponent<CustomGrav>(out CustomGrav cg))
        {
            a_Rb.gravityScale = 1;
        }
        
    }

}
