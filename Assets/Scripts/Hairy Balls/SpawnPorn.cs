using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPorn : MonoBehaviour
{
    public Rigidbody2D projectilePrefab;
    public Transform spawnPoint;

    public void Spawn()
    {
        Rigidbody2D currentProjectile = Instantiate(projectilePrefab, spawnPoint.position, Quaternion.identity);
    }
}
