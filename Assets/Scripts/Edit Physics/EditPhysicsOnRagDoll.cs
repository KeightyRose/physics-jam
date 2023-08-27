using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditPhysicsOnRagDoll : MonoBehaviour
{
    // Start is called before the first frame update
    private RagDollController rgController;
    private EditPhysics editPhys;
    private void Start()
    {
        rgController= GetComponent<RagDollController>();

        editPhys = GetComponentInChildren<EditPhysics>();
    }
    private void OnMouseDown()
    {
        rgController.RagDollModeOn();
        editPhys.OnMouseDown();
    }
}
