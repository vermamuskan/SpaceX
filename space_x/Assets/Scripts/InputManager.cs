using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
   /* void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.W))
           EventManager.MyEvent(true);
       if(Input.GetKeyDown(KeyCode.S))
            EventManager.MyEvent(true);     
    }
}
