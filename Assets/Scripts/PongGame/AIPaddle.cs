using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    public Transform Ball;
    public float moveSpeed = 5f;
    public float difficultyOffset = 0.5f;

    public void SetBallTransform(Transform ballTransform)
    {
        Ball = ballTransform;
    }
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

    // Update is called once per frame
    void Update()
    {
        if (Ball == null)
        {
            return;
        }

        Vector3 currentPosition = transform.position;
        float targetY = Mathf.Lerp(currentPosition.y, Ball.position.y, moveSpeed*Time.deltaTime);
        transform.position = new Vector3(currentPosition.x, targetY, currentPosition.z);
    }
}