using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskSmashButton : MainTask
{
    [SerializeField] private PlayerSpaming player = null;

    [SerializeField] private Slider jauge = null;
    private int maxJauge = 100;
    private float valueCurrent = 10;

    private float durationTask = 10f;
    private Timer timer = null;

    private float MaxTime = 20f;
    private float ActiveTime = 0f;

    private bool inPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        player.enabled = true;
        jauge.enabled = true;
        jauge.gameObject.SetActive(true);

        timer = LevelReferences.Instance.timer;
        timer.Set(durationTask);
        timer.Start();
        jauge.maxValue = maxJauge; 
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetisSpamming())
        {
            //inPaused = true;
            //StartCoroutine(Delay());
            Debug.Log(inPaused);
        }
        else
        {
            fillInJauge();
            UpdateUI();
        }

        if (timer.Update())
        {
           Finish();
        }


        if(jauge.value == maxJauge)
        {
            Finish();
        }

    }

    // Increscent bar in time
    private void fillInJauge()
    {
        
        if (!inPaused)
        {
            ActiveTime += Time.deltaTime;
            valueCurrent = (ActiveTime / MaxTime) * 200;
        }
        
        //valueCurrent += 10;
        //StartCoroutine(Delay());
    }


    private void UpdateUI()
    {
        jauge.value = valueCurrent;
    }


    IEnumerator DelayPause()
    {
        yield return new WaitForSeconds(1f);
        inPaused = false;
        Debug.Log(inPaused);

    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5f);
    }

    private void Finish()
    {
        Debug.Log("Finish prout");

        player.enabled = false;
        jauge.gameObject.SetActive(false);
        LevelReferences.Instance.taskManager.FinishTaskCurrent();
    }

}
