using UnityEngine;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public logicscript Logic; // C'est ici qu'on stockera le lien vers le score

    void Start()
    {
        // Au lancement, on cherche automatiquement l'objet qui a le tag "Logic"
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("collide with " + collision.gameObject.name);
        // Si l'objet qui entre dans la zone est sur le Layer 3 (ton oiseau)
        if (collision.gameObject.tag == "Player")
        {
            Logic.addScore(); // On appelle la fonction pour ajouter +1
        }
    }
}
