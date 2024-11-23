
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject helpUI;
 public void PlayButton(){
    SceneManager.LoadScene("Game");
 }
 public void HelpButton(){
    helpUI.SetActive(true);
 }
 public void OKButton(){
    helpUI.SetActive(false);
 }
}
