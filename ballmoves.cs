using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmoves : MonoBehaviour
{
    public float speed=5f;
    private Rigidbody2D myBody;
    
    public Transform groundcheckposition;
  
    private bool isGrounded;
    private bool jumped;
    private float jumppower=5f;
    public LayerMask groundLayer;

    


    void Awake(){

     myBody=GetComponent<Rigidbody2D>();



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
                                                          

                                                         }

                                                       else if(h<0){


                                                        	myBody.velocity=new Vector2 (-speed,myBody.velocity.y);
                                                        
                                                        }

                                                      else{

                                                      myBody.velocity=new Vector2(0f,myBody.velocity.y);

                                                      }



                                                  

                                                      }
                                                    

                                                       

                                                      void CheckIfgrounded(){
                                                         isGrounded=Physics2D.Raycast(groundcheckposition.position,Vector2.down,0.0f,groundLayer);
                                                         if (isGrounded){


                                                         	if (jumped){

                                                         jumped=false;
                                                        


                                                         	}



  	}



}
  void PlayerJump(){
	if (isGrounded){


    if(Input.GetKey(KeyCode.Space)){



  	  jumped = true;
    	myBody.velocity=new Vector2 (myBody.velocity.x,jumppower);
    	
    }

	}
}

}






























    // Update is called once per frame
    
//class




















































