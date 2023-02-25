using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeScreen : MonoBehaviour
{
    // Camera Information
    [SerializeField] private Transform cameraTransform;
    private Vector3 orignalCameraPos;

    // Shake Parameters
    //public float shakeDuration = 2f;
    public float shakeAmount = 0.7f;

    private bool canShake = true;
    //private float _shakeTimer;



    // Start is called before the first frame update
    void Start()
    {
        orignalCameraPos = cameraTransform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
        //ShakeCamera();

        if (canShake)
        {
            StartCameraShakeEffect();
        }
    }

    public void ShakeCamera()
    {
        canShake = true;
        //_shakeTimer = shakeDuration;
    }

    public void StartCameraShakeEffect()
    {
        if (canShake)
        {
            cameraTransform.localPosition = orignalCameraPos + Random.insideUnitSphere * shakeAmount;
            //_shakeTimer -= Time.deltaTime;
        }
        else
        {
            //_shakeTimer = 0f;
            cameraTransform.position = orignalCameraPos;
            canShake = false;
        }
    }

    public void SetEnableShake(bool enable)
    {
        canShake = enable;
        Debug.Log(canShake);
    }
}
