using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditPhysics : MonoBehaviour
{
    [SerializeField] private int notClickableLayer, clickableLayer;
    private Rigidbody2D rb;
    [SerializeField] private GameObject[] options;
    [SerializeField] private float radius;

    private LineRenderer lineRenderer;

    // Start is called before the first frame update
    // so when the player selects an object, options appear. When you select an option that creates an arrow that they can drag
    void Start()
    {
        lineRenderer= GetComponent<LineRenderer>();
        lineRenderer.enabled= false;
        switchOffButtons();
    }

    // Update is called once per frame
    public void switchOffButtons()
    {
        foreach (GameObject option in options)
        {
            option.SetActive(false);
        }
    }
    public void OnMouseDown()
    {
        this.gameObject.layer = notClickableLayer;
        // show the options
        // get mouse position and display each option around the mouse
        if (options[0] != null && options.Length != 0)
        {
            
            //interval is angle between options
            float interval = 360 / options.Length;
            interval = interval * Mathf.PI / 180;
            for (int i = 0; i < options.Length; i++)
            {
                options[i].SetActive(true);
                //set position of options
                float x = radius*Mathf.Cos(i*interval);
                float y = -radius*Mathf.Sin(i*interval);
                Vector3 pos = new Vector3(x, y, 0);

                options[i].transform.position = Input.mousePosition+ pos;

            }

            foreach(GameObject option in options)
            {
                if (option.TryGetComponent(out AbstractButton btnScript))
                {
                    Debug.Log("MY POS1 is " + transform.position);
                    btnScript.SetObject(this.gameObject);
                    
                }
            }
        }
    }
    public void switchOnLayerMask()
    {
        gameObject.layer = clickableLayer;
    }
}
