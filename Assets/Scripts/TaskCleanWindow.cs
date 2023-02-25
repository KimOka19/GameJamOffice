using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskCleanWindow : MonoBehaviour
{
    [SerializeField] private List<GameObject> WindowOpen = new List<GameObject>();
    private int totalWindows = 0;
    void Start()
    {
        totalWindows = WindowOpen.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if(totalWindows == 0)
        {
            
        }
    }

    public void CloseWindow(GameObject window)
    {
        WindowOpen.Remove(window);
        totalWindows--;
    }

    public void Finish()
    {

    }
}
