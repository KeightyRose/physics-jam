using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioClip[] musicClips;
    void Start()
    {
        musicSource = GetComponentInChildren<AudioSource>();
        int i = 0;

        i = Random.Range(0, musicClips.Length);
        AudioClip clip = musicClips[i];

        musicSource.clip = clip;
        musicSource.Play();
    }

    
}
