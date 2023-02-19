using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class boxMovment : MonoBehaviour
{
    new Vector3 direction = (1,0,0);
    new Vector3 volocity = (0,0,0);
    float engineForce = 100;
    new Vector3 fTracsion =  engineForce;
    float cDrag =  0.4257f;
    new Vector3 fDrag = (0,0,0);
    new Vector3 fIT = (0,0,0);
    new Vector3 fLong = (0,0,0);
    float cIT = 12.8;
    float tiltAngle = 100f;
    float tiltAroundY = 0f;
    float turnSmoothness = 5f;
    float force = 150f;
    float mass = 100f;
    new Vector3 accelaration = force/mass;
    new Vector3 fDrive = (0,0,0);
    float tEngine;
    float tDrive;
    float[] gear = new float{0,2.66,1.78,1.3,1,0.74,0.5};
    float[] maxTorque = new float{0,4400,3000,2100,1600,1250,800};
    int gear =1;
    float differentialRatio = 3.42;
    float transmissionEfficiency =0.7;
    float wheelRadius = 0.34;


    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
           accelaration *= 1.1;
        }else
        {
            accelaration *= 0.9;
        }
        

        tEngine = maxTorque[gear];
        tDrive = tEngine * gear[gear] * differentialRatio * transmissionEfficiency;
        
        fDrive = direction * tEngine * gear[gear]* differentialRatio * transmissionEfficiency* wheelRadius;
        direction = transform.rotation;
        fTracsion = direction * engineForce;
        fDrag = -cDrag * volocity * volocity.magnitude;
        fIT = -cIT * volocity;
        fLong = fTracsion + fIT + fDrag;
        accelaration = fLong/mass;
        volocity += Time.deltaTime * accelaration;




        if(Input.GetKey(KeyCode.D)){
            tiltAroundY += tiltAngle;
            transform.Rotate(0, Input.GetAxis("Horizontal") * tiltAngle * Time.deltaTime, 0);
            direction = Math.ABS(volocity)/volocity.magnitude;
        }
        if(Input.GetKey(KeyCode.A)){
           tiltAroundY -= tiltAngle;
           transform.Rotate(0, Input.GetAxis("Horizontal") * (tiltAngle) * Time.deltaTime, 0);
           direction = Math.ABS(volocity)/volocity.magnitude;
        }

        transform.Translate(Time.deltaTime * volocity);

       // Quaternion target = Quaternion.Euler(0, tiltAroundY, 0);
        //transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * turnSmoothness);
        
        //tiltAroundY = 0;
      
    }
}
