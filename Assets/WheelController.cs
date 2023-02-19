using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour {
/*
   void Start(){
    [SerializedField] WheelController FrontRightWheel;
    [SerializedField] WheelController FrontLeftWheel;
    [SerializedField] WheelController BackRightWheel;
    [SerializedField] WheelController BackLeftWheel;

    public float accelaration = 500;
    public float breakingForce = 300;

    private float currantAccelaration = 0;
    private float currantBreakingForce = 0;

   }


     void FixedUpdate() {

    //get formward/revese accelaration from vertical axis
        currantAccelaration = accelaration * Input.GetAxis("Vertical");

        //if pressing space slow down
        if (Input.GetKey(KeyCode.Space))
            currantBreakingForce = breakingForce;
        else
            currantBreakingForce = 0;
        

        //apply acceleration to front wheels
        FrontRightWheel.motorTorque = currantAccelaration;
        FrontLeftWheel.motorTorque = currantAccelaration;

        FrontRightWheel.breakTorque = currantAccelaration;
        FrontLeftWheel.breakTorque = currantAccelaration;
        BackRightWheel.breakTorque = currantBreakingForce;
        BackLeftWheel.breakTorque = currantBreakingForce;
   }*/

}