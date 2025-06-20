using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamesSceneController : MonoBehaviour
{
    public void OnGameButtonCLicked()
    {
        if(PlayerSelectionController.numberOfPlayers == 1)
        {
            SceneManager.LoadScene("SelectDifficulty");
        }
        else
        {
            SceneManager.LoadScene("PongGame");
        }
    }
}
