using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTimedPrompt : PromptsAbs
{
    // Start is called before the first frame update
    [SerializeField] private float time;
    void Start()
    {
        StartCoroutine(waitTime());
    }

    // Update is called once per frame
    private IEnumerator waitTime()
    {
        yield return new WaitForSeconds(time);
        promptEventFunction();
        Debug.Log("Finished coroutine");
    }
}
