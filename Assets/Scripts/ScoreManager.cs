using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int player1Score = 0;
    public int player2Score = 0;

    public Text player1Text;
    public Text player2Text;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int playerNumber)
    {
        if (playerNumber == 1)
        {
            player1Score++;
        }
        else
        {
            player2Score++;
        }

        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        player1Text.text = player1Score.ToString();
        player2Text.text = player2Score.ToString();
    }
}
