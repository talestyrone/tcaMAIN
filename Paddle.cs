using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    //private Ball myBall;

	// Use this for initialization
	void Start () {

        //myBall = GameObject.FindObjectOfType<Ball>();
        //reset x position
        //move y position downwards
        //position.y -= 0.3f;

        int randomposx = (int)Random.Range(-6f, 6f);
        int randomposy = (int)Random.Range(-5f, 5f);
        Vector3 paddlePosition = new Vector3(randomposx, randomposy, 0);

        this.transform.position = paddlePosition;
    }

    // Update is called once per frame
    void Update () {

        //float mousePosInBlocks = (Input.mousePosition.x / Screen.width * 14f) - 7f;

        //Vector3 saves any point in (x,y,z)
        //keeps the y-position fixed

        
        //limit the movement of the mouse from -6.5f to 6.5f in x-axis
        //paddlePosition.x = Mathf.Clamp(myBall.transform.position.x, -6.5f, 6.5f);

        //sets the position of the paddle (this) to 
        //the paddlePosition

        

        

        
		
	}
}
