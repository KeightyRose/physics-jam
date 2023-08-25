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
    void Awake()
    {
        foreach(GameObject prompt in prompts)
        {
            prompt.SetActive(false);
        }
        
    }
    private void Start()
    {
        nextPrompt();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void nextPrompt()
    {
        Debug.Log("Recieved Event");
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
        PromptsAbs.OnPrompt += nextPrompt;
    }
    private void OnDisable()
    {
        PromptsAbs.OnPrompt -= nextPrompt;
    }
}
