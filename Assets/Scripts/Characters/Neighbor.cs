using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Neighbor : MonoBehaviour
{
    public float neighborHealth = 3;

    public Slider neighborHealthSlider;

    [SerializeField] private float delay = 2f;

    void Start()
    {
        neighborHealthSlider.minValue = 0;
        neighborHealthSlider.maxValue = 3;
        neighborHealthSlider.value = neighborHealth;
    }

    
    void Update()
    {
        if (neighborHealth <= 0)
        {
            Debug.Log("won level");

            StartCoroutine(nextScene());
        }
    }

    private IEnumerator nextScene()
    {
        yield return new WaitForSeconds(delay);
        if (SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

}
