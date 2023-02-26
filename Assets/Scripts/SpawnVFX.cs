using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVFX : MonoBehaviour
{
    [SerializeField] private GameObject vFX = null;
    void Start()
    {
        vFX.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
