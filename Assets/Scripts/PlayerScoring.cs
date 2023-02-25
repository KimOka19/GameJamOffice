using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoring : MonoBehaviour
{
    private int playerScore = 0;
    private rankEnum  playerRank = rankEnum.E;
    private enum rankEnum
    {
        S,
        A,
        B,
        C,
        D,
        E
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreAdd(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
    } 
    public void ScoreRemove(int scoreToRemove)
    {
        if (playerScore >= scoreToRemove)
        {
            playerScore = playerScore - scoreToRemove;
        }
        else
        {
            playerScore = 0;
        }

    }

    private void RankCalcul()
    {
        if (playerScore >= 0)
        {
            playerRank = rankEnum.E;
        }
        else if (playerScore >= 1000)
        {
            playerRank = rankEnum.D;
        }
        else if (playerScore >= 2000)
        {
            playerRank = rankEnum.C;
        }
        else if(playerScore >= 3000)
        {
            playerRank = rankEnum.B;
        }
        else if (playerScore >= 4000)
        {
            playerRank = rankEnum.A;
        }
        else if (playerScore >= 5000)
        {
            playerRank = rankEnum.S;
        }
    }
}
