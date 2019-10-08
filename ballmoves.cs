using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmoves : MonoBehaviour
{
    public float speed=5f;
    private Rigidbody2D myBody;
    //private Animator anim;
    public Transform groundcheckposition;
  //  public OnCollisionEnter2D target;
    private bool isGrounded;
    private bool jumped;
    private float jumppower=5f;
    public LayerMask groundLayer;

    


    void Awake(){

     myBody=GetComponent<Rigidbody2D>();
     //anim=GetComponent<Animator>();



    }
 

                                                      void Update(){

                                                      PlayerJump();
                                                     	CheckIfgrounded();
                                       	


                                                         }

                                                        void FixedUpdate(){

                                                      Playerwalk();

                                                        }

                                                       void Playerwalk(){


                                                      	float h=Input.GetAxisRaw ("Horizontal");

                                                         if(h>0){

                                                          myBody.velocity=new Vector2 (speed,myBody.velocity.y);
                                                          // ChangeDirection(1);

                                                         }

                                                       else if(h<0){


                                                        	myBody.velocity=new Vector2 (-speed,myBody.velocity.y);
                                                        //	ChangeDirection(-1);
                                                        }

                                                      else{

                                                      myBody.velocity=new Vector2(0f,myBody.velocity.y);

                                                      }



                                                     // anim.SetInteger("speed",Mathf.Abs((int)myBody.velocity.x));

                                                      }
                                                      //void ChangeDirection(int direction){

                                                       // Vector3 tempScale=transform.localScale;
                                                       // tempScale.x=direction;
                                                       // transform.localScale=tempScale;
                                                     // }

                                                       //void OnCollisionEnter2D(Collision2D target) {

                                                          // if(target.gameObject.name=="ground"){

                                                         // print("Collided");

                                                         //}

                                                      //}

                                                      void CheckIfgrounded(){
                                                         isGrounded=Physics2D.Raycast(groundcheckposition.position,Vector2.down,0.0f,groundLayer);
                                                         if (isGrounded){


                                                         	if (jumped){

                                                         jumped=false;
                                                         //anim.SetBool("Jump",false);


                                                         	}



  	}



}
  void PlayerJump(){
	if (isGrounded){


    if(Input.GetKey(KeyCode.Space)){



  	  jumped = true;
    	myBody.velocity=new Vector2 (myBody.velocity.x,jumppower);
    	//anim.SetBool("Jump",true);
    }

	}
}

}






























    // Update is called once per frame
    
//class




















































