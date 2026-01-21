using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    static int totalScore = 0;
    public Text scoreText;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddScore(int a)
    {
        totalScore += a;
        scoreText.text = "점수: " + totalScore;
        if(totalScore >= 1000)
            SceneManager.LoadScene(1);
    }
}
