using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private CharacterController controller;
   private Vector3 direction;

   public float forwardSpeed;
    public float forwardSpeedY;
    public bool isGameStarted = false;
    
   private int desiredLane = 1; //0:left 1:center 2:right
   public float laneDistance = 4;
   void Start(){
       controller = GetComponent<CharacterController>();
   }
   void Update(){
        if (isGameStarted)
        {
      direction.z = forwardSpeed;
 
            if (Input.GetKeyDown(KeyCode.RightArrow)){
          desiredLane++;
          if(desiredLane == 3){
              desiredLane = 2;
          }
      }
       if(Input.GetKeyDown(KeyCode.LeftArrow)){
          desiredLane--;
          if(desiredLane == -1){
              desiredLane = 0;
          }
      }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                this.gameObject.GetComponentInChildren<Animator>().SetBool("isJumping", true);
                this.gameObject.GetComponentInChildren<Animator>().SetBool("isSlide", false);
                this.gameObject.GetComponentInChildren<Animator>().SetBool("isRunning", false);
                direction.y = forwardSpeedY;
            }
            Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
      if(desiredLane == 0){
          targetPosition += Vector3.left * laneDistance;
      } else if(desiredLane==2){
          targetPosition += Vector3.right * laneDistance;
      }
      transform.position = targetPosition;
   //   transform.position = Vector3.Lerp(transform.position, targetPosition, 20 * Time.deltaTime);
        }

   }
   private void FixedUpdate(){
        if (isGameStarted)
        {
            controller.Move(direction * Time.fixedDeltaTime);
        }
        
   }
}