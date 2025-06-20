using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    private Transform Ball;
    public float moveSpeed = 5f;
    public float difficultyOffset = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        if(SelectDifficultyController.selectedDifficulty == "Easy")
        {
            moveSpeed = 5f;
            difficultyOffset = 2f;
        }
        if(SelectDifficultyController.selectedDifficulty == "Medium")
        {
            moveSpeed = 7f;
            difficultyOffset = 1f;
        }
        if(SelectDifficultyController.selectedDifficulty == "Hard")
        {
            moveSpeed = 10f;
            difficultyOffset = 0.2f;
        }
    }
    public void SetTarget(Transform newTarget)
    {
        Ball = newTarget;
    }

    // Update is called once per frame
    void Update()
    {
        if(Ball != null)
        {
            Vector3 currentPosition = transform.position;
            Vector3 targetPosition = new Vector3(currentPosition.x,Ball.position.y,currentPosition.z);
            transform.position = Vector3.MoveTowards(currentPosition,targetPosition,moveSpeed*Time.deltaTime);
        }
    }
}
