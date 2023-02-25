using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpaming : MonoBehaviour
{
    private float clickCount;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        // On incrémente le compteur de clics si le joueur appuie sur le bouton gauche de la souris
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
        }

        // On incrémente le timer à chaque frame
        timer += Time.deltaTime;

        // Si une seconde s'est écoulée, on affiche le nombre de clics par seconde et on réinitialise le compteur et le timer
        if (timer >= 1f)
        {
            float cps = clickCount / timer;
            Debug.Log("Clics par seconde : " + cps.ToString());
            clickCount = 0f;
            timer = 0f;
        }
    }
}
