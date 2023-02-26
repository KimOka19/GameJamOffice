using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskCleanWindow : MainTask
{
    [SerializeField] private int scoreTask = 450;
    [SerializeField] private List<GameObject> WindowOpen = new List<GameObject>();
    [SerializeField] private GameObject background = null;
    private int totalWindows = 0;

    [SerializeField] private TextMeshProUGUI TaskToDo = null;
    [SerializeField] private GameObject panelRules = null;

    void Start()
    {
        TaskToDo.text = "Fermes les pop up !";
        panelRules.SetActive(true);

        GameManager.Instance.GoToDesk();
        totalWindows = WindowOpen.Count;
        background.SetActive(true);

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
        background.SetActive(false);
        GameManager.Instance.ReturnToOffice();
        LevelReferences.Instance.playerScoring.ScoreAdd(450);
        LevelReferences.Instance.taskManager.FinishTaskCurrent();
    }
}
