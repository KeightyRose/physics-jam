using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigHairyBalls : MonoBehaviour
{
    private CircleCollider2D _ballCollider;

    private void Awake()
    {
        _ballCollider = GetComponent<CircleCollider2D>();
        _ballCollider.enabled = false;
    }

    void Start()
    {
        Invoke("SwitchColliderOn", 0.3f);
    }

    void Update()
    {

    }

    void SwitchColliderOn()
    {
        _ballCollider.enabled = true;
    }

}
