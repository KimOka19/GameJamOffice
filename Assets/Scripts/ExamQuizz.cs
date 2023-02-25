using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamQuizz : MonoBehaviour
{
    private int noteQuizz = 0;
    [SerializeField] private int questionMax = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoodResponse()
    {
        noteQuizz++;
        Debug.Log("Quizz: " + noteQuizz);
    }

    public void WrongResponse()
    {
        noteQuizz--;
        Debug.Log("Quizz: " + noteQuizz);
    }

    public void WinExam()
    {
        if (noteQuizz == questionMax)
        {
            // Add max score
        } 
        else if (noteQuizz < questionMax / 2)
        {
            // Add mid score
        }
        else
        {
            // Sub score (penality)
        }



    }
}
