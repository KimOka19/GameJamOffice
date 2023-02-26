using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugScript : MonoBehaviour
{
    [SerializeField]
    private Transform cleanObjectTransform = null;
    [SerializeField]
    private Transform messObjectTransform = null;

    [SerializeField]
    private Mesh cleanObject = null;
    [SerializeField]
    private Mesh messObject = null;
    [SerializeField]
    private Mesh firstCleanObject = null;

    private MeshFilter currentObject = null;

    private bool isClean = false;

    // Start is called before the first frame update
    void Start()
    {
        currentObject.mesh = firstCleanObject;
    }

    public void MakeMess()
    {
        currentObject.mesh = messObject;
    }

    public void Clean()
    {
        currentObject.mesh = cleanObject;
        isClean = true;
    }
}
