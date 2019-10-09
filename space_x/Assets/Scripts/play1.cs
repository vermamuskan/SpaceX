using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play1 : MonoBehaviour
{
   [SerializeField]float movementSpeed = 50f;
   [SerializeField]float turnSpeed = 60f;
   [SerializeField]Thruster thruster;
    Transform myT;

    void Awake()
   {
    myT= transform;
   }
    void Update()
    {
      Turn();
      Thrust();
        
    }
   void Turn()
    {
        float yaw=turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch=turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll=turnSpeed * Time.deltaTime * Input.GetAxis("Roll");
        myT.Rotate(pitch,yaw,roll);
    }   
    void Thrust()
    {
        if(Input.GetAxis("Vertical") > 0)
        myT.Translate (0f, Time.deltaTime *movementSpeed* Input.GetAxis("Vertical"),0f);
   }
}
