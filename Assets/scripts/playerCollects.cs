using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollects : MonoBehaviour
{
    public int points = 0;
  
    private void OnGUI(){
        GUI.Label (new Rect(20, 20, 200, 40), points+" fish collected");
    }
}
