using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private float boundaries = 2.55f;
    void Update()
    {
        movePlayer();
    }
    void movePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 currentPosition = transform.position;
        if (h > 0)
        {
            currentPosition.x += speed * Time.deltaTime;
        }
        else if (h < 0)
        {
            currentPosition.x -= speed * Time.deltaTime;

        }
        if (currentPosition.x < -boundaries)
            currentPosition.x = -boundaries;
        if (currentPosition.x > boundaries)
            currentPosition.x = boundaries;

        transform.position = currentPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
            Time.timeScale = 0f;
    }
}
