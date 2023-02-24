using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jauge : MonoBehaviour
{
    [SerializeField] private Slider barre = null;
    [SerializeField] private float maxValue = 100;
    [SerializeField] private float currentValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateJaugeUI();
    }

    private void UpdateJaugeUI()
    {
        barre.maxValue = maxValue;
        barre.value = currentValue;
    }
}
