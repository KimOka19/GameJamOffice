using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScript : MonoBehaviour
{
    [SerializeField]
    private Transform cleanPlantTransform = null;
    [SerializeField]
    private Transform messPlantTransform = null;


    [SerializeField]
    private Mesh cleanAndWateredObject = null;
    [SerializeField]
    private Mesh messAndWateredObject = null;
    [SerializeField]
    private Mesh cleanAndDryObject = null;
    [SerializeField]
    private Mesh messAndDryObject = null;


    private MeshFilter currentObject = null;

    public bool watered = false;

    // Start is called before the first frame update
    void Start()
    {
        //Set mesh positions
        gameObject.transform.position = cleanPlantTransform.position;
        currentObject = gameObject.GetComponentInChildren<MeshFilter>();
        currentObject.mesh = cleanAndWateredObject;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            MakeMessPlant();
        }
    }
    public void MakeMessPlant()
    {
        if (watered == true)
        {
            currentObject.mesh = messAndWateredObject;
        }
        else
        {
            currentObject.mesh = messAndDryObject;
        }
    }

    public void CleanPlant()
    {
        if (watered == true)
        {
            currentObject.mesh = cleanAndWateredObject;
        }
        else
        {
            currentObject.mesh = cleanAndDryObject;
        }
    }

    public void SetDryPlant()
    {
        watered = false;
    }
    public void SetWateredPlant()
    {
        watered = true;
    }
}
