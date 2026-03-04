using UnityEngine;
using UnityEngine.UI;

public class logicscore : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public int playerScore;
    public Text scoreText; // Glisse ton objet UI Text ici

    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
}
