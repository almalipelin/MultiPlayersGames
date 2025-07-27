using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int player1Score = 0;
    public int player2Score = 0;

    public TextMeshProUGUI player1Text;
    public TextMeshProUGUI player2Text;

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

    void Start()
    {
        player1Text.text = player1Score.ToString();
        player2Text.text = player2Score.ToString();
    }

    public void AddScore(int playerNumber)
    {
        if (playerNumber == 1)
        {
            player1Score++;
            player1Text.text = player1Score.ToString();
        }
        else if (playerNumber == 2) 
        {
            player2Score++;
            player2Text.text = player2Score.ToString();
        }
    }

    public int GetScore(int playerNumber)
    {
        if (playerNumber == 1) return player1Score;
        else if (playerNumber == 2) return player2Score;
        return 0; // Hata durumu
    }

    public void ResetScores()
    {
        player1Score = 0;
        player2Score = 0;
        // UI text'lerini burada sýfýrlayabilirsin
    }
}
