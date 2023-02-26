using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveRandom : MonoBehaviour
{

    private float moveSpeed = 150f; // Vitesse de déplacement de l'image
    private Vector3 targetPosition; // Position cible de l'image

    void Start()
    {
        // Choisir une position initiale aléatoire pour l'image
        Vector3 initialPosition = new Vector3(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height), 0f);
        transform.position = initialPosition;

        // Choisir une position cible aléatoire pour l'image
        targetPosition = new Vector3(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height), 0f);
    }

    void Update()
    {
        // Vérifier si l'image est proche de sa position cible
        if (Vector3.Distance(transform.position, targetPosition) < 5f)
        {
            // Choisir une nouvelle position cible aléatoire pour l'image
            targetPosition = new Vector3(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height), 0f);
        }
        else
        {
            // Déplacer l'image vers sa position cible à la vitesse de déplacement spécifiée
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }

        // Vérifier que l'image ne sort pas de l'écran
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, 0f, Screen.width);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, 0f, Screen.height);
        transform.position = clampedPosition;
    }

}
