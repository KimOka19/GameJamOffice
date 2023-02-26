using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSleeping : MonoBehaviour
{
    [SerializeField]
    private float triggerThreshold = 0;

    [SerializeField]
    private Image sleepingImage = null;

    private bool isTriggered = false;

    private Vector3 lastMousePosition;

    private float valueCurrent = 0;

    private float ActiveTime = 0f;
    private float MaxTime = 20f;

    private Color color;

    void Start()
    {
        color = sleepingImage.color;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Input.mousePosition;
        MakeImageDarker();
        if (Vector3.Distance(currentMousePosition, lastMousePosition) >= triggerThreshold)
        {
            isTriggered = true;
            WakeUp();
        }
        lastMousePosition = currentMousePosition;
    }

    void MakeImageDarker()
    {
        ActiveTime += Time.deltaTime;
        color.a += (ActiveTime / MaxTime) * 0.001f;
        sleepingImage.color = color;
    }

    void WakeUp()
    {
        color.a = 0;
        sleepingImage.color = color;
        Debug.Log("La fonction a été déclenchée !");
    }
}
