using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    [SerializeField] 
    private Material normalMaterial = null;

    [SerializeField] 
    private Material hightLightMaterial = null;

    private Renderer renderer = null;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Highlight(Interactables gameObjectToHighlight)
    {
        
    }

    private void OnMouseEnter()
    {
        renderer.material = hightLightMaterial;
    }

    private void OnMouseExit()
    {
        renderer.material = normalMaterial;
    }

}
