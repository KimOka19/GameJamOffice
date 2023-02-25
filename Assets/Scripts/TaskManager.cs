using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    private PlayerScoring globalScoring = null;
    private Timer timer = null;
    private int localScore = 0;

    [SerializeField] private float _duration = 120f;

    [SerializeField] private List<MainTask> tasks = new List<MainTask>();
    private MainTask taskCurrent = null;
    private int indexTask = 0;
    // Start is called before the first frame update
    void Start()
    {
        globalScoring = LevelReferences.Instance.playerScoring;
        timer = LevelReferences.Instance.timer;
        taskCurrent = tasks[0];
        
        StartNewDay();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNewDay()
    {
        LaunchNewTask(_duration, taskCurrent);
    }

    public void LaunchNewTask(float durationTask, MainTask taskCurrent)
    {
        if (taskCurrent != null)
        {
            timer.Set(durationTask);
            timer.Start();
            taskCurrent.gameObject.SetActive(true);
        }

        else
        {

        }
    }


    public void FinishTaskCurrent()
    {
        timer.Stop();
        taskCurrent.gameObject.SetActive(false);
        globalScoring.ScoreAdd(localScore);
        GameManager.Instance.ReturnToOffice();
        indexTask++;

        LaunchNextTask();
    }

    public void LaunchNextTask()
    {
        if (indexTask < tasks.Count)
        {
            taskCurrent = tasks[indexTask];
            LaunchNewTask(120, taskCurrent);
        }
        else
        {
            GameManager.Instance.EndDay();
        }
    }

    public void AddTask(MainTask task)
    {
        tasks.Add(task);
    }


}
