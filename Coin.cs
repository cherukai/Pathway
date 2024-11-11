using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    public float speed = 3f; // Speed at which the coin moves
    public float respawnXPosition = 10f; // Starting X position when it appears
    public float endXPosition = -10f; // X position at which the coin disappears

    private void Start()
    {
        RespawnCoin(); // Place the coin at a random Y position on start
    }

    private void Update()
    {
        // Move the coin to the left at a constant speed
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Check if the coin has reached the end position
        if (transform.position.x <= endXPosition)
        {
            RespawnCoin(); // Respawn the coin at a random Y position
        }
    }

    private void RespawnCoin()
    {
        float randomY = Random.Range(-4f, 4f); // Random Y position within screen bounds
        transform.position = new Vector2(respawnXPosition, randomY); // Set coin to start position
    }
}
