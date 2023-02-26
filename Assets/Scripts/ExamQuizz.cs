using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExamQuizz : MainTask
{
    [SerializeField] private TextMeshProUGUI textBoxDialog = null;

    [SerializeField] private GameObject panelDialog = null;
    [SerializeField] private int scoreOneQuestion = 250;

    [SerializeField] private int questionMax = 5;
    [SerializeField] private Dialog dialog;
    [SerializeField] private float typingSpeed = 0.1f;
    [SerializeField] private GameObject[] panelChoices = null;

    [SerializeField] private Transform SpawnPoint = null;
    [SerializeField] private GameObject character = null;

    private int questionCurrent = 0;
    private string currentSentence;
    private int indexSentence = 0;
    private int indexChoices = 0;
    

    private void Awake()
    {
        indexSentence = 0;
        textBoxDialog.text = "";
        indexChoices = 0;
    }

    void Start()
    {
        Instantiate<GameObject>(character, SpawnPoint);

        panelDialog.SetActive(true);
        ShowSentence();
    }

    // Update is called once per frame
    void Update()
    {
        if (dialog.GetSentence(indexSentence) == null)
        {
            WinExam();
        }
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
        LevelReferences.Instance.playerScoring.ScoreAdd(scoreOneQuestion);
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
           LevelReferences.Instance.playerScoring.ScoreAdd(2500);
        }
        else if (questionCurrent < questionMax / 2)
        {
            LevelReferences.Instance.playerScoring.ScoreAdd(450); // Add mid score 
        }
        else
        {
            LevelReferences.Instance.playerScoring.ScoreRemove(600);// Sub score (penality)
        }

        LevelReferences.Instance.taskManager.FinishTaskCurrent();
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
