using System;
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
        lineRenderer = GetComponent<LineRenderer>();
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
            
            placeButtons();

            foreach(GameObject option in options)
            {
                if (option.TryGetComponent(out AbstractButton btnScript))
                {
                    btnScript.SetObject(this.gameObject);
                    
                }
            }
        }
    }
    public void switchOnLayerMask()
    {
        gameObject.layer = clickableLayer;
    }

    private void placeButtons()
    {


        //bool[] inScreenArray = new bool[360]; 
        //for (int i = 0; i < 360; i++)
        //{
        //    float rad = i * MathF.PI / 180;
        //    float x = radius * Mathf.Cos(i * interval);
        //    float y = -radius * Mathf.Sin(i * interval);
        //    Vector3 pos = new Vector3(x, y, 0);
        //    //need to check that this is in screen. 
        //    Vector3 posChecker = Camera.main.ScreenToViewportPoint(Input.mousePosition + pos);
        //    bool instring = true;
        //    if (posChecker.x > 1 || posChecker.y > 1 || posChecker.x < 0 || posChecker.y < 0)
        //    {
        //        instring = false;
        //    }
        //    inScreenArray[i] = instring;

        //}

        //int point1 = 0;
        //int point2 = 0;

        ////case 1 if 0 is in screen
        //if (inScreenArray[0])
        //{
        //    int count = 0;
        //    while (inScreenArray[count])
        //    {
        //        count++;
        //    }
        //    point2 = count - 1;
        //    while (!inScreenArray[count])
        //    {
        //        count++;
        //    }
        //    point1 = count;

        //}
        //else
        //{
        //    int count = 0;
        //    while (!inScreenArray[count])
        //    {
        //        count++;
        //    }
        //    point1 = count;
        //    while (inScreenArray[count])
        //    {
        //        count++;
        //    }
        //    point2 = count;
        //}
        float interval = 360 / options.Length;
        interval = interval * Mathf.PI / 180;
        for (int i = 0; i < options.Length; i++)
        {
            
            options[i].SetActive(true);
            //set position of options
            float x = radius * Mathf.Cos(i * interval);
            float y = -radius * Mathf.Sin(i * interval);
            Vector3 pos = new Vector3(x, y, 0);
            //need to check that this is in screen. 
            Vector3 posChecker =  Camera.main.ScreenToViewportPoint(Input.mousePosition + pos);
            bool instring = true;
            if(posChecker.x >1 || posChecker.y>1 || posChecker.x <0 || posChecker.y <0)
            {
                instring = false;
            }

            Debug.Log(i + "ith postion in screen :" + instring);

            options[i].transform.position = Input.mousePosition + pos;

        }


    }
}
