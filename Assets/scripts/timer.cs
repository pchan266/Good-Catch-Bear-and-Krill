
using TMPro;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float timeLeft;
    public bool timerOn = false;
    public TextMeshProUGUI timerDisplay;
    private bool timerOver;
    public GameEnd gameEnd;
    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn){
            if (timeLeft >0){
                timeLeft -= Time.deltaTime;
                UpdateTimer (timeLeft);
            }
            else{
                if (!timerOver){
                timerOver=true;
                timerDisplay.color = Color.red;
                gameEnd.GameOver(Grab.points);
                Debug.Log("GAME OVER");
                timeLeft = 0;
                timerOn = false;
            }
            }
        }
        
    }
    void UpdateTimer(float currentTime){
        currentTime++;

        float minutes = Mathf.FloorToInt (currentTime/60);
        float seconds = Mathf.FloorToInt (currentTime %60);

        timerDisplay.text = string.Format ("{0:00}:{1:00}", minutes, seconds);
    }
}
