using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelectionController : MonoBehaviour
{
    public static int numberOfPlayers = 1;

    public void SelectPlayers(int choice)
    {
        numberOfPlayers = choice;
        Debug.Log("Number of players : "+ numberOfPlayers);
        Games();
    }

    public void Games()
    {
        SceneManager.LoadScene("Games");
    }
}
