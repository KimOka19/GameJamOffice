using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetToClean : MonoBehaviour
{
    [SerializeField]
    private Transform cleanTransform = null;

    [SerializeField]
    private Transform messTransform = null;

    [SerializeField]
    private GameObject cleanMesh = null;

    [SerializeField]
    private GameObject messMesh = null;

    // Start is called before the first frame update
    void Start()
    {
        cleanMesh.transform.position = cleanTransform.position;
        messMesh.transform.position = messTransform.position;
    }

    public void MakeMess()
    {
        cleanMesh.SetActive(false);
        messMesh.SetActive(true);
    }

    public void Clean()
    {
        cleanMesh.SetActive(true);
        messMesh.SetActive(false);
    }
}
