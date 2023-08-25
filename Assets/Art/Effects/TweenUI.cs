using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private bool spin;
    private Vector3 originalScale;
    private bool first = true;
    void Start()
    {
        originalScale= transform.localScale;
        transform.localScale = Vector3.zero;
        LeanTween.scale(this.gameObject, originalScale,1f).setEase(LeanTweenType.easeOutBounce);
        if(spin)
        {
            LeanTween.rotateAround(this.gameObject, Vector3.forward, -360, 10f).setLoopClamp();
        }
        first= false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        if (!first)
        {
            originalScale = transform.localScale;
            transform.localScale = Vector3.zero;
            LeanTween.scale(this.gameObject, originalScale, 1f).setEase(LeanTweenType.easeOutBounce);
            if (spin)
            {
                LeanTween.rotateAround(this.gameObject, Vector3.forward, -360, 10f).setLoopClamp();
            }
        }
    }
}
