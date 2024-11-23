
using UnityEngine;


public class tankMovement : MonoBehaviour
{
  public float mSpeed = 12f;
  public float mTurnSpeed = 180f;
  private string mMovementAxisName;       
  private string mTurnAxisName; 
  private Rigidbody mRigidbody;
  private float mMovementInput;
  private float mTurnInput;

  
  private void Awake(){
    mRigidbody = GetComponent<Rigidbody>();
  }
    void Start()
    {
    
    mMovementAxisName = "Vertical";
    mTurnAxisName = "Horizontal";
    }

    // Update is called once per frame
    void Update()
    {
        mMovementInput = Input.GetAxis (mMovementAxisName);
        mTurnInput = Input.GetAxis (mTurnAxisName);
    }
    private void FixedUpdate(){
        Move();
        Turn();
    }
    private void Move(){
        Vector3 movement = transform.forward * mMovementInput * mSpeed * Time.deltaTime;
        mRigidbody.MovePosition(mRigidbody.position+movement);
    }
    private void Turn(){
        float turn =mTurnInput * mTurnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler (0f,turn,0f);
        mRigidbody.MoveRotation(mRigidbody.rotation*turnRotation);

    }
  
}
