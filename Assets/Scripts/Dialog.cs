using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog
{

    [SerializeField] private string nameDialog;

    [Header("Dialog Content")]

    [TextArea(3, 10)]
    [SerializeField] private string[] sentences;

    public string GetNameDialog()
    {
        return nameDialog;
    }

    public string GetSentence(int nbSentence)
    {
        if (sentences[nbSentence] != null)
        {
            return sentences[nbSentence];
        }

        Debug.Log("No more sentence.");
        return (null);
    }

}
