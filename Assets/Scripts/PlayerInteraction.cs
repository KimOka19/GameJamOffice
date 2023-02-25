using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private Interactables currentAimedObject = null;

    private float raycastMaxDistance = 10f;

    private LayerMask layerMask;
    private GameObject currentItem = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.current.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<Interactables>() != null)
                {
                    Vector3 distanceToTarget = hitInfo.point - transform.position;

                    currentItem = hitInfo.collider.gameObject;
                    Debug.Log(hitInfo.collider.gameObject.name);
                }
            }
        }
    }

    public GameObject GetCurrentItemSelected()
    {
        return currentItem;
    }

    
}
