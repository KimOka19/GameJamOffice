using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskCleanOffice : MainTask
{
    [SerializeField] private List<AssetToClean> itemsToClean = new List<AssetToClean>();
    private PlayerInteraction playerInteraction = null;

    [SerializeField] private TextMeshProUGUI TaskToDo = null;
    [SerializeField] private GameObject panelRules = null;

    // Start is called before the first frame update
    void Start()
    {
        playerInteraction = LevelReferences.Instance.playerInteraction;
        TaskToDo.text = "Range ton bureau !";
        panelRules.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject interact = playerInteraction.GetCurrentItemSelected();

        if (interact != null)
        {
            AssetToClean itemAtClean = interact.gameObject.GetComponent<AssetToClean>();
            itemAtClean.Clean();
            itemsToClean.Remove(itemAtClean);
        }

        if(itemsToClean.Count == 0)
        {
            Finish();
        }
    }

    private void Finish()
    {
        LevelReferences.Instance.taskManager.FinishTaskCurrent();
    }
}
