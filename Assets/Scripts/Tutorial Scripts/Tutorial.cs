using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private GameObject[] prompts;
    private int currentPromptIndex = -1;
    private GameObject currentPrompt;
    GameObject clickObj;
    //each prompt must move the session forward. 
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject prompt in prompts)
        {
            prompt.SetActive(false);
        }
        nextPrompt();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void nextPrompt()
    {
        currentPromptIndex++;
        if(currentPrompt !=null)
        {
            currentPrompt.SetActive(false);
        }
        if(currentPromptIndex < prompts.Length)
        {
            currentPrompt = prompts[currentPromptIndex];
            currentPrompt.SetActive(true);
        }
    }
    private void OnEnable()
    {
        OnMousePrompt.OnPrompt += nextPrompt;
    }
    private void OnDisable()
    {
        OnMousePrompt.OnPrompt -= nextPrompt;
    }
}
