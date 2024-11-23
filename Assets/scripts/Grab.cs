
using UnityEngine;

using TMPro;

public class Grab : MonoBehaviour
{
    public Animator animator;
    public GameObject hands;
    GameObject grabbedObj;
    public static int points;
    public TextMeshProUGUI pointsDisplay;
    
    public bool canPickUp;
    void Start()
    {
        canPickUp=false;
        points = 0;
        SetPointsDisplay();
    }
    void SetPointsDisplay(){
        pointsDisplay.text = points.ToString()+" fish collected!";
    }

    // Update is called once per frame
    void Update()
    {
        if (canPickUp == true){
            if (Input.GetMouseButtonDown(0)){
                animator.SetBool("isArmUp", true);
                grabbedObj.GetComponent<Rigidbody>().isKinematic = true;
                grabbedObj.transform.position = hands.transform.position; 
                grabbedObj.transform.parent = hands.transform;
                Invoke ("TimeDelay", 1);
            }
        
            else if (Input.GetMouseButtonUp(0)){
                animator.SetBool("isArmUp", false);   
            }
        }
    }
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag=="fish"){
            canPickUp=true;
            grabbedObj=other.gameObject;
        }
    }
    private void OnTriggerExit (Collider other){
        canPickUp=false;
    }
    private void TimeDelay (){
        grabbedObj.SetActive(false);//makes it disappear
        grabbedObj.transform.parent = null; // Unparent the object
        grabbedObj = null; // Clear

        points++;
        SetPointsDisplay();
        
    }
    
}
