using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMousePrompt : MonoBehaviour
{

    public delegate void PromptAction();
    public static event PromptAction OnPrompt;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        promptEventFunction();
    }

    public void promptEventFunction()
    {
        if (OnPrompt != null)
        {
            OnPrompt();
        }
    }
}
