
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public GameObject gameOverUI;
    public TextMeshProUGUI finalScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver(int finalPoints){
        finalScoreDisplay.text = "Final Score: " + finalPoints.ToString();
        
        gameOverUI.SetActive(true);
       
    }
    public void Restart(){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu(){
        SceneManager.LoadScene("Main Menu");
    }
}
