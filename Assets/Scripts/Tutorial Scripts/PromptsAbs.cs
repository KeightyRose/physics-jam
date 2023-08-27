using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PromptsAbs : MonoBehaviour
{

    public delegate void PromptAction();
    public static event PromptAction OnPrompt;
    // Start is called before the first frame update

  

    public void promptEventFunction()
    {
       
        if (OnPrompt != null)
        {
            
            OnPrompt();
        }
    }
}
