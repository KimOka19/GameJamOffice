using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExamQuizz : MainTask
{
    [SerializeField] private TextMeshProUGUI textBoxDialog = null;

    [SerializeField] private GameObject panelDialog = null;

    [SerializeField] private int questionMax = 5;
    [SerializeField] private Dialog dialog;
    [SerializeField] private float typingSpeed = 0.1f;
    [SerializeField] private GameObject[] panelChoices = null;



    private int questionCurrent = 0;
    private string currentSentence;
    private int indexSentence;
    private int indexChoices;
    

    private void Awake()
    {
        indexSentence = 0;
        textBoxDialog.text = "";
    }

    void Start()
    {
        panelDialog.SetActive(true);
        ShowSentence();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToNextSentence()
    {
        UnShowChoices();
        ShowSentence();
        indexChoices++;
    }

    private void ShowChoices()
    {
        panelChoices[indexChoices].SetActive(true);
    }

    public void UnShowChoices()
    {
        panelChoices[indexChoices].SetActive(false);
    }

    private void ShowSentence()
    {
        currentSentence = GetSentenceCurrent();
        ShowDialog(currentSentence, typingSpeed, textBoxDialog);
        indexSentence++;
    }

    public void GoodResponse()
    {
        questionCurrent++;
        Debug.Log("Quizz: " + questionCurrent);
    }

    public void WrongResponse()
    {
        questionCurrent++;
        Debug.Log("Quizz: " + questionCurrent);
    }

    public void WinExam()
    {
        if (questionCurrent == questionMax)
        {
            // Add max score
        } 
        else if (questionCurrent < questionMax / 2)
        {
            // Add mid score
        }
        else
        {
            // Sub score (penality)
        }

    }
    public string GetSentenceCurrent()
    {
        return dialog.GetSentence(indexSentence);
    }

    public void ShowDialog(string sentence, float typingSpeed, TextMeshProUGUI textBox)
    {
        //LevelReference.Instance.UIManager.EnableDialogUI();
        currentSentence = sentence;
        this.typingSpeed = typingSpeed;
        StartCoroutine(Type(textBox));
    }

    IEnumerator Type(TextMeshProUGUI textBox)
    {
        textBox.text = "";
        foreach (char letter in currentSentence.ToCharArray())
        {
            textBox.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        ShowChoices();

    }
}
