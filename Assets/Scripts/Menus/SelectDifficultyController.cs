using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectDifficultyController : MonoBehaviour
{
    public Slider difficultySlider;
    public static string selectedDifficulty = "Easy";

    public void Difficulty()
    {
        int sliderValue = (int)difficultySlider.value;
        switch (sliderValue)
        {
            case 0:
                selectedDifficulty = "Easy";
                break;
            case 1:
                selectedDifficulty = "Medium";
                break;
            case 2:
                selectedDifficulty = "Hard";
                break;
            default:
                selectedDifficulty = "Easy";
                break;
        }
        Debug.Log("Selected difficulty : "+selectedDifficulty);
        SceneManager.LoadScene("PongGame");
    }
}
