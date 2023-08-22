using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditPhysics : MonoBehaviour
{
    [SerializeReference] private GameObject gameObject;
    private Rigidbody rb;
    [SerializeField] private GameObject[] options;

    // Start is called before the first frame update
    // so when the player selects an object, options appear. When you select an option that creates an arrow that they can drag
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //show the options
        //get mouse position and display each option around the mouse
    }
}
