using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeighborChildren : MonoBehaviour
{
    public Neighbor neighbor;

    [SerializeField] private GameObject bloodEffect;
    private ParticleSystem _bloodParticles;
    private GameObject _particlePrefab;

    private void Start()
    {
        _particlePrefab = Instantiate(bloodEffect);
        _bloodParticles = _particlePrefab.GetComponent<ParticleSystem>();
        _particlePrefab.SetActive(false);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball") || collision.gameObject.CompareTag("KnockDown") || collision.gameObject.CompareTag("Player"))
        {
            neighbor.neighborHealth -= 1;
            neighbor.neighborHealthSlider.value = neighbor.neighborHealth;
            _particlePrefab.transform.position = this.gameObject.transform.position;
            _particlePrefab.SetActive(true);
        }
     
    }
}
