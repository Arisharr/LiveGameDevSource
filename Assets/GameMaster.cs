using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public float score = 0;
    private int intScore;
    public GameObject death_canvas;
    public Text Score;
    public Text highScore;
    public GameObject Player;
    public GameObject EnemyPrefab;
    public bool playing;

    private void Start()
    {
        playing = true;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (playing)
        {
            score += Time.deltaTime * 7;
            int intScore = Mathf.RoundToInt(score);
        }
        
        Score.text = "Score: " + score.ToString("0");

        PlayerPrefs.SetFloat("HighScore", score); 
        highScore.text = "Your highscore = " + PlayerPrefs.GetFloat("HighScore").ToString("0");
    }

    public void Death()
    {
        playing = false;
        death_canvas.SetActive(true);
        Destroy(Player);
    }


    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
