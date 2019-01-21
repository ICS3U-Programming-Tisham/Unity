using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Here's all the variables 

    //This is to control spawning values (number, location, hazards used, etc.)
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float ElapsedTime;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    //Used to control text to operate the way it should
    public Text scoreText;
    public Text timeText;
    public Text restartText;
    public Text gameOverText;
    public Text endGameText;

    //Used to calculate score and convert to text, and let the restart + game over text pop up at the right time
    private bool gameOver;
    private bool restart;
    private int score;
    private bool endGame;

    //Resets all the text, and starts the spawning process
    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    //When the game is over, we use this to restart with the "R" button
    void Update()
    {
        ElapsedTime = Time.time;
        timeText.text = "" + ElapsedTime;
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    //Wave spawning code
    IEnumerator SpawnWaves()
    {
        //Will wait for the amount of seconds you designate
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            //Spawns in hazards
            for (int i = 0; i < hazardCount; i++)
            {
                //lets you determine hazard count
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            //If the game is over, shows restart text, enables the "R" button for restart, and stops spawning hazards
            if (gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }
        }
    }

    //Adds score whenever a hazard is destroyed
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    
    //Changes the score text
    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    //Activates when player dies, gameOver variable enables restart 
    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }

}