using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;//control le bodie 
    public float flapStrength = 2f; //control jump (normale)
    public bool birdIsAlive = true; //fin du jeux (?)
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) //verifie si jouer et en vie et si la bar d'espace a ete clicke
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength; //upward velocity
        }
        
    }
        private void OnCollisionEnter2D(Collision2D collision) //detection des collision
      {
        // Si on touche un tuyau ou le sol
        birdIsAlive = false;
        Debug.Log("Game Over !");
      }

}

