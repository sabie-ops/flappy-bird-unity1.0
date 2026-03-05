using UnityEngine;

public class pipeMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move pipe left every frame
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Destroy pipe if it goes off-screen
        if (transform.position.x < -20f)
        {
            Destroy(gameObject);
        }
    }
}
