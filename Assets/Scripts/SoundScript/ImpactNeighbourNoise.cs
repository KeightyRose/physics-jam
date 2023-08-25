using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactNeighbourNoise : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;
    [SerializeField] private AudioSource audSource;
    public float volume = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.rigidbody != null)
        {
            if (collision.rigidbody.velocity.magnitude > 0.5)
            {
                Debug.Log("YOUVE BEEN PLAYED");
                int i = Random.Range(0, clips.Length);
                audSource.volume = volume;
                audSource.PlayOneShot(clips[i]);
            }
        }
        
    }
}
