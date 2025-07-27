using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverPanelController : MonoBehaviour
{
    public static GameOverPanelController Instance;

    public TextMeshProUGUI timerText;
    public GameObject gameOverPanel;
    public TextMeshProUGUI winnerText;

    public float gameDuration = 120f;

    private float currentTime;
    private bool gameEnded = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        currentTime = gameDuration;
        gameOverPanel.SetActive(false);
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (gameEnded) return;
        currentTime -= Time.deltaTime;
        UpdateTimerDisplay();

        if (currentTime <= 0f)
        {
            currentTime = 0f;
            UpdateTimerDisplay();
            EndGame();
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void EndGame()
    {
        gameEnded = true;
        Time.timeScale = 0f;
        DetermineWinner();
        gameOverPanel.SetActive(true);
    }

    void DetermineWinner()
    {
        int player1Score = ScoreManager.instance.GetScore(1);
        int player2Score = ScoreManager.instance.GetScore(2);
        if (player1Score > player2Score)
        {
            winnerText.text = "Player 1 Wins!";
        }
        else if (player1Score < player2Score)
        {
            winnerText.text = "Player 2 Wins!";
        }
        else
        {
            winnerText.text = "It's a Tie!";
        }
        
        if (PlayerSelectionController.numberOfPlayers ==1)
        {
            if (player1Score > player2Score)
            {
                winnerText.text = "You Lost!";
            }
            else if (player1Score < player2Score)
            {
                winnerText.text = "You Wins!";
            }
            else
            {
                winnerText.text = "It's a Tie!";
            }
        }
    }

    public void PlayAgain()
    {
        Time.timeScale = 1f; // Zamaný normale döndür
        gameEnded = false;
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Mevcut sahneyi yeniden yükle
        // Veya daha iyisi, topu ve skorlarý resetleyip oyunu sýfýrlayalým
         // Paneli gizle
        SceneManager.LoadScene("PongGame"); // Zamanlayýcýyý sýfýrla
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f; // Zamaný normale döndür
        gameEnded = false;
        // Ana menü sahnesine geçiþ yap
        SceneManager.LoadScene("Games"); // "MainMenu" yerine kendi menü sahnenizin adýný yazýn
    }
}
