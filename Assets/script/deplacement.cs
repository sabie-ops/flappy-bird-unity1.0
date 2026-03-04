using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 12f;
    public bool birdIsAlive = true;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        
    }
        private void OnCollisionEnter2D(Collision2D collision)
      {
        // Si on touche un tuyau ou le sol
        birdIsAlive = false;
        Debug.Log("Game Over !");
      }

}

