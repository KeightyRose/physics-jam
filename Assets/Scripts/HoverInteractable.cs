using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverInteractable : MonoBehaviour
{
    [SerializeField] private GameObject particlePrefab;
    private ParticleSystem _hoverParticles;

    private GameObject _hoverObject;
    // Start is called before the first frame update
    void Start()
    {
        

        _hoverObject = Instantiate(particlePrefab);
        _hoverParticles = _hoverObject.GetComponent<ParticleSystem>();
        _hoverObject.SetActive(false);
    }

    // Update is called once per frame
    private void OnMouseEnter()
    {
        _hoverObject.SetActive(true);
    }
    private void OnMouseOver()
    {
        Vector3 mousePos  = Input.mousePosition;
        mousePos.z = 0;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        worldPos.z = 0;
        _hoverObject.transform.position = worldPos;
    }
    private void OnMouseExit()
    {
        _hoverObject.SetActive(false);
    }
}
