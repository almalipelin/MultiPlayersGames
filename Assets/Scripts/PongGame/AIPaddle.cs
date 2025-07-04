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
            difficultyOffset = 5f;
        }
        if(SelectDifficultyController.selectedDifficulty == "Medium")
        {
            moveSpeed = 7f;
            difficultyOffset = 2.5f;
        }
        if(SelectDifficultyController.selectedDifficulty == "Hard")
        {
            moveSpeed = 10f;
            difficultyOffset = 1f;
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
        Vector3 targetPosition = new Vector3(currentPosition.x, Ball.position.y, currentPosition.z);

        // Sadece moveSpeed'e göre hareket
        transform.position = Vector3.MoveTowards(currentPosition, targetPosition, moveSpeed * Time.deltaTime);
        //float targetY =Ball.position.y;
        //float lerpedY = Mathf.Lerp(currentPosition.y, targetY, moveSpeed*Time.deltaTime/difficultyOffset);
        //transform.position = new Vector3(currentPosition.x, lerpedY, currentPosition.z);
    }
}