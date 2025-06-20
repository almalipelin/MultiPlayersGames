using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    public float moveSpeed = 10f;
    public bool isPlayerOne = true; // Bu paddle 1. oyuncu mu?

    private void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (isPlayerOne && touch.position.x > Screen.width / 2)
            {
                MovePaddle(touch);
            }
            else if (!isPlayerOne && touch.position.x <= Screen.width / 2)
            {
                MovePaddle(touch);
            }
        }
    }

    void MovePaddle(Touch touch)
    {
        float minY = -3.75f;
        float maxY = 3.75f;
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
        Vector3 newPosition = new Vector3(transform.position.x, touchPosition.y, transform.position.z);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);
        transform.position = Vector3.Lerp(transform.position, newPosition, moveSpeed * Time.deltaTime);
    }
}
