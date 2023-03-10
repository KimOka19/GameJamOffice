using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpaming : MonoBehaviour
{
    private float clickCount;
    private float timer;
    private bool isSpamming = false;

    private float limitValidCps = 2;

    // Update is called once per frame
    void Update()
    {
        // On incr?mente le compteur de clics si le joueur appuie sur le bouton gauche de la souris
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
        }

        // On incr?mente le timer ? chaque frame
        timer += Time.deltaTime;

        // Si une seconde s'est ?coul?e, on affiche le nombre de clics par seconde et on r?initialise le compteur et le timer
        if (timer >= 1f)
        {
            float cps = clickCount / timer;
            valideSpam(cps);

            Debug.Log("Clics par seconde : " + cps.ToString());
            clickCount = 0f;
            timer = 0f;
        }


    }

    public bool GetisSpamming()
    {
        return isSpamming;
    }


    private void valideSpam(float cps)
    {
        if(cps >= limitValidCps)
        {
            isSpamming = true;
        }
        else
        {
            isSpamming = false;
        }
    }
}
