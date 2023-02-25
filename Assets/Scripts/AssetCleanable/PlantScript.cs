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
    private GameObject cleanAndWateredMesh = null;

    [SerializeField]
    private GameObject messAndWateredMesh = null;
    
    [SerializeField]
    private GameObject cleanAndDryMesh = null;

    [SerializeField]
    private GameObject messAndDryMesh = null;

    public bool watered = false;

    // Start is called before the first frame update
    void Start()
    {
        //Set all mesh positions
        cleanAndWateredMesh.transform.position = cleanPlantTransform.position;
        messAndWateredMesh.transform.position = messPlantTransform.position; 
        cleanAndDryMesh.transform.position = cleanPlantTransform.position;
        messAndDryMesh.transform.position = messPlantTransform.position;
    }

    private void ClearActivity()
    {
        cleanAndWateredMesh.SetActive(false);
        cleanAndDryMesh.SetActive(false);
        messAndWateredMesh.SetActive(false);
        messAndDryMesh.SetActive(false);
    }

    public void MakeMessPlant()
    {
        ClearActivity();
        if (watered == true)
        {
            messAndWateredMesh.SetActive(true);
        }
        else
        {
            messAndDryMesh.SetActive(true);
        }
    }

    public void CleanPlant()
    {
        ClearActivity();
        if (watered == true)
        {
            cleanAndWateredMesh.SetActive(true);
        }
        else
        {
            cleanAndDryMesh.SetActive(true);
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
