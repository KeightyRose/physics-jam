using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private bool spin;
    private Vector3 originalScale;
    void Start()
    {
        originalScale= transform.localScale;
        transform.localScale = Vector3.zero;
        LeanTween.scale(this.gameObject, originalScale,1f).setEase(LeanTweenType.easeOutBounce);
        if(spin)
        {
            LeanTween.rotateAround(this.gameObject, Vector3.forward, -360, 10f).setLoopClamp();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
