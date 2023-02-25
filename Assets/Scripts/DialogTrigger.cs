using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogTrigger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textBoxDialog = null;

    [SerializeField] private Dialog dialog;
    [SerializeField] private float typingSpeed = 0.1f;
    [SerializeField] private string currentSentence;

    private int indexSentence;

    private void Awake()
    {
        indexSentence = 0;
        textBoxDialog.text = "";
    }

    private void Start()
    {
        currentSentence = GetSentenceCurrent();
        ShowDialog(currentSentence, typingSpeed, textBoxDialog);
        indexSentence++;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            currentSentence = GetSentenceCurrent();
            ShowDialog(currentSentence, typingSpeed, textBoxDialog);
            indexSentence++;
        }
    }

    public string GetName()
    {
        return dialog.GetNameDialog();
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

    }
}
