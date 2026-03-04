using UnityEngine;

public class destructavance : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadZone = -45f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Déplacement vers la gauche
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // Détruire le tuyau s'il sort de l'écran pour économiser de la mémoire
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
