using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    private PlayerScoring globalScoring = null;
    private Timer timer = null;
    private int localScore = 0;

    [SerializeField] private List<MainTask> Tasks = new List<MainTask>();
    // Start is called before the first frame update
    void Start()
    {
        globalScoring = LevelReferences.Instance.playerScoring;
        timer = LevelReferences.Instance.timer;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LaunchTask(float durationTask)
    {
        timer.Set(durationTask);
        timer.Start();
    }


    public void FinishTaskCurrent()
    {
        globalScoring.ScoreAdd(localScore);
        GameManager.Instance.ReturnToOffice();
    }

    public void AddTask(MainTask task)
    {
        Tasks.Add(task);
    }


}
