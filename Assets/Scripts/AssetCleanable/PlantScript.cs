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

    private bool isClean = false;

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
        //if(Input.GetMouseButtonDown(1))
        //{
        //    MakeMessPlant();
        //}
    }

    public void MakeMessPlant()
    {
        if (watered == true)
        {
            currentObject.mesh = messAndWateredObject;
            isClean = false;
        }
        else
        {
            currentObject.mesh = messAndDryObject;
            isClean = false;
        }
    }

    public void CleanPlant()
    {
        if (watered == true)
        {
            currentObject.mesh = cleanAndWateredObject;
            isClean = true;
        }
        else
        {
            currentObject.mesh = cleanAndDryObject;
            isClean = true;
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

    public bool PlantisClean()
    {
        return isClean;
    }
}
