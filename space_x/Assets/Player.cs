using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void OnEnable(){
        EventManager.onMyEvent+=MoveUp;

    }
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}
   void OnDisable(){
       EventManager.onMyEvent-=MoveUp;
   }
   void MoveUp(){
       transform.position+=transform.up;
   }



}
