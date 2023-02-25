using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskCleanWindow : MainTask
{
    [SerializeField] private List<GameObject> WindowOpen = new List<GameObject>();
    private int totalWindows = 0;
    void Start()
    {
        totalWindows = WindowOpen.Count;

        for (int i = 0; i < WindowOpen.Count; i++)
        {
            WindowOpen[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(totalWindows == 0)
        {
            Finish();
        }
    }

    public void CloseWindow(GameObject window)
    {
        WindowOpen.Remove(window);
        totalWindows--;
    }

    public void Finish()
    {
        LevelReferences.Instance.taskManager.FinishTaskCurrent();
    }
}
