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

   
    public Transform ballTransform;

    void Start()
    {
        if (PlayerSelectionController.numberOfPlayers == 1)
        {
            Instantiate(playerPaddlePrefab, playerSpawnPoint.position, Quaternion.identity);
            GameObject aiPaddleInstance = Instantiate(aiPaddlePrefab, aiSpawnPoint.position, Quaternion.identity);
            AIPaddle AIPaddleScript = aiPaddleInstance.GetComponent<AIPaddle>();
            if (AIPaddleScript != null )
            {
                AIPaddleScript.SetBallTransform(ballTransform);
            }
        }
        else if (PlayerSelectionController.numberOfPlayers == 2)
        {
            Instantiate(playerPaddlePrefab, playerSpawnPoint.position, Quaternion.identity);
            Instantiate(playerTwoPaddlePrefab, aiSpawnPoint.position, Quaternion.identity);
        }
    }

    /*void Update()
    {
        Vector3 currentPosition = aiPaddlePrefab.transform.position;
        Vector3 targetPosition = new Vector3(currentPosition.x, ballTransform.position.y, currentPosition.z);

        aiPaddlePrefab.transform.position = Vector3.MoveTowards(currentPosition, targetPosition, 5 * Time.deltaTime);

    }*/
}
