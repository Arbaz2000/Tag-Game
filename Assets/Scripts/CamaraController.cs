using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialize the offset from the player
        if (Player != null)
        {
            offset = transform.position - Player.transform.position;
        }
        else
        {
            // If no player is found, use the enemy's position and set the offset based on the enemy's position.
            offset = transform.position - Enemy.transform.position;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // If player is found, follow the player
        if (Player != null)
        {
            transform.position = Player.transform.position + offset;
        }
        // If no player is found, follow the enemy
        else if (Enemy != null)
        {
            transform.position = Enemy.transform.position + offset;
        }
    }
}
