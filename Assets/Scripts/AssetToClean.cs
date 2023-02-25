using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetToClean : MonoBehaviour
{
    [SerializeField]
    private Transform cleanPosition = null;
    [SerializeField]
    private Transform messPosition = null;

    [SerializeField]
    private Mesh cleanMesh = null;

    [SerializeField]
    private Mesh messMesh = null;

    [SerializeField]
    private MeshFilter currentMesh = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeMess()
    {
        currentMesh.mesh = messMesh;
    }

    public void Clean()
    {
        currentMesh.mesh = cleanMesh;
    }
}
