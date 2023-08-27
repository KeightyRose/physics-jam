using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChildren : MonoBehaviour
{
    public Player player;

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
        if (collision.gameObject.CompareTag("Ball"))
        {
            player.playerHealth -= 1;
            player.playerHealthSlider.value = player.playerHealth;
            _particlePrefab.transform.position = this.gameObject.transform.position;
            _particlePrefab.SetActive(true);
        }
        if (collision.gameObject.CompareTag("KnockDown"))
        {
            player.playerHealth -= 1;
            player.playerHealthSlider.value = player.playerHealth;
            _particlePrefab.transform.position = this.gameObject.transform.position;
            _particlePrefab.SetActive(true);
        }
    }
}
