using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private int MOVEMENTSPEED = 15;
    private Vector3 movement;
    public float rotatespeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement = Vector3.zero;

        if (Input.GetKey(KeyCode.Space))
        {
            movement = new Vector3(0, 0, MOVEMENTSPEED * Time.deltaTime * 2);
        }

        if (Input.GetKey(KeyCode.W))
        {

            movement = new Vector3(0, 0, MOVEMENTSPEED * Time.deltaTime);
            transform.Rotate(Vector3.right);
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement = new Vector3(0, 0, -MOVEMENTSPEED * Time.deltaTime);
            transform.Rotate(Vector3.left);
        }

        if (Input.GetKey(KeyCode.A))
        {
            ////movement = new Vector3(-MOVEMENTSPEED * Time.deltaTime,0,0);
            //transform.Rotate(Vector3.down, rotatespeed);
            //BirdPosition = new Vector2(x, y) * Time.deltaTime;
            //transform.Translate(new Vector3(speed, 0.0f, 0f) * Time.deltaTime);
            transform.Rotate(Vector3.forward);
            transform.Rotate(Vector3.down, rotatespeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            ////movement = new Vector3(MOVEMENTSPEED * Time.deltaTime, 0, 0);
            //transform.Rotate(Vector3.up, rotatespeed);
            transform.Rotate(Vector3.back);
            transform.Rotate(Vector3.up, rotatespeed);
        }






        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Rotate(Vector3.right);
        //    MOVEMENTSPEED = 5;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Rotate(Vector3.back);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Rotate(Vector3.left);
        //    MOVEMENTSPEED = 5;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Rotate(Vector3.forward);
        //}





        if (Input.GetKey(KeyCode.C))
        {
            MOVEMENTSPEED = 15;
        }
        else
        {
            MOVEMENTSPEED = 10;
        }


        transform.Translate(movement);

    }
}

//    private int speed = 50;
//    float x = 0.0f;
//    float y = 0.0f;

//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        {

//            //sets the boat position to be a new vector2
//            Vector3  BirdPosition = new Vector2(x, y);
//            //this gets the player axis
//            BirdPosition = new Vector3(Input.GetAxis("Player1Horizontal") * speed * Time.deltaTime, Input.GetAxis("Player1Vertical") * speed * Time.deltaTime, 0);

//            //Tests for if the player has pressed the Up arrow
//            if (Input.GetKey(KeyCode.UpArrow))
//            {
//                BirdPosition = new Vector2(x, y) * Time.deltaTime;
//                transform.Translate(new Vector3(speed, 0.0f, 0f) * Time.deltaTime);
//            }

//            //Tests for if the player has pressed the Down arrow
//            if (Input.GetKey(KeyCode.DownArrow))
//            {
//                BirdPosition = new Vector2(-x, y) * Time.deltaTime;
//                transform.Translate(new Vector3(-speed, 0.0f, 0f) * Time.deltaTime);
//            }

//            //Tests for if the player has pressed the Left arrow
//            if (Input.GetKey(KeyCode.LeftArrow))
//            {
//                BirdPosition = new Vector2(x, y) * Time.deltaTime;
//                //transform.Translate(new Vector3(speed, 0.0f, 0f) * Time.deltaTime);
//                transform.Rotate(Vector3.forward);
//            }

//            //Tests for if the player has pressed the Right arrow
//            if (Input.GetKey(KeyCode.RightArrow))
//            {
//                BirdPosition = new Vector2(x, -y) * Time.deltaTime;
//                //transform.Translate(new Vector3(speed, 0.0f, 0f) * Time.deltaTime);
//                transform.Rotate(Vector3.back);
//            }


//            //SPEED

//            if (Input.GetKey(KeyCode.RightShift))
//            {
//                speed = 4;
//            }
//            else
//            {
//                speed = 50;
//            }
//        }
//    }
//}