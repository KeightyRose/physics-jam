using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RagDollController : MonoBehaviour
{
    private Collider2D mainCollider;
    private Collider2D[] ragDollColliders;
    private Rigidbody2D[] ragDollRigidBodies;

    [SerializeField] private GameObject particleEffect;
    private ParticleSystem particles;
    // Start is called before the first frame update
    void Start()
    {
        GetRagDoll();
        mainCollider = GetComponent<Collider2D>();
        RagDollModeOff();
        if(particleEffect!= null)
        {
            particles = particleEffect.GetComponent<ParticleSystem>();
        }
       
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "KnockDown")
        {
            RagDollModeOn();
            if (particleEffect != null)
            {
                GameObject temp = Instantiate(particleEffect, collision.contacts[0].point, Quaternion.identity);
                particles = temp.GetComponent<ParticleSystem>();
                particles.Play();
            }
           
        }
    }

    private void GetRagDoll()
    {
        ragDollColliders = GetComponentsInChildren<Collider2D>();
        ragDollRigidBodies = GetComponentsInChildren<Rigidbody2D>();
    }

    public void RagDollModeOn()
    {
        foreach (Collider2D col in ragDollColliders)
        {
            col.enabled = true;
        }
        foreach (Rigidbody2D rb in ragDollRigidBodies)
        {
            rb.isKinematic = false;
        }

        mainCollider.enabled = false;
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    public void RagDollModeOff()
    {
        foreach(Collider2D col in ragDollColliders)
        {
            col.enabled = false;
        }
        foreach(Rigidbody2D rb in ragDollRigidBodies)
        {
            rb.isKinematic = true;
        }
        
        mainCollider.enabled = true;
        GetComponent<Rigidbody2D>().isKinematic= false;
    }
}
