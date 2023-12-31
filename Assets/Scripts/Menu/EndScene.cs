using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public enum identifier
    {
        tag,
        name
    };
    [SerializeField] private identifier identifiervar;
    [SerializeField] private string initiatorTag;
    [SerializeField] private float delay = 2f;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLLISION WITH");
        bool found =false;
        switch (identifiervar)
        {
            case identifier.tag:
                if(collision.transform.tag == initiatorTag)
                {
                    found = true;
                }
                break;
            case identifier.name:
                if (collision.transform.name == initiatorTag)
                {
                    found = true;
                }
                break;
            default:
                break;
                
        }

        if(found)
        {
            
            StartCoroutine(nextScene());
        }
    }

    public IEnumerator nextScene()
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("Current scene : " + SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Scene Count : " + SceneManager.sceneCountInBuildSettings);


        if (SceneManager.GetActiveScene().buildIndex +  1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
