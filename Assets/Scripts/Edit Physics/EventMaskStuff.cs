using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EventMaskStuff : MonoBehaviour
{
    [SerializeField] private LayerMask layer;
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.eventMask = layer;
    }

    
}
