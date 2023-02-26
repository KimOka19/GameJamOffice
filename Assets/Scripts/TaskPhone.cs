using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskPhone : MainTask
{
    [SerializeField] private GameObject phone = null;
    [SerializeField] private int scoreTask = 200;

    private ShakeScreen shakeScreen = null;
    private PlayerInteraction playerInteraction = null;
    
    // Start is called before the first frame update
    void Start()
    {
        shakeScreen = GetComponent<ShakeScreen>();
        playerInteraction = LevelReferences.Instance.playerInteraction;
    }

    // Update is called once per frame
    void Update()
    {
        if(phone == playerInteraction.GetCurrentItemSelected())
        {
            shakeScreen.SetEnableShake(false);
            Finish();
        }
    }

    private void Finish()
    {
        LevelReferences.Instance.playerScoring.ScoreAdd(scoreTask);
        LevelReferences.Instance.taskManager.FinishTaskCurrent();

    }
}
