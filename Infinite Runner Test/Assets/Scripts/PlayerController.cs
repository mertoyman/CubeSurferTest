using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    [SerializeField] float horizontalConstantSpeed = 0.05f;
    
    float xPosition;
    Rigidbody rb;
    float firstFinger, lastFinger , distanceBetweenTouches = 0;
    [SerializeField] float borderOfRoad = 3.8f;
    private void Start()
    {
     
        

    }

  

    // Update is called once per frame
    void Update()
    {
        MoveHorizontalWithPc();
        
        foreach(Touch touch in Input.touches)
        {
            if(firstFinger == 0)
            {
                firstFinger = touch.position.x;
                lastFinger = touch.position.x;
            }
            else
            {
                lastFinger = touch.position.x;
                distanceBetweenTouches = lastFinger - firstFinger;
                firstFinger = lastFinger;
            }
        }

        if(distanceBetweenTouches > 0)
        {
            MoveHorizontal(false);
            print("left");
        }
        else if(distanceBetweenTouches < 0)
        {
            print("right");
            MoveHorizontal(true);
        }

       
    }

   

    private void MoveHorizontal(bool isLeft)
    {
        xPosition = transform.localPosition.x;
        distanceBetweenTouches = 0;

        if (isLeft)
        {
            if(xPosition > -borderOfRoad)
            {
                transform.position -= new Vector3(horizontalConstantSpeed, 0, 0);
            }
        } 
        else if(!isLeft){
            if(xPosition < borderOfRoad)
            {
                transform.position += new Vector3(horizontalConstantSpeed, 0, 0);
            }
           
        }
    }
    private void MoveHorizontalWithPc()
    {
        xPosition = transform.localPosition.x;
       // print(xPosition);
        distanceBetweenTouches = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(xPosition > -borderOfRoad)
            {
                transform.position -= new Vector3(horizontalConstantSpeed, 0, 0);
            }
        } 
        else if(Input.GetKey(KeyCode.RightArrow)){
            if(xPosition < borderOfRoad)
            {
                transform.position += new Vector3(horizontalConstantSpeed, 0, 0);
            }
           
        }
    }

   
}
