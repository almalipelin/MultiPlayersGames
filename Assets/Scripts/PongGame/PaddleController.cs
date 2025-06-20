using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpawner : MonoBehaviour
{
    public GameObject playerPaddlePrefab;
    public GameObject playerTwoPaddlePrefab;
    public GameObject aiPaddlePrefab;

    public Transform playerSpawnPoint;
    public Transform aiSpawnPoint;

    void Start()
    {
        if (PlayerSelectionController.numberOfPlayers == 1)
        {
            Instantiate(playerPaddlePrefab, playerSpawnPoint.position, Quaternion.identity);
            Instantiate(aiPaddlePrefab, aiSpawnPoint.position, Quaternion.identity);
        }
        else if (PlayerSelectionController.numberOfPlayers == 2)
        {
            Instantiate(playerPaddlePrefab, playerSpawnPoint.position, Quaternion.identity);
            Instantiate(playerTwoPaddlePrefab, aiSpawnPoint.position, Quaternion.identity);
        }
    }
}
