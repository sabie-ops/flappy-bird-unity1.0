using UnityEngine;
using TMPro;

public class logicscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public int playerScore;
   public TextMeshProUGUI scoreText; // Glisse ton objet UI Text ici

    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
}
