using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Logiccript : MonoBehaviour
{
    public kimdpkjaScript kim;
    
    public int playerScore;
    public int bestScore;
    public int kalici;
    public Text scoreText;
    public Text bestScoreText;
     public GameObject gameOverScreen;
    public SoundEffectLayer sound;
    
    void Start()
    {
        if (!PlayerPrefs.HasKey("hiScore")) {

            Debug.Log("creating high score pref");

            PlayerPrefs.SetInt("hiScore", 0);
        }


        kim = GameObject.FindGameObjectWithTag("Kim").GetComponent<kimdpkjaScript>();
        sound = GameObject.FindGameObjectWithTag("Canvas").GetComponent<SoundEffectLayer>();
        writeBestScore(PlayerPrefs.GetInt("hiScore"));
       
    }

    void Update()
    {
       
        if (PlayerPrefs.HasKey("hiScore")){
            
            if (playerScore >= PlayerPrefs.GetInt("hiScore"))
            {
                Debug.Log("highscore algýlandý");
                bestScore = playerScore;
                PlayerPrefs.SetInt("hiScore", bestScore);
                PlayerPrefs.Save();
                writeBestScore(PlayerPrefs.GetInt("hiScore"));
            }
            }

     }

            /*
            if (bestScore<=playerScore){
                bestScore = playerScore;
            }

            writeBestScore(bestScore);
            kalici = bestScore;
            PlayerPrefs.SetInt("highScore", kalici);
            PlayerPrefs.Save();
            */
        


   

    [ContextMenu("Increase Score")]

    public void addScore(int scoreToAdd){
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        if (playerScore%10 == 0)
        {
            sound.ten();
        }
        setPlayerScore(playerScore);
    }
    public void setPlayerScore(int playerScore)
    {
        this.playerScore = playerScore;
    }

    public void writeBestScore(int best){
        bestScoreText.text = best.ToString();
    }

    public void restartGame(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

     public void gameOver(){
        sound.hit();
        gameOverScreen.SetActive(true);
        playerScore = 0;

    }

}
