using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMousePrompt : PromptsAbs
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        promptEventFunction();
    }
}
