using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatWalk : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    [SerializeField] private GameObject particle;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right*Time.deltaTime*speed);
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.transform.tag == "Player")
    //    {
    //        GameObject temp = Instantiate(particle,collision.transform.position,Quaternion.identity);
    //        collision.gameObject.GetComponent<RagDollController>().RagDollModeOn();
    //        Rigidbody2D[] bodies = collision.transform.GetComponentsInChildren<Rigidbody2D>();
    //        foreach(Rigidbody2D b in bodies)
    //        {
    //            b.gravityScale = 3;
    //        }

    //         StartCoroutine(catKill());
    //    }

    //}

    //private IEnumerator catKill()
    //{
    //    yield return new WaitForSeconds(2);
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}
}
