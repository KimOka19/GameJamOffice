using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetToClean : MonoBehaviour
{
    [SerializeField]
    private Transform cleanObjectTransform = null;
    [SerializeField]
    private Transform messObjectTransform = null;

    [SerializeField]
    private Mesh cleanObject = null;
    [SerializeField]
    private Mesh messObject = null;

    private MeshFilter currentObject = null;

    // Start is called before the first frame update
    void Start()
    {
        currentObject.mesh = cleanObject;
    }

    public void MakeMess()
    {
        SpawnVFX vFX = GetComponent<SpawnVFX>();

        currentObject.mesh = messObject;
        if(GetComponent<SpawnVFX>() != null)
        {
            vFX.enabled = true;
        }
    }

    public void Clean()
    {
        SpawnVFX vFX = GetComponent<SpawnVFX>();

        currentObject.mesh = cleanObject;
        if (GetComponent<SpawnVFX>() != null)
        {
            vFX.enabled = false;
        }
    }
}
