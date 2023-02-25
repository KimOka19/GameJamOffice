using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class BufferScript : MonoBehaviour
{
    [SerializeField]
    private Transform bufferBasePosition;

    [SerializeField]
    private GameObject buffer = null;

    [SerializeField]
    private List<Vector3> vectorList;


    private Vector3 currentPosition;

    private Vector3 randomPosition;

    private bool clickPressed = false;

    private int documentNumber = 6;
    private int currentdocumentNumber = 0;

    IEnumerator Delay(int secondsToWait)
    {
        yield return new WaitForSeconds(secondsToWait);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Set random height to base object height
        StartCoroutine(Delay(1));
        MoveToNewPosition();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            clickPressed = true;
        }

    }

    //public void SpawnBuffer()
    //{
    //    Instantiate(buffer);
    //    buffer.transform.position = bufferBasePosition.position;
    //    FindNewPosition();
    //}

    private void FindNewPosition()
    {
        //Set new position to base position +- range, only on 2 axes
        randomPosition = vectorList[Random.Range(0, vectorList.Count)];
    }

    public void MoveToNewPosition()
    {
        FindNewPosition();
        //Object Move
        gameObject.transform.position = randomPosition;
        //Check if player pressed the button during the process
        if (clickPressed == true)
        {
            //Save Object position
            currentPosition = gameObject.transform.position;
            Stamped();
        }
        else
        {
            //Delay and looping
            StartCoroutine(Delay(1));
            MoveToNewPosition();

        }
    }

    private void Stamped()
    {
        gameObject.transform.Translate(currentPosition.x, currentPosition.y - 0.1f, currentPosition.z);

        gameObject.transform.Translate(currentPosition.x, currentPosition.y + 0.1f, currentPosition.z);
        clickPressed = false;
        currentdocumentNumber ++;
        if(currentdocumentNumber < documentNumber)
        {
            FindNewPosition();
        }
        else
        {

        }
    }
}
