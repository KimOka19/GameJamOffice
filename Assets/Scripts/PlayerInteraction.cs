using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private Interactables currentAimedObject = null;

    private float raycastMaxDistance = 10f;

    private LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = transform.position;
        Vector3 playerDirection = transform.forward;

        RaycastHit hit;
        if (Physics.Raycast(playerPosition, playerDirection, out hit, raycastMaxDistance, layerMask))
        {
            currentAimedObject.Highlight(currentAimedObject);
        }
    }

    
}
