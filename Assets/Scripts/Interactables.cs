using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    [SerializeField] 
    private Material normalMaterial = null;

    [SerializeField] 
    private Material hightLightMaterial = null;

    [SerializeField]
    private Renderer renderer = null;
    // Start is called before the first frame update
    void Start()
    {
        //renderer = GetComponent<Renderer>();
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
       Material[] materials = renderer.materials;
        for (int i = 0; i < materials.Length; i++)
        {
            if(hightLightMaterial == materials[i])
            {
                materials[i].SetFloat("Vector1_2a9a352a5bd44069a7ab93084267fcec", 10);
            }
        }
    }

    private void OnMouseExit()
    {
        Material[] materials = renderer.materials;
        for (int i = 0; i < materials.Length; i++)
        {
            if (hightLightMaterial == materials[i])
            {
                materials[i].SetFloat("Vector1_2a9a352a5bd44069a7ab93084267fcec", 10);
            }
        }
    }

}
