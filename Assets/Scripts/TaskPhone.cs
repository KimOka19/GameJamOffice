using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskPhone : MainTask
{
    [SerializeField] private GameObject phone = null;
    [SerializeField] private int scoreTask = 200;

    [SerializeField] private TextMeshProUGUI TaskToDo = null;
    [SerializeField] private GameObject panelRules = null;

    private ShakeScreen shakeScreen = null;
    private PlayerInteraction playerInteraction = null;
    

    // Start is called before the first frame update
    void Start()
    {
        TaskToDo.text = "Stop ton portable !";
        panelRules.SetActive(true);

        GetComponent<AudioSource>().Play();

        shakeScreen = GetComponent<ShakeScreen>();
        playerInteraction = LevelReferences.Instance.playerInteraction;

    }

    // Update is called once per frame
    void Update()
    {
        if(phone == playerInteraction.GetCurrentItemSelected())
        {
            shakeScreen.SetEnableShake(false);
            GetComponent<AudioSource>().Stop();
            Finish();
        }
    }

    private void Finish()
    {
        LevelReferences.Instance.playerScoring.ScoreAdd(scoreTask);
        LevelReferences.Instance.taskManager.FinishTaskCurrent();

    }
}
